using System;
using System.ComponentModel.DataAnnotations;

namespace MvcAlbum.Models
{
    public class Album
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Artist { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(20)]
        public string Rating { get; set; }

    }
}
