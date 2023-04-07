using System.ComponentModel.DataAnnotations;

namespace GraphQLIntro.Data.Entities
{
    public class SuperHeroe
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please provide a name for the suoer heroe")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        [UseSorting]
        [UseFiltering]
        public ICollection<Superpower>? Superpowers { get; set; }
        [UseFiltering]
        [UseSorting]
        public ICollection<Movie>? Movies { get; set; }
    }
}
