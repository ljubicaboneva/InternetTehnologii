using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Aud_Albums.Models
{
    public class Store
    {
        public string Name { get; set; }
        public int  Id { get; set; }
        public string Address { get; set; }
        public virtual List<Album> albums { get; set; }
        public Store()
        {
            albums = new List<Album>();
        }
    }
}