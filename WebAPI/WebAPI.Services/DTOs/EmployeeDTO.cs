using System.ComponentModel.DataAnnotations;

namespace WebAPI.Services.DTOs
{
    public class EmployeeDTO
    {
        public string? Id { get; set; }

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
