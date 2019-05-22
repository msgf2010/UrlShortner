using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortner.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Url> Urls { get; set; }
    }
}