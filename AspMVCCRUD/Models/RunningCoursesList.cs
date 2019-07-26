using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class RunningCoursesList
    {
        [Key]
        public int RunningCoursesListId { get; set; }

        [ForeignKey("trainerId")]
        public int trainerId { get; set; }

        [ForeignKey("courseId")]
        [Required]
        [DisplayName("Course Id")]
        public int CourseId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Trainer Name")]
        [Required]
        public string TrainerName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Student List")]
        [Required]
        public List<StudentsList> CurrentStudentsList { get; set; }
    }
}
