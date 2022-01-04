
using DeepSea.Models;
using DeepSea.Shared;
using System.ComponentModel.DataAnnotations;
namespace DeepSea.Pages.Data;
public partial class Units
{
    private class AddUnitModel
    {
        [Required(ErrorMessage = "請輸入名稱")]
        [Display(Name = "兵團名稱")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入星級")]
        [Range(1, 5, ErrorMessage = "請輸入有效星級")]
        [Display(Name = "星級")]
        public int Rank { get; set; }

        [Required(ErrorMessage = "請輸入最高等級")]
        [Range(1, 30, ErrorMessage = "請輸入有效等級")]
        [Display(Name = "最高等級")]
        public int MaxLevel { get; set; }

        [Required(ErrorMessage = "請輸入統御")]
        [Range(1, 350, ErrorMessage = "請輸入有效統御")]
        [Display(Name = "統御")]
        public int Dominate { get; set; }

        [Required(ErrorMessage = "請選擇類別")]
        [Display(Name = "類別")]
        public UnitType UnitType { get; set; }
    }

}
