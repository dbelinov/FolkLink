using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FolkLink.Common.Enums;

using static FolkLink.Common.EntityConstants.GroupConstants;

namespace FolkLink.Data.Models;

public class Group
{
    public Group()
    {
        Members = new HashSet<Member>();
    }
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; }
    
    [Required]
    public GroupType Type { get; set; }

    [Required]
    public int ClubId { get; set; }
    [ForeignKey(nameof(ClubId))]
    public virtual Club Club { get; set; }
    public ICollection<Member> Members { get; set; }
}