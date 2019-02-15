using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Models
{
    public class Album
    {
        public enum MediaFormat
        {
            CD,
            MP3,
            Vinyl
        }

        //I'm operating under the assumption the Album Identifier is this unique serial number; not sure if hte album identifier in the requirements doc is different.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Serial Number")]
        public int AlbumID { get; set; }
        public int MusicianID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Copyright Date")]
        public DateTime CopyrightDate { get; set; }
        public MediaFormat Format { get; set; }

        public List<Song> Songs { get; set; }
        public Musician Producer { get; set; }
    }
}
