using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ceo.Data;
using System.ComponentModel.DataAnnotations;

namespace Ceo.Web.ViewModels
{
    public class FormCustomerScheduleViewModel
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        
   }
}