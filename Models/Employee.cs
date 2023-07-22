using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DMAWS_STUDENTAPI.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [ MinLength(2), MaxLength(150)]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime EmployeeDOB { get; set; }

        [Required]
        public string EmployeeDepartment { get; set; }
        
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

    }
}