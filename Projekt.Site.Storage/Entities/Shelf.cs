using Projekt.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Site.Storage.Entities
{
    [Table("Shelf")]
    public class Shelf : BaseEntity
    {
        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public string ShelfName { get; set; }

        [Required]
        public Guid ShelfId { get; set; }
        public string Description { get; protected set; }

        public virtual ICollection<Book> Books { get; set; }


    }
}
