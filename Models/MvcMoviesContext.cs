using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListings.Models
{
    public class MvcMoviesContext : DbContext
    {
        public MvcMoviesContext(DbContextOptions<MvcMoviesContext> options) :base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
