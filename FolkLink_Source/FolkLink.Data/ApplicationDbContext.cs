using FolkLink.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FolkLink.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Club> Clubs { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Group> Groups { get; set; }
}