using NetSchool.Context.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsApp.Context.Entities
{
    public class Model : Common.BaseEntity
    {
        [Required]
        public string Name { get; set; } = default!;
        public string? Description { get; set; } = default;

        [Required]
        public int Views { get; set; } = default;

        [Required]
        public int Downloads { get; set; } = default;

        [Required]
        public Guid FileId { get; set; } = Guid.NewGuid();
        public byte[]? Image { get; set; } = default!;

        [Required, ForeignKey(nameof(Category))]
        public int CategoryId { get; set; } = default;
        public Category Category { get; set; } = default!;

        [Required, ForeignKey(nameof(Info))]
        public int InfoId { get; set; } = default;
        public ModelInfo Info { get; set; } = default!;

        [Required, ForeignKey(nameof(Publisher))]
        public int PublisherId { get; set; } = default!;
        public User Publisher { get; set; } = default!;
    }
}
