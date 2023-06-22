using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace nyanlearn.Models
{
    public class StudentViewModel:BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Possition { get; set; }
        public DateTime DOB { get; set; }
        public  string Email { get; set; }
        public string NRC { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }


        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}