using Microsoft.EntityFrameworkCore;
using todolist_mtp.Entity;

namespace todolist_mtp.Data
{
	public class DataContext(DbContextOptions options) : DbContext(options)
	{
		public DbSet<Todo> Todos { get; set; }
	}
}
