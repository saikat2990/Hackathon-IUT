using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class TeachersOwnList
    {

        [Key]
        public int TeachersOwnListId { get; set; }

        [Required]
        [DisplayName("Course ID")]
        public int courseId { get; set; }

        [Required]
        [DisplayName("Number Of Complete Courses")]
        public int completeCourse { get; set; }


        [Required]
        [DisplayName("Point Per Courses")]
        public int PointPerCourses { get; set; }

        [Required]
        [DisplayName("Number of Class Per Courses")]
        public int NumberofClassPerCourses { get; set; }

        [Required]
        [DisplayName("Number of Done Classes Per Course")]
        public int NumberofDoneClassPerCourses { get; set; }

        [Required]
        [DisplayName("Pick Up Ammount")]
        public int PickUpAmmount { get; set; }

    }
}
