using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "Value is out of range")]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [Range(1, 90)]
        [DisplayName("Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
