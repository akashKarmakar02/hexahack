using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using hexahack.Models;

namespace hexahack.Models
{
    public class Hod
    {
        public string name { get; set; }
        [ForeignKey("Department")]
        public int d_code { get; set; } //foriegn key
        public string d_name { get; set; }
        [ForeignKey("College")]
        public int college_code { get; set; } //foriegn key
        public College College { get; set; }
        public Department Department { get; set; }
    }
}