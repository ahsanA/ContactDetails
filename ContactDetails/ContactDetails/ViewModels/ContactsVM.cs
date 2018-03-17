using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactDetails.ViewModels
{
    public class ContactsVM
    {
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Person Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }
        public int ID { get; set; }
    }
}