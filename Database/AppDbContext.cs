using hexahack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : IdentityDbContext<Teacher>
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}