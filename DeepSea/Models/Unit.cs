using DeepSea.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeepSea.Models;

public enum UnitType
{
    近戰步兵 = 0,
    遠程步兵 = 1,
    騎兵 = 2,
}

public class Unit
{
    /// <summary>
    /// 兵團ID
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 星級
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// 兵團名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 統御
    /// </summary>
    public int Dominate { get; set; }

    /// <summary>
    /// 兵團類型
    /// </summary>
    public UnitType Type { get; set; }

    /// <summary>
    /// 最高等級
    /// </summary>
    public int MaxLevel {  get; set; }

    
    public virtual ICollection<IdentityUserModel> Users { get; set; }

    [InverseProperty("Unit")]
    public virtual List<UserOwnUnits> UserOwns { get; set; }

    [InverseProperty("Unit")]
    public virtual List<TeamUsersUnitDetail> Actived { get; set; }

    [NotMapped]
    public bool IsEditing { get; set; } = false;
    [NotMapped]
    public Confirm Confirm { get; set; } = new Confirm();

}
