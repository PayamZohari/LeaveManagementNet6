using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Default Number of Days")]
        [Required]
        [Range(2, 20, ErrorMessage = "please inter a valid number")]
        public int DefaultDays { get; set; }
    }
}
