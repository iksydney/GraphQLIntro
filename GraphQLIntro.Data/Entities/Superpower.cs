using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLIntro.Data.Entities
{
    public class Superpower
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please provide a super power for the heroe")]
        public string SuperPower { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(SuperHeroe))]
        public Guid SuperHeroeId { get; set; }
        public SuperHeroe SuperHeroe { get; set; }
    }
}
