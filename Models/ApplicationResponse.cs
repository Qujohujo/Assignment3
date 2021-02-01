using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class ApplicationResponse
    {
        [Required]
        public string category { get; set; }

        [Required]
        //[RegularExpression("Independence Day", ErrorMessage = "That movie cannot be entered.")]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public string edited { get; set; }

        public string lent { get; set; }

        [StringLength(25)]
        public string notes { get; set; }
    }
}
