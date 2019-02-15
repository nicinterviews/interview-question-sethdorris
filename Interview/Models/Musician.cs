using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class Musician : Person
    {
        public int ID { get; set; }
        public int AddressID { get; set; }
        public int PhoneID { get; set; }


        public Address Address { get; set; }
        public Phone Phone { get; set; }
        public List<MusiciansInstruments> Instruments { get; set; }
        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }

    }
}
