//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetailHours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblRtlHour
    {
        public int HoursID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Weekday Hours")]
        [StringLength(50)]
        public string WeekdayHours { get; set; }

        [Required]
        [Display(Name = "Weekend Hours")]
        [StringLength(50)]
        public string WeekendHours { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:G}", ApplyFormatInEditMode = true)]
        [Display(Name = "From Date")]
        public Nullable<System.DateTime> FromDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:G}", ApplyFormatInEditMode = true)]
        [Display(Name = "To Date")]
        public Nullable<System.DateTime> ToDate { get; set; }
    }
}
