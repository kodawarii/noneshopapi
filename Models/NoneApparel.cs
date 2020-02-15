using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ecommercebackend.Models
{
    public class NoneApparel
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string img { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        public int price { get; set; }

        // ... To Add Other info on products e.g. description
        // ...
    }
}
