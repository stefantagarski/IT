using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aud_kolokviumska.Models
{
    public class StoreAlbums
    {
        public int storeID { get; set; }

        public int albumID { get; set; }

        public Store Store { get; set; }

        public List<Album> Albums { get; set; }

        public StoreAlbums()
        {
            Albums = new List<Album>();
        }
    }
}