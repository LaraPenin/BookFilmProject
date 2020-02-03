using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//CREACIÓN DE LA CLASE PELÍCULA
//Algunos campos van definidos como clave primaria, Requeridos y las propiedades de navegación de la otra clase Libro, donde se relaciona
namespace BookFilmProject.Models
{
    public class Pelicula
    {
        [Key]       
        public int FilmID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }       
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Theme { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Music { get; set; }     
  
        public int? LibroID { get; set; }
    

        public virtual Libro Libro { get; set; }
    }
}





    
