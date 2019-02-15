using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class MusiciansInstruments
    {
        public int InstrumentID { get; set; }
        public int MusicianID { get; set; }

        public Instrument Instrument { get; set; }
        public Musician Musician { get; set; }

    }
}
