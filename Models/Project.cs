using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DMAWS_STUDENTAPI.Models
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [MinLength(2), MaxLength(150)]
        public string ProjectName { get; set; }
        [Required]
        public DateTime ProjectStartDate { get; set; }
       
        public DateTime ProjectEndDate { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
    }
}