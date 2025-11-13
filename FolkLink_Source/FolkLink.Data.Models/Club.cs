using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FolkLink.Common.EntityConstants.ClubConstants;

namespace FolkLink.Data.Models;

public class Club
{
    public Club()
    {
        Groups = new HashSet<Group>();
    }
    [Key]
    public int Id { get; set; }
    
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
    public Guid OwnerId { get; set; }
    
    [Required]
    [ForeignKey(nameof(OwnerId))]
    public virtual Owner Owner { get; set; }
    
    public ICollection<Group> Groups { get; set; }
}