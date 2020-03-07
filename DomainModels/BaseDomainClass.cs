using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.DomainModels
{
    public class BaseDomainClass
    {
        [Key]
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
