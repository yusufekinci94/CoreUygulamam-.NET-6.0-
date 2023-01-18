using System.ComponentModel.DataAnnotations;

namespace CoreUygulamam.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen Rol Adı Giriniz")]
        public string name { get; set; }
    }
}
