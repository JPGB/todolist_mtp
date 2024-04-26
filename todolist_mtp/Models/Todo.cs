using System.ComponentModel.DataAnnotations;

namespace todolist_mtp.Entity
{
	public class Todo
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool IsDone { get; set; } = false;
		public DateOnly DueDate { get; set; }
		public string Priority { get; set; } = string.Empty;

	}
}
