using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class User:UserViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Your Salary")]
        public int Salary { get; set; }
        [Display(Name ="Last Name")]
        [StringLength(50,MinimumLength = 3)]
        public string  LName { get; set; }

        public decimal Numbers { get; set; }
    }
}