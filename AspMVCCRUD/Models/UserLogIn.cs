using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AspMVCCRUD.Models
{
    public class UserLogIn
    {
        [Key]
        public int userId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Name")]
        public string name { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Password")]
        public string password { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Phone Number")]
        public string phnNumber { get; set; }

    }
}
