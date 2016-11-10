using System.Data.Entity;
using Web.Models;

namespace Web.Context
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}