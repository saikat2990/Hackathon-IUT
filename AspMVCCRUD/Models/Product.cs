using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCCRUD.Models

{   [Table("Product")]
    public class Product
    {
        [Key]
        public int productId { get; set; }


        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Productname")]
        public string productname { get; set; }


        [Column(TypeName = "varchar(500)")]
        [Required]
        [DisplayName("ProductDetails")]
        public string productDetails { get; set; }
    }
}
