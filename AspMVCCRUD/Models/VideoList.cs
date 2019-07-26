using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMVCCRUD.Models
{
    public class VideoList
    {
        [Key]
        public int VideoId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Name Of Video")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [DisplayName("Video Field")]
        public string VideoField { get; set; }
    }
}
