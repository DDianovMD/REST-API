using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Models;
using WebAPI.DTOs;
using WebAPI.Services.Contracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllEmployees()
        {
            try
            {
                ICollection<Employee> employees = await this.employeeService.GetAllAsync();

                var employeeDTOs = new List<EmployeeDTO>();

                foreach (var employee in employees)
                {
                    EmployeeDTO currentEmployee = new EmployeeDTO
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Phone = employee.Phone,
                    };

                    employeeDTOs.Add(currentEmployee);
                }

                return Ok(employeeDTOs);
            }
            catch (Exception ex)
            {
                // Log exception

                return StatusCode(500);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetEmployeeById(string id)
        {
            try
            {
                Employee employee = await this.employeeService.GetByIdAsync(id);

                if (employee != null)
                {
                    EmployeeDTO employeeDTO = new EmployeeDTO
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Phone = employee.Phone,
                    };

                    return Ok(employeeDTO);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                // Log exception

                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                FirstName = employeeDTO.FirstName,
                LastName = employeeDTO.LastName,
                Phone = employeeDTO.Phone,
            };

            try
            {
                await this.employeeService.AddAsync(employee);

                return CreatedAtAction("GetEmployeeById", new { id = employee.Id }, employee);
            }
            catch (Exception)
            {
                // Log exception

                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateEmployee([FromRoute] string id, EmployeeDTO employeeDTO)
        {
            try
            {
                Employee employee = await this.employeeService.GetByIdAsync(id);

                if (employee == null)
                {
                    return NotFound();
                }

                employee.FirstName = employeeDTO.FirstName;
                employee.LastName = employeeDTO.LastName;
                employee.Phone = employeeDTO.Phone;

                await this.employeeService.UpdateAsync(employee);

                return NoContent();
            }
            catch (Exception)
            {
                // Log exception

                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteEmployee(string id)
        {
            try
            {
                Employee employee = await this.employeeService.GetByIdAsync(id);

                if (employee == null)
                {
                    return NotFound();
                }

                await this.employeeService.DeleteAsync(employee);

                return Ok();
            }
            catch (Exception)
            {
                // Log exception

                return StatusCode(500);
            }
        }
    }
}
