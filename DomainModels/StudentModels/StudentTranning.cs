using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.DomainModels.StudentModels
{
    public class StudentTranning:BaseDomainClass
    {
        public int TrainingId { get; set; }
        public Training Training { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public bool IsCompleet { get; set; }
    }
}
