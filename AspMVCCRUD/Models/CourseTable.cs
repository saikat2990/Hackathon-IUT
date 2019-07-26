using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCCRUD.Models
{
    public class CourseTable
    {

        [Key]
        public int courseId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Coursename")]
        public string coursename { get; set; }


        [Column(TypeName = "varchar(100)")]
        [Required]
        [DisplayName("CourseType")]
        public string coursetype { get; set; }
        //need to add both tables for getting teacher ID
    }
}
