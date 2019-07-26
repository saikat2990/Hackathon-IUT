using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class TrainerReg
    {
        [Key]
        public int trainerId { get; set; }

        [DisplayName("CourseId")]
        [ForeignKey("courseId")]
        public int c_Id { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("CourseName")]
        public string courseName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Password")]
        public string password { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Card Num")]
        public string CardNum { get; set; }

    }
}
