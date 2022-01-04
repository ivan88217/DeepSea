using DeepSea.Shared;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeepSea.Models;
public class UserOwnUnits
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 當前等級
    /// </summary>
    public int CurrentLevel { get; set; }

    /// <summary>
    /// 減統御
    /// </summary>
    public bool HasDecrease { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Comment { get; set; }

    public string IdentityUserId { get; set; }
    public virtual IdentityUserModel IdentityUser {  get; set; }

    public int UnitId {  get; set; }
    public virtual Unit Unit {  get; set; }

    [NotMapped]
    public bool IsEditing { get; set; } = false;
    [NotMapped]
    public Confirm Confirm { get; set; } = new Confirm();
}
