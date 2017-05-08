using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalShowcase.Models
{
    public class Movie
    {
        
        
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        
        public Genre genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte genreId { get; set; }
        
        public DateTime dateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime releaseDate { get; set; }
        
        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public byte numberInStock { get; set; }

        public byte NumberAvailable { get; set; }

       
    }

    // /movies/random
}