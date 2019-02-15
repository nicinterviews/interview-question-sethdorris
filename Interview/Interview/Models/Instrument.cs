using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class Instrument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Serial Number")]
        public int InstrumentID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Musical Key")]
        public string MusicalKey { get; set; }

        public List<MusiciansInstruments> Musicians { get; set; }
    }
}
