using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookFilmProject.Models
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Theme { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Music { get; set; }
        public bool PendienteVista { get; set; }
        public DateTime Date { get; set; }
    }
}