using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace DeepSea.Models;
public class TeamUsers
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string IdentityUserId {  get; set; }
    public virtual IdentityUserModel IdentityUser {  get; set; }

    public int TeamId { get; set; }
    public virtual Team Team {  get; set; }

    [InverseProperty("TeamUsers")]
    public virtual List<TeamUsersUnitDetail> Detail { get; set; }
}
