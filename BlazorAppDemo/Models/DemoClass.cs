using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppDemo.Models
{
    public class DemoClass : DbContext
    {
        public DemoClass(DbContextOptions<DemoClass>options):base(options)
        {
        }
        [Required]
        [MinLength(2)]
        public string name { get; set; } = "Demo";
        public int id { get; set; } = 10001;
        public string passWord { get; set; } = "Demo123";

    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
