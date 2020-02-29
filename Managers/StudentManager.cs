using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication38.Context;
using WebApplication38.DomainModels.StudentModels;
using WebApplication38.Models.StudentModels;

namespace WebApplication38.Managers
{
    public class StudentManager
    {
        private TCenterContext _centerContext;
        public StudentManager(TCenterContext centerContext)
        {
            _centerContext = centerContext;
        }

        public List<StudentModel> GetAllStudentModels()
        {
            return BuildStudentData();
        }


        public List<Student> GetAllStFromDb()
        {
           return _centerContext.Students.ToList();
        }


        private List<StudentModel> BuildStudentData()
        {
            var stList = new List<StudentModel>();
            for (int i = 1; i <= 10; i++)
            {
                var stObj = new StudentModel
                {
                    Address = "R_"+i,
                    Id = i,
                    StudentMobile = "052222222"+i,
                    StudentName = "st_"+i
                };
                stList.Add(stObj);
            }
            return stList;
        }

    }
}
