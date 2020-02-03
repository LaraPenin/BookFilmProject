using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookFilmProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;


//CONTEXTO DE LA BASE DE DATOS CON LA CADENA DE CONEXION Y LOS CONJUNTOS DE ENTIDADES

namespace BookFilmProject.DAL
{
    public class BookfilmContext : DbContext
    {

        //Cadena conexión
        public BookfilmContext() : base(cadena)
        {
        }

        private static string cadena = ConfigurationManager.ConnectionStrings["cadenabfp"].ConnectionString;

        //Conjuntos de entidades
            public DbSet<Libro> Libros { get; set; }
            public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
    }
}
