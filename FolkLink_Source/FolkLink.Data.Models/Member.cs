using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static FolkLink.Common.EntityConstants.UserConstants;

namespace FolkLink.Data.Models;

public class Member
{
    public Member()
    {
        Id = Guid.NewGuid();
    }
    
    [Key]
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
    [MaxLength(PhoneNumberMaxLength)]
    [Phone]
    public string PhoneNumber { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public int GroupId { get; set; }
    
    [ForeignKey(nameof(GroupId))]
    public Group Group { get; set; }
}