using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public String Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }
    }
}
