using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        [Required]
        public double Value1 { get; set; }
        [Required]
        public double Value2 { get; set; }
        [Required]
        public string Operation { get; set; }
        public double Result { get; set; }
        public String Error { get; set; }
    }
}


