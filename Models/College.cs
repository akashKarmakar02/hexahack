using System.ComponentModel.DataAnnotations;

namespace hexahack.Models
{
    public class College
    {
        public string college_name { get; set; }
        [Key]
        public int college_code { get; set; } // primary key
        public string email { get; set; }
        public string state { get; set; }
        public int hashed_password { get; set; }
        public string city { get; set; }
        public int is_verified { get; set; }
    }
}