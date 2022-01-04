using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DeepSea.Models;
public class Alliance
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {  get; set; }
    public string Name {  get; set; }

    [InverseProperty("Alliance")]
    public virtual List<HouseMemberDetail> Members { get; set; }

    [InverseProperty("Alliance")]
    public virtual List<House> House { get; set; }

    [InverseProperty("Alliance")]
    public virtual List<Team> Teams { get; set; }

    [InverseProperty("Alliance")]
    public virtual List<AttendanceRecord> AttendenceRecords { get; set; }

    [InverseProperty("Alliance")]
    public virtual List<AttendanceTempRecord> AttendenceTempRecords { get; set; }
}
