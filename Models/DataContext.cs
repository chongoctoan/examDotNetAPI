using Microsoft.EntityFrameworkCore;
using DMAWS_STUDENTAPI.Entities;

namespace DMAWS_STUDENTAPI.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }
    }
}