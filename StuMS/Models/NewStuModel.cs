using System.ComponentModel.DataAnnotations;


namespace StuMS.Models
{
    public class NewStuModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Student Name")]
        [Display(Name = "Student Name")]
        public string Stuname { get; set; }


        [Required(ErrorMessage = "Enter Student Contact no")]
        [Display(Name = "Contact No")]
        public int Contact { get; set; }


        [Required(ErrorMessage = "Enter Student Age")]
        [Display(Name = "Student Age")]
        [Range(18, 60)]
        public int Age { get; set; }



    }
}
