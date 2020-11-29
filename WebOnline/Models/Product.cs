using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebOnline.Models
{
    public partial class Product
    {
        
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Không để trống")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Không để trống")]
        public decimal UnitPrice { get; set; }
        public byte[] Image { get; set; }
        public string UrlImage { get; set; }
        [Required(ErrorMessage = "Không để trống")]
        public Nullable<System.DateTime> ProductDate { get; set; }
        [Required(ErrorMessage = "Không để trống")]
        public string Available { get; set; }
        [Required(ErrorMessage = "Không để trống")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Không để trống")]
        public string Description { get; set; }
    }
}
