using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcAlbum.Models
{
    public class AlbumGenreViewModel
    {
        public List<Album> albums;
        public SelectList genres;
        public string albumGenre { get; set; }
    }
}
