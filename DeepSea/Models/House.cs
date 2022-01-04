using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace DeepSea.Models;

public class House
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {  get; set; }

    public string Name {  get; set; }

    public int AllianceId {  get; set; }

    public virtual Alliance Alliance {  get; set; }

    [InverseProperty("House")]
    public virtual List<HouseMemberDetail> OwnMembers { get; set; }



}
