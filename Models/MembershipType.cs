using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalShowcase.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        [Required]
        public String name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }


        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}