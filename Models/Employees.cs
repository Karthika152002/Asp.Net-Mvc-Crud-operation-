using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCCRDU.Models
{
    [Table("Employee")]
    public class Employees
    {
       [Key]
        public int Id { get; set; }
        [Display(Name ="Employee Name")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        //[Range(25,60, ErrorMessage ="Age Between 25 and 60"  )]
        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address {  get; set; }

        [Required(ErrorMessage = "Please Select the gender")]
        public string Gender { get; set; }
    }
}