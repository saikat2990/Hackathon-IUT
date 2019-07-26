using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AspMVCCRUD.Models
{
    public class UserDoneCoursesInfo
    {
        [Key]
        public int UserDoneCoursesInfoId { get; set; }

        [ForeignKey("coursrId")]
        public int courseId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Trainer Name")]
        [Required]
        public string TrainerName { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Done Courses")]
        public string DoneCourses { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Grade")]
        public string Grade { get; set; }


    }
}
