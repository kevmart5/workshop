using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Workshop.Core
{
    public class Car
    {
        [Required]
        public int Id { set; get; }
        [Required(ErrorMessage = "The brand of the car is required"), StringLength(40)]
        public string Brand { set; get; }
        [Required(ErrorMessage = "The Plate of the car is required"), StringLength(40)]
        public string Plate { set; get; }
    }
}
