using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortner.Data
{
    public class Url
    {
        public int Id { get; set; }
        public string UrlOriginal { get; set; }
        public string UrlShortened { get; set; }
        public int Views { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}