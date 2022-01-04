
using System.ComponentModel.DataAnnotations;
namespace DeepSea.Pages;
public partial class PersonalInfo
{
    private class PersonalData
    {
        [Required(ErrorMessage = "請輸入遊戲名稱")]
        public string GameName { get; set; }

        [Required(ErrorMessage = "請輸入DC名稱")]
        public string DiscordName { get; set; }

        [Required(ErrorMessage = "請輸入等級")]
        public int Level { get; set; }

        [Required(ErrorMessage = "請輸入統御")]
        public int Domination { get; set; }

        public bool IsEditing { get; set; }
    }

    private class AddUnitModel
    {
        [Required(ErrorMessage = "請選擇兵團")]
        public int UnitId { get; set; }

        [Required(ErrorMessage = "請輸入當前等級")]
        public int CurrentLevel { get; set; }

        public string Comment { get; set; }

        [Required]
        public bool HasDecrease { get; set; }
    }
}
