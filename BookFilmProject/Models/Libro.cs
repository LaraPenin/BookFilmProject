using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//CREACIÓN DE LA CLASE LIBRO
//Algunos campos van definidos como clave primaria, Generados automaticamente y Requeridos
namespace BookFilmProject.Models
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Theme { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Publisher { get; set; }
                   
 
    }
}