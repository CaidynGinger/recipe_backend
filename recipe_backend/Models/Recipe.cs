using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace recipe_backend.Models
{
    [Table("Recipes")]

    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public int Serves { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string Ingredients { get; set; } = string.Empty;
    }
}
