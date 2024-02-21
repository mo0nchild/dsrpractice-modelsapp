using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApp.Context.Entities.Common
{
    /// <summary>
    /// Базовая сущность БД
    /// </summary>
    [Index(nameof(Uid), IsUnique = true)]
    public abstract class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; } = default!;

        [Required]
        public virtual Guid Uid { get; set; } = Guid.NewGuid();

        [Required]
        public virtual DateTime DateTime { get; set; } = DateTime.UtcNow;
    }
}
