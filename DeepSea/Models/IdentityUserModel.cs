using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace DeepSea.Models;
public class IdentityUserModel : IdentityUser
{
    [PersonalData]
    public string DiscordName { get; set; }

    [PersonalData]
    public int Domination { get; set; }

    [PersonalData]
    public int Level { get; set; }

    [PersonalData]
    public DateTime JoinTime { get; set; }

    public int HouseMemberId { get; set; }
    [ForeignKey("HouseMemberId")]
    public virtual HouseMember HouseMember { get; set; }

    public virtual ICollection<Unit> Units { get; set; }

    [InverseProperty("IdentityUser")]
    public virtual List<UserOwnUnits> OwnUnits { get; set; }

    [InverseProperty("IdentityUser")]
    public virtual TeamUsers AtTeam { get; set; }

}
