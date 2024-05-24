using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppStore.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int Id {get;set;}

        [Required]
        public string? Title {get;set;}
        public string? CreateDate {get;set;}

        [Required]
        public string? Autor {get;set;}
        public string? Image {get;set;}

    }
}