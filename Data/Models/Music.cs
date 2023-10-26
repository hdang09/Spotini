using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Music
    {
        public int MusicId { get; set; }
        public string Name { get; set; }
        public string ArtistId { get; set; }
        public string Path { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Image { get; set; }
    }
}
