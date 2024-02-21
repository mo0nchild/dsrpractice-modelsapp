using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApp.Context.Entities.User
{
    [Table(nameof(User)), Index(nameof(Email), IsUnique = true)]
    public class User : Common.BaseEntity
    {
        [Required]
        public string Name { get; set; } = default!;

        [Required]
        public string Email { get; set; } = default!;
        public string Biography { get; set; } = default!;

        public byte[]? Image { get; set; } = default!;

    }
}
