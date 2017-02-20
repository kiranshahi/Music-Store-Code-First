using System;
using System.Collections.Generic;

namespace MusicStoreCodeFirst.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Album> Albums { get; set; }

    }
}