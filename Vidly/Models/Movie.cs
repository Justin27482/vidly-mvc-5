
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public MovieGenre MovieGenre { get; set; }

        [Display(Name = "Genre")]
        public int MovieGenreId { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public DateTime DateAddedToDB { get; set; }
        
        [Required]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }   
       
    }
}