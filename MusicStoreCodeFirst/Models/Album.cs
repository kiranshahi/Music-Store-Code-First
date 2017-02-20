using System.ComponentModel.DataAnnotations;

namespace MusicStoreCodeFirst.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        public string AlbumName { get; set; }
        [Display(Name = "Gener")]
        public string Image { get; set; }
        [Required]
        [Range(200, 500)]
        public string Price { get; set; }
        public string Description { get; set; }
        public bool IsFeatured { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public bool IsTrending { get; set; }
    }
}