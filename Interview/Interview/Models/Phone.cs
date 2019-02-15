using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class Phone
    {
        public int ID { get; set; }
        [Display(Name = "Phone Number"), DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public long PhoneNumber { get; set; }

        public Musician Musician { get; set; }

    }
}
