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
    [Table("Books")]
    public class Book : BaseEntity
    {
        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public string Author { get; set; }
        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public string ISBN { get; set; }
        
        [MinLength(2)]
        [MaxLength(100)]
        public string Description { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        public string Publisher { get; set; }

        [MinLength(2)]
        [MaxLength(100)]

        public string Language { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public string ImageUrl { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public string ImageThumbnailUrl { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        public int Pages { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Required]
        public int Year { get; set; }


        public int ShelfId { get; set; }
        
        public Shelf Shelf { get; set; }
    }
    
}
