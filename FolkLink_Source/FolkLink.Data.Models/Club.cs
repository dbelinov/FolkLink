using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FolkLink.Common.EntityConstants.ClubConstants;

namespace FolkLink.Data.Models;

public class Club
{
    public Club()
    {
        Members = new HashSet<Member>();
    }
    
    [Required]
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; }
    [Required]
    [MaxLength(AddressMaxLength)]
    public string Address { get; set; }
    [Required]
    [Range(MemberCapacityMinValue, MemberCapacityMaxValue)]
    public int MemberCapacity { get; set; }
    [Required] 
    public int OwnerId { get; set; }
    [Required]
    [ForeignKey(nameof(OwnerId))]
    public Owner Owner { get; set; }
    
    public ICollection<Member> Members { get; set; }
}