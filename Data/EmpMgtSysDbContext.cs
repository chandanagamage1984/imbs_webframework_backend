using EmployeesManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagementSystem.Data
{
    public class EmpMgtSysDbContext: DbContext
    {
        public EmpMgtSysDbContext(DbContextOptions<EmpMgtSysDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
