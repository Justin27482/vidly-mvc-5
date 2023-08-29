
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.ModelBinding;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        
        public MovieGenre MovieGenre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int MovieGenreId { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public DateTime DateAddedToDb { get; set; }
        
        [Required]
        [Range(1,20)]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }   
       
    }
}