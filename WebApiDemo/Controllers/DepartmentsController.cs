using Contracts;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartment _departmentService;
        public DepartmentsController(IDepartment departmentService)
        {

            _departmentService = departmentService;

        }
        [HttpPost]
        public int Create(Department department)
        {
            return _departmentService.Create(department);
        }
        [HttpGet]
        public List<Department> Get()
        {
            return _departmentService.GetAll();
        }
        [HttpDelete]
        public bool DeleteDepartment(int id)
        {
            return _departmentService.DeleteDepartment(id);
        }

        [HttpGet("{id}")]
        public Task<Department> GetById(int id)
        {
            return _departmentService.GetDepartment(id);
        }

        [HttpPut("{id}")]
        public bool Put(int id, Department department)
        {
            return _departmentService.PutDepartment(id, department);
        }
    }
}
