using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RentalShowcase.Models;

namespace RentalShowcase.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? genreId { get; set; }

        

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? releaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? numberInStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
        
        public String Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            name = movie.name;
            releaseDate = movie.releaseDate;
            numberInStock = movie.numberInStock;
            genreId = movie.genreId;
        }
    }
}