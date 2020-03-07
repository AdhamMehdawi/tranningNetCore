using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.DomainModels.Courses
{
    public class Course:BaseDomainClass
    {
        [Required]
        [MaxLength(900)]
        [MinLength(3)]
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public List<Training> Trainings { get; set; }
    }
}
