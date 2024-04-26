namespace todolist_mtp.DTO.Todo
{
	public class UpdateTodoDTO
	{
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public bool IsDone { get; set; } = false;
		public DateOnly DueDate { get; set; }
		public string Priority { get; set; } = string.Empty;

	}
}
