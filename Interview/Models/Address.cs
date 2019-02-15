using System.Collections.Generic;

namespace Interview.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }

        public List<Musician> Musicians { get; set; }
    }
}