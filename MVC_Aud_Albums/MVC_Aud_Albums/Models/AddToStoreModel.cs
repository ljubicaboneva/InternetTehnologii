﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Aud_Albums.Models
{
    public class AddToStoreModel
    {
        public int storeId { get; set; }
        public int albumId { get; set; }
        public List<Album> albums { get; set; }
        public AddToStoreModel()
        {
            albums = new List<Album>();
        }
    }
}