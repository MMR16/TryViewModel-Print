using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class UserViewModel
    {
        [Range(15,60)]
        public int Age { get; set; }
        [Required(ErrorMessage ="Please enter Your Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(1,100)]
        public int Degree { get; set; }
    }
}