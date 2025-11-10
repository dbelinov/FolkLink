using System.ComponentModel.DataAnnotations;

using static FolkLink.Common.EntityConstants.OwnerConstants;

namespace FolkLink.Data.Models;

public class Owner
{
    public Owner()
    {
        Clubs = new HashSet<Club>();
    }
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(FirstNameMaxLength)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(MiddleNameMaxLength)]
    public string MiddleName { get; set; }
    
    [Required]
    [MaxLength(LastNameMaxLength)]
    public string LastName { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
    
    [Required]
    [EmailAddress]
    [MaxLength(EmailMaxLength)]
    public string Email { get; set; }
    
    [Required]
    [MaxLength(PhoneNumberMaxLength)]
    [Phone]
    public string PhoneNumber { get; set; }
    public ICollection<Club> Clubs { get; set; }
}