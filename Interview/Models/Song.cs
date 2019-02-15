using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class Song
    {
        public int ID { get; set; }
        public int AlbumID { get; set; }
        public string Title { get; set; }

        List<Musician> Author { get; set; }
        public Album Album { get; set; }
    }
}
