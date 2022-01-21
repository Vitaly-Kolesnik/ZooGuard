using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class SingInViewModel
    {
        public class SignInViewModel
        {
            [Required]
            public string Login { get; set; }

            [Required, DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}