
using System.ComponentModel.DataAnnotations;
namespace DeepSea.Pages.Auth;
public class LoginModel
{
    [Required(ErrorMessage = "Email為必填欄位")]
    [EmailAddress(ErrorMessage = "請輸入有效的Email")]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "密碼為必填欄位")]
    [MinLength(6, ErrorMessage = "密碼太短")]
    [DataType(DataType.Password)]
    [Display(Name = "密碼")]
    public string Password { get; set; } = "";
}
