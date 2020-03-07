using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication38.Context;
using WebApplication38.DomainModels.Courses;

namespace WebApplication38.Controllers
{
    public class CourceController : Controller
    {
        private TCenterContext _centerContext;
        public CourceController(TCenterContext centerContext)
        {
            _centerContext = centerContext;
        }
        // GET: Cource
        public async Task<ActionResult> Index()
        {
             //1.get all data from DB 
            //2.by using dbContext class you can query Database 
            //in DbContext => DbSet by using DbSet you can query DB 
            // select * from courses 
           var result= await _centerContext.Courses.ToListAsync();
            return View(result);
        }
     

    

        // GET: Cource/Details/5
        public ActionResult Details(int id)
        {
           var result= _centerContext.Courses.Find(id);
           //var result2= _centerContext.Courses.FirstOrDefaultAsync(c=>c.Id == id);
           //var result3 = _centerContext.Courses.Where(c => c.Id == id).ToList();
           //var res= _centerContext.Courses.FromSqlRaw("select * from Courses").Skip(0).Take(10).ToList();
             return View(result);
        }

        // GET: Cource/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cource/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Course obj)
        {
            try
            {
                // TODO: Add insert logic here
                obj.CreateAt = DateTime.Now;
               await  _centerContext.Courses.AddAsync(obj);
               await _centerContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cource/Edit/5
        public ActionResult Edit(int id)
        {
            //1.query to get data from DB 
            //2.return data to view 
            //3.handel edit requist 
           var result=  _centerContext.Courses.Find(id);
            return View(result);
        }

        // POST: Cource/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Course obj)
        {
            try
            {
                _centerContext.Courses.Update(obj);
                await _centerContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cource/Delete/5
  


        // POST: Cource/Delete/5
        //[HttpDelete]
         public async Task<ActionResult> Delete(int id)
        {
            try
            {
                //1. get obj from database 
                //2. attach obj to Entity stack with remove status 
                //3. save changes to reflect changes to db 
                var obj= _centerContext.Courses.Find(id);
                _centerContext.Courses.Remove(obj);
                await _centerContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}