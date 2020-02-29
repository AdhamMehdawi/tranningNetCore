 

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication38.DomainModels.StudentModels
{
    //[Table("")]
    public class Student 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
