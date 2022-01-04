using System.ComponentModel.DataAnnotations.Schema;
namespace DeepSea.Models;

public class HouseMemberDetail
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int AllianceId { get; set; }
    public virtual Alliance Alliance { get; set; }

    public int? HouseId {  get; set; }
    public virtual House House {  get; set; }

    public int HouseMemberId { get; set; }
    public virtual HouseMember HouseMember {  get; set; }
}
