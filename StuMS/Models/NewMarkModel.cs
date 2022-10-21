using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StuMS.Models
{
    public class NewMarkModel
    {
        public int Id { get; set; }

        
        [Display(Name = "StudentId")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Enter Maths Marks")]
        [Display(Name = "Maths")]
        public int Maths { get; set; }

        [Required(ErrorMessage = "Enter Science Marks")]
        [Display(Name = "Science")]
        public int Science { get; set; }


        [Required(ErrorMessage = "Enter English Marks")]
        [Display(Name = "English")]
        public int English { get; set; }

        [Display(Name = "Total Marks")]
        public int TotalMarks { get; set; }

        public NewStuModel Student { get; set; }



    }
}
