using System.ComponentModel.DataAnnotations.Schema;
using hexahack.Models;
using Microsoft.AspNetCore.Identity;

namespace hexahack.Models{
    public class Teacher: IdentityUser {
        public string teacher_name { get; set; } 
        public string email { get; set; }
        [ForeignKey("College")]
        public int college_code { get; set; } // foriegn key
        public string subject { get; set; }
        public int hashed_password { get; set; }
        [ForeignKey("Department")]
        public int d_code { get; set; } // foriegn key
        public College College { get; set; }
        public Department Department { get; set; }
    }
}