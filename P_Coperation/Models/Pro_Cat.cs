using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace P_Coperation.Models
{
    public class Pro_Cat
    {
        [Key]
        public int Catid { get; set; }
        [Required(ErrorMessage = "cannot empty Catname")]
        [Display(Name = "Catname")]
        public string Catname { get; set; }
        [Required(ErrorMessage = "cannot empty Proid")]
        [Display(Name = "Proid")]
        public string Proid { get; set; }
        [Required(ErrorMessage = "cannot empty Proname")]
        [Display(Name = "Proname")]
        public string Proname { get; set; }
    }
}