using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class StudentsList
    {
        [Key]
        public int StudentsListId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Name")]
        public string studentname { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("password")]
        public string password { get; set; }

        [Required]
        [DisplayName("Number Of Complete Courses")]
        public int completeCourse { get; set; }

        [DisplayName("Due Points")]
        public int DuePoints { get; set; }



    }
}
