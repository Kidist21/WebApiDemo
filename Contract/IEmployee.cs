using Entity;

namespace Contracts
{
    public interface IEmployee
    {
        public int Create(Employee employee);
        public List<Employee> GetAll();

    }
}