using System.ComponentModel.DataAnnotations;

namespace hexahack.Models{
    public class Department {
        public string name { get; set; }
        [Key]
        public int d_code { get; set; } //primary key
    }
}