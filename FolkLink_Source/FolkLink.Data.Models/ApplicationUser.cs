using Microsoft.AspNetCore.Identity;

namespace FolkLink.Data.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public virtual Owner Owner { get; set; }
    public virtual Member Member { get; set; }
}