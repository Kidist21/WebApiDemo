using Contracts;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployee _employeeService;
        public EmployeesController(IEmployee employeeService)
        {

            _employeeService = employeeService; 

        }
        [HttpPost]
        public int Create(Employee employee) 
        { 
            return _employeeService.Create(employee);
        }
        [HttpGet]
        public List<Employee> Get() 
        { 
        return _employeeService.GetAll();
        }
    }
}
