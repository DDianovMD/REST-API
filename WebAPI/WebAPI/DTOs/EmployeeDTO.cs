using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTOs
{
    public class EmployeeDTO
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [Phone]
        public string Phone { get; set; } = null!;
    }
}
