using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
