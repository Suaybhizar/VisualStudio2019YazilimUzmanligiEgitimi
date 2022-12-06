using System.ComponentModel.DataAnnotations;

namespace FreshShop.Model.ViewModels
{
    public class ManagerLogInVm
    {
        [Required(ErrorMessage ="Kullanıcı Adı Zorunludur.")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Şifre Zorunludur.")]
        [MinLength(3,ErrorMessage ="Şifre En Az 3 Karekter olmalıdır.")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}