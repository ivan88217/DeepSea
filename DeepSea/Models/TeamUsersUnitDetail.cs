using System.ComponentModel.DataAnnotations.Schema;
namespace DeepSea.Models;
public class TeamUsersUnitDetail
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int TeamUsersId {  get; set; }
    public virtual TeamUsers TeamUsers {  get; set; }

    public int UnitId { get; set; }
    public virtual Unit Unit {  get; set; }
}
