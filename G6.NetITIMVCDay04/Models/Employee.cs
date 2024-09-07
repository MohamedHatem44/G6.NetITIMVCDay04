using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G6.NetITIMVCDay04.Models
{
    public class Employee
    {
        /*--------------------------------------------------------*/
        public int Id { get; set; }


        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 15 char")]
        [Required(ErrorMessage = "The Employee Name is required.")]
        [DisplayName("Employee Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The Employee Age is required.")]
        [Range(15, 60, ErrorMessage = "Age must be between 15 and 60 year")]
        [DisplayName("Employee Age")]
        public int Age { get; set; }


        [Range(1000, 15000, ErrorMessage = "Salary must be between 1000 and 15000 EGP")]
        [DisplayName("Employee Salary")]
        [Column(TypeName = "decimal(8,2)")]      // => 123456.78
        public decimal Salary { get; set; }


        [Required(ErrorMessage = "The Employee Address is required.")]
        [MinLength(4, ErrorMessage = "Address must be more than 4 char")]
        [MaxLength(20, ErrorMessage = "Address must be less than 20 char")]
        [DisplayName("Employee Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "The Employee Email is required.")]
        [EmailAddress]
        [DisplayName("Employee Email")]
        public string Email { get; set; }
        /*--------------------------------------------------------*/
        //[ForeignKey("Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        //[ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        /*--------------------------------------------------------*/
    }
}
