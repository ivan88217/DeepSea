using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DeepSea.Models;
public class Team
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int AllianceId { get; set; }
    public virtual Alliance Alliance { get; set; }

    [InverseProperty("Team")]
    public virtual List<TeamUsers> TeamUsers {  get; set; }
}
