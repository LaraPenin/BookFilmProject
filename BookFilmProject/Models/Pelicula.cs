using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookFilmProject.Models
{
    public class Pelicula
    {
        public int FilmID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Theme { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Music { get; set; }
        public bool PendienteVista { get; set; }
        public DateTime Date { get; set; }
        

        public int LibroID { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}





    
