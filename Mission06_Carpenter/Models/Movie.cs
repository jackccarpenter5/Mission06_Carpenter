using System.ComponentModel.DataAnnotations;

namespace Mission06_Carpenter.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }//
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Title { get; set; }//
        public int Year { get; set; }//
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public int Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
        public int CopiedToPlex { get; set; } //network, vector, complexity, 
    }
}
