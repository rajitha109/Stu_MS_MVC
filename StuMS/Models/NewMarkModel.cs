using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StuMS.Models
{
    public class NewMarkModel
    {
        public int Id { get; set; }

        
        [Display(Name = "StudentId")]
        public int StudentId { get; set; }

     
        [Display(Name = "Total Marks")]
        
        public int TotalMarks { get; set; }


    }
}
