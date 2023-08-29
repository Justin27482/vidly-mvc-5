using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MovieGenre> movieGenres { get; set; }
        
        public int? ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public int? MovieGenreId { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1,20)]
        public int? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return ID != 0 ? "Edit Movie" : "New Movie";

            }
        }

        public MovieFormViewModel()
        {
            ID = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            ID = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            MovieGenreId = movie.MovieGenreId;
        }
    }
}