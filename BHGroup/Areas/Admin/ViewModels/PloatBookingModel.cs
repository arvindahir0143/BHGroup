using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BHGroup.Areas.Admin.ViewModels
{
    public class PloatBookingModel
    {
        public int PloatBookingId { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Member")]
        public int MemberId { get; set; }
        public string PloatType { get; set; }

        [Required(ErrorMessage = "Enter Quantity")]
        [Display(Name = "Quantity")]
        public int PloatQty { get; set; }

        public DateTime CreatOn { get; set; }

        public int MemberTokenId { get; set; }


        public string Token { get; set; }
        public DateTime Createon { get; set; }

    }
}