using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shortid;

namespace UrlShortner.Data
{
    public class UrlRepository
    {
        private string _connectionString;

        public UrlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Url> GetUrls(int userId)
        {
            using (var context = new UrlContext(_connectionString))
            {
                return context.Urls.Where(u => u.UserId == userId).ToList();
            }
        }

        public Url GetOriginalUrl(string url)
        {
            using (var context = new UrlContext(_connectionString))
            {
                return context.Urls.FirstOrDefault(u => u.UrlShortened == url);
            }
        }

        public bool DoesOriginalUrlExist(string url)
        {
            using (var context = new UrlContext(_connectionString))
            {
                return context.Urls.Any(u => u.UrlOriginal == url);
            }
        }

        public bool DoesShortenedUrlExist(string url)
        {
            using (var context = new UrlContext(_connectionString))
            {
                return context.Urls.Any(u => u.UrlShortened == url);
            }
        }

        public void AddUrl(Url url)
        {
            using (var context = new UrlContext(_connectionString))
            {
                context.Urls.Add(url);
                context.SaveChanges();
            }
        }

        public void UpdateUrl(int id)
        {
            using (var context = new UrlContext(_connectionString))
            {
                context.Database.ExecuteSqlCommand(
                    "UPDATE Urls SET Views = Views + 1 WHERE Id = @id",
                    new SqlParameter("@id", id)
                    );
            }
        }
    }
}