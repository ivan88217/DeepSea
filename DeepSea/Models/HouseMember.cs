using DeepSea.Shared;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace DeepSea.Models;
public class HouseMember
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string GameName { get; set; }

    public DateTime CreateTime { get; set; }

    [InverseProperty("HouseMember")]
    public virtual HouseMemberDetail Detail {  get; set; }

    [InverseProperty("HouseMember")]
    public virtual IdentityUserModel IdentityUser { get; set; }

    [InverseProperty("HouseMember")]
    public virtual List<AttendanceRecordDetail> AttendenceRecordDetails { get; set; }

    [InverseProperty("HouseMember")]
    public virtual AttendanceTempRecord AttendenceTempRecord { get; set; }


    [NotMapped]
    public bool IsEditing { get; set; } = false;
    [NotMapped]
    public Confirm Confirm { get; set; } = new Confirm();
}
