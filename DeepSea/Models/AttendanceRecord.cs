using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DeepSea.Models;

public class AttendanceRecord
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string RecordTime {  get; set; }

    public int AllianceId { get; set; }
    public virtual Alliance Alliance { get; set; }

    [InverseProperty("AttendenceRecord")]
    public virtual List<AttendanceRecordDetail> Details {  get; set; }

}
