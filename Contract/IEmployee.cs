using Entity;
using Microsoft.AspNetCore.Mvc;

namespace Contracts
{
    public interface IEmployee
    {
        public int Create(Employee employee);
        public List<Employee> GetAll();
        public  Task<int> Delete(int id);

        public Task<Employee> GetEmployee(int id);

        public bool PutEmployee(int id, Employee employee);

    }
}