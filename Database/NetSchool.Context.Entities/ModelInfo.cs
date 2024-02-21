using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSchool.Context.Entities
{
    public class ModelInfo : object
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = default;

        [Required]
        public int Vertexs { get; set; } = default!;

        [Required]
        public int Triangles { get; set; } = default!;
    }
}
