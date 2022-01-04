using System.ComponentModel.DataAnnotations.Schema;

namespace DeepSea.Models;

public class AttendanceTempRecord
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int AllianceId { get; set; }
    public virtual Alliance Alliance { get; set; }

    public int HouseMemberId { get; set; }
    public virtual HouseMember HouseMember { get; set; }

}
