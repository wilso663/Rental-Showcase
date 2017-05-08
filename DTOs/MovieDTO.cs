using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RentalShowcase.Models;

namespace RentalShowcase.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }
     
        [Required]
        public byte genreId { get; set; }

        public GenreDTO genre { get; set; }

        public DateTime dateAdded { get; set; }

       
        public DateTime releaseDate { get; set; }

        [Range(1, 20)]
        public byte numberInStock { get; set; }
    }
}