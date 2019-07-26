using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class runningCourse
    {
        [Key]
        public int runningCourseId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Trainer Name")]
        [Required]
        public string TrainerName { get; set; }

        [DisplayName("Price")]
        public int price { get; set; }

        [DisplayName("Number Of Students")]
        public string numberOfStudents { get; set; }

        [DisplayName("Number Of Classes")]
        public string numberOfClasses { get; set; }

    }
}
