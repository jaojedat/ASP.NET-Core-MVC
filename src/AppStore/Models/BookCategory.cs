using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppStore.Models
{
    public class BookCategory
    {
        [Key]
        [Required]
        public int Id {get;set;}
        public int CategoryId {get;set;}
        public int BookId {get;set;}
    }
}