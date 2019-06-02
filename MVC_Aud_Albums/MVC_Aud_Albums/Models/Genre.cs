using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Aud_Albums.Models
{
    public class Genre
    {
        [Display(Name="Id")]
        public int GenreId { get; set; }
        [Display(Name="Genre Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> albums { get; set; }
    }
}