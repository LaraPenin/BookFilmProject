using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookFilmProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;

namespace BookFilmProject.DAL
{
    public class BookfilmContext : DbContext
    {
        public BookfilmContext() : base(cadena)
        {
        }

        private static string cadena = ConfigurationManager.ConnectionStrings["cadenabfp"].ConnectionString;

            public DbSet<Libro> Libros { get; set; }
            public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
    }
}
