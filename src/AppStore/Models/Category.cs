using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppStore.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id {get;set;}
        public string? CategoryName {get;set;}
    }
}