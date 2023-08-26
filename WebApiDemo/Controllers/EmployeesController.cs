using Contracts;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpDelete]
        public Task<int> Delete(int id)
        {
            return _employeeService.Delete(id);
        }

        [HttpGet("{id}")]
        public Task<Employee> GetById(int id)
        {
            return _employeeService.GetEmployee(id);
        }

        [HttpPut("{id}")]
        public bool PutEmployee(int id, Employee employee)
        {
            return _employeeService.PutEmployee(id, employee);
        }

    }
}
