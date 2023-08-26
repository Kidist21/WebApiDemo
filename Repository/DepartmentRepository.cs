using Contracts;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly EmployeeDbContext _dbContext;
        public DepartmentRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Department department)
        {
            _dbContext.Departments.Add(department);

            _dbContext.SaveChanges();

            return department.Id;
        }

        public bool DeleteDepartment(int id)
        {
            var existing = _dbContext.Departments.Find(id);
             
            _dbContext.Departments.Remove(existing);

            _dbContext.SaveChanges();

            return true;
           
        }
    

        public List<Department> GetAll()
        {
            return _dbContext.Departments.ToList();
        }
        public async Task<Department> GetDepartment(int id)
        {
            if (_dbContext.Departments == null)
            {
                return null;
            }
            var department = await _dbContext.Departments.FindAsync(id);
            if (department == null)
            {
                return null;
            }

            return department;
        }

        public bool PutDepartment(int id, Department department)
        {
            var existing = _dbContext.Departments.Find(id);
            if (id == department.Id)
            {
                existing.name = department.name;
              
                _dbContext.Departments.Update(existing);
                _dbContext.SaveChanges();
                return true;
            }
            return false;


        }
    }
}
