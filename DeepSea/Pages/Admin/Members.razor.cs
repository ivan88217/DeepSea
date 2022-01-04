
using System.ComponentModel.DataAnnotations;
namespace DeepSea.Pages.Admin;
public partial class Members
{
    private class AddMemberModel
    {
        [Required(ErrorMessage = "請輸入名稱")]
        [Display(Name = "名稱")]
        public string GameName { get; set; }
    }
}
