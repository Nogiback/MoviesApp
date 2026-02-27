using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
// Name: Peter Do
// Student ID: 9086580
    public class Movie
    {
        //Add Model validation attributes

        public int Id { get; set; }
        
        [Required(ErrorMessage = "Title is required.")]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "Title must start with a capital letter.")]
        public string Title { get; set; }  //property can't be null, and start with capital letter
        
        [Required(ErrorMessage = "Release Year is required.")]
        [Range(1900, 2025, ErrorMessage = "Release Year must be between 1900 and 2025.")]
        public string ReleaseYear { get; set; } // Show as Release Year in the view, and must be between 1900 and 2025
        
        [Required(ErrorMessage = "Genre is required.")]
        [RegularExpression(@"^(Action|Comedy|Drama|Horror|SciFi)$", ErrorMessage = "Genre must be one of the following values: Action, Comedy, Drama, Horror, SciFi.")]
        public string Genre { get; set; } // Must be one of the following values: Action, Comedy, Drama, Horror, SciFi

        [Display(Name = "Image URL")]
        public string ImgUrl { get; set; } // Show as Image URL in the view
    }
}
