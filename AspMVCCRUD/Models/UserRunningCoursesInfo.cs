using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class UserRunningCoursesInfo
    {

        [Key]
        public int UserRunningCoursesInfoId { get; set; }

        [ForeignKey("courseId")]
        public int courseId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Trainer Name")]
        [Required]
        public string TrainerName { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Course Name")]
        public string CourseName { get; set; }

        [DisplayName("Complete Course Number")]
        public int CompleteClasses { get; set; }

        [DisplayName("Remaining Class Points")]
        public int remainingPoints { get; set; }

    }
}
