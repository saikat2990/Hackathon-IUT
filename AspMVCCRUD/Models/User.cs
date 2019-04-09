using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCCRUD.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }


        [Column(TypeName = "nvarchar(250)")]

        [Required]
        [DisplayName("Username")]
        public string username { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Email")]
        public string email { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Password")]
        public string password { get; set; }
       
    }
}
