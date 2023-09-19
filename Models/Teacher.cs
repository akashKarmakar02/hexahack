using Microsoft.AspNetCore.Identity;

public class Teacher: IdentityUser {
    public string teacher_name { get; set; } 
    public string email { get; set; }
    public int college_code { get; set; } // foriegn key
    public string subject { get; set; }
    public int hashed_password { get; set; }
    public int d_code { get; set; } // foriegn key
}

