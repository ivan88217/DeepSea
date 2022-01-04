using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DeepSea.Models;

public class AttendanceRecordDetail
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int AttendenceRecordId { get; set; }
    public virtual AttendanceRecord AttendenceRecord {  get; set; }

    public int HouseMemberId { get; set; }
    public virtual HouseMember HouseMember { get; set; }
}
