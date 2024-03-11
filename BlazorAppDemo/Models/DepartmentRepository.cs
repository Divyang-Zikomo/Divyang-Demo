namespace BlazorAppDemo.Models
{
    public class DepartmentRepository
    {
        public interface IDepartmentRepository
        {
            IEnumerable<Department> GetDepartments();
            Department GetDepartment(int departmentId);
        }
    }
}
