using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BHGroupEntity
{
   // [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        
    }
    public class UserMetadata
    {
        //[Required(ErrorMessage = "Please enter Username")]
        //[Remote("CheckUsername", "Users", AdditionalFields = "id", ErrorMessage = "The username is already being used.")]
        public string login { get; set; }

        //[Required(ErrorMessage = "Please enter Password")]
        //public string passwordHash { get; set; }

        //[Required(ErrorMessage = "Please enter First Name")]
        //public string firstName { get; set; }

        //[Required(ErrorMessage = "Please enter Last Name")]
        //public string lastName { get; set; }

        //[Required(ErrorMessage = "Please enter Email")]
        //[RegularExpression("([-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\\.[a-zA-Z]{2,4})", ErrorMessage = "Please enter valid Email Address.")]
        public string emailAddress { get; set; }
    }
}
