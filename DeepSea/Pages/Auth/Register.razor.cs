namespace DeepSea.Pages.Auth;
using DeepSea.Models;
using System.ComponentModel.DataAnnotations;
public class RegisterModel
{
    [Required(ErrorMessage = "請選擇體系")]
    [Display(Name = "體系")]
    public int AllienceId { get; set; } = 1;

    [Required(ErrorMessage = "請選擇家族")]
    [Display(Name = "家族")]
    public int HouseId { get; set; } = 1;

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

    [Required(ErrorMessage = "Discord名稱為必填欄位")]
    [Display(Name = "Discord名稱")]
    [RegularExpression(@"[^#]*", ErrorMessage = "Discord名稱請勿添加#與後面的數字")]
    public string DiscordName { get; set; } = "";


    [Required(ErrorMessage = "遊戲名稱為必填欄位")]
    [Display(Name = "遊戲名稱")]
    public string GameName { get; set; } = "";

    [Compare("Password", ErrorMessage = "請確認密碼與密碼確認是一致的")]
    [Display(Name = "密碼確認")]
    public string ConfirmPassword { get; set; } = "";
}
