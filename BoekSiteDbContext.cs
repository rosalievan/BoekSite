using System;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using BoekSite.Models.Database;

namespace BoekSite
{
    public class BoekSiteDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Excerpt> Excerpts { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            optionsBuilder.UseNpgsql(GetConnectionString());
        }

        private static string GetConnectionString()
        {
            var databaseUrl =
                Environment.GetEnvironmentVariable("DATABASE_URL");
            if (databaseUrl == null)
            {
                throw new Exception("Environment variable 'DATABASE_URL' must not be null");
            }

            bool useSsl = true;
            var useSslVariable = Environment.GetEnvironmentVariable("USE_SSL");
            if (useSslVariable != null)
            {
                if (!Boolean.TryParse(useSslVariable, out useSsl))
                {
                    throw new Exception("Environment variable 'USE_SSL' must be parse-able as bool");
                }
            }

            var databaseUri = new Uri(databaseUrl);
            var userInfo = databaseUri.UserInfo.Split(':');

            var builder =
                new NpgsqlConnectionStringBuilder {
                    Host = databaseUri.Host,
                    Port = databaseUri.Port,
                    Username = userInfo[0],
                    Password = userInfo[1],
                    Database = databaseUri.LocalPath.TrimStart('/')
                };
            if (useSsl)
            {
                builder.SslMode = SslMode.Require;
                builder.TrustServerCertificate = true;
            }

            return builder.ToString();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
