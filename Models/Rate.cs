//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobile_Repair_History_System_MRHS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Rate
    {
        public int RateID { get; set; }
        public string SenderEmail { get; set; }
        public string RecieverEmail { get; set; }
        [Display(Name = "Rate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Rate is required")]
        public double Value { get; set; }
        public System.DateTime DateTime { get; set; }
    
        public virtual Store Store { get; set; }
        public virtual User User { get; set; }
    }
}
