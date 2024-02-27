using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResquestResponsModel.Login
{
    public class LoginRequest
    {
        [Required]
        [StringLength(20,MinimumLength =2)]
        public string Email { get; set; } = "";
       
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Password { get; set; } = "";
    }
}
