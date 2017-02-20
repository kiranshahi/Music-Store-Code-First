using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStoreCodeFirst.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}