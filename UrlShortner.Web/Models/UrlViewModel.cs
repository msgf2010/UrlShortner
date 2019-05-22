using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortner.Data;

namespace UrlShortner.Web.Models
{
    public class UrlViewModel
    {
        public IEnumerable<Url> Urls { get; set; }
        public string UserName { get; set; }
    }
}
