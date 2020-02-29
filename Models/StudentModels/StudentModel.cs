

using System.ComponentModel;

namespace WebApplication38.Models.StudentModels
{
    public class StudentModel
    {
        [DisplayName("Student ID No")]
        public int Id { get; set; }
        [DisplayName("Student Full Name")]
        public string StudentName { get; set; }
        public string StudentMobile { get; set; }
        public string Address { get; set; }
    }
}
