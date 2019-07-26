using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCCRUD.Models
{
    public class StudentPage
    {


        [Key]
        public int Roll { get; set; }

        public string student_name { get; set; }
    }
}
