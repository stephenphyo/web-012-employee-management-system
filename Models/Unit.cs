using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? UnitName { get; set; }
        public string? Description { get; set; }

        /* Navigational Properties */
        // [Required]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = [];
    }
}