using BlazorAppDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static BlazorAppDemo.Models.EmployeeRepository;

namespace BlazorAppDemo.Controllers
{
    public class HomeController : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public IEnumerable<DemoClass> Employees { get; set; }

        public HomeController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<DemoClass>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }

        public async Task<DemoClass> GetEmployee(int employeeId)
        {
            return await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.id == employeeId);
        }

        public async Task<DemoClass> AddEmployee(DemoClass employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<DemoClass> UpdateEmployee(DemoClass employee)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.id == employee.id);

            if (result != null)
            {
                result.id = employee.id;
                result.name = employee.name;
                result.passWord = employee.passWord;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async void DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.id == employeeId);
            if (result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }
    }
}