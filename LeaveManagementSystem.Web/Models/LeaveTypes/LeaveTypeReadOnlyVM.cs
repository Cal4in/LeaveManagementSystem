using System.ComponentModel;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;
        
        [DisplayName("Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
