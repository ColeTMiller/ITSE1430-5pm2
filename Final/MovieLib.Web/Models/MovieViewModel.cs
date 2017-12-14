/*
 * ITSE 1430
 * Sample implementation
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MovieLib.Web.Models
{
    /// <summary>Provides a view model for movies.</summary>
    public class MovieViewModel : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)] // add a max string range to the title 
        public string Title { get; set; }

        public string Description { get; set; }
        
        [Display(Name = "Is Owned")]
        public bool IsOwned { get; set; }

        [Range(2, Int32.MaxValue)]
        public int Length { get; set; }

        public Rating Rating { get; set; }

        [Range(1900, 2100)] // add a date range for the dates 
        public int ReleaseYear { get; set; }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext ) => Enumerable.Empty<ValidationResult>();        
    }
}