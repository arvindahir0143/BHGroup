using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHGroupEntity.Metadata
{
     [MetadataType(typeof(PloatBookingMetadata))]
    public partial class PloatBooking
    {
    }
   public class PloatBookingMetadata
    {
        public int PloatBookingId { get; set; }

        [Required(ErrorMessage = "Please select Member Name")]
        [Display(Name = "Member")]
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Please select Ploat Types")]
        [Display(Name = "Ploat Types")]
        public string PloatType { get; set; }

        [Required(ErrorMessage = "Please enter Quantity")]
        [Display(Name = "Quantity")]
        public int PloatQty { get; set; }

        public DateTime CreatOn { get; set; }

    }
}
