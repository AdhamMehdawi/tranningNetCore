using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WebApplication38.DomainModels.Courses;
using WebApplication38.DomainModels.StudentModels;

namespace WebApplication38.DomainModels
{
    public class Training:BaseDomainClass
    {
        [Required]
        public string Title { get; set; }
        public string Decreption { get; set; }
        public string Outline { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Required]
        public int HoursNo { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<StudentTranning> Students { get; set; }
          
    }
}
