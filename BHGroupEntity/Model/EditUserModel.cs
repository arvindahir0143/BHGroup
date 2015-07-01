using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHGroupEntity.Model
{
    public class EditUserModel
    {
        public User User { get; set; }

        //[RegularExpression("^.{8,}$", ErrorMessage = "Password must be atleast 8 characters long.")]
        public string Password { get; set; }

       // [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
