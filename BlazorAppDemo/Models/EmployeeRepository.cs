namespace BlazorAppDemo.Models
{
    public class EmployeeRepository
    {
        public interface IEmployeeRepository
        {
            Task<IEnumerable<DemoClass>> GetEmployees();
            Task<DemoClass> GetEmployee(int employeeId);
            Task<DemoClass> AddEmployee(DemoClass employee);
            Task<DemoClass> UpdateEmployee(DemoClass employee);
            void DeleteEmployee(int employeeId);
        }
    }
}
