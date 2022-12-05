using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name ="Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="Default Number Of days")]
        [Required]
        [Range(0,25 ,ErrorMessage = "Please Enter Valid number")]
        public int DefaultDays { get; set; }
    }
}
