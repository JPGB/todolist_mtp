namespace todolist_mtp.DTO.Todo
{
	public class CreateTodoDTO
	{
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public DateOnly DueDate { get; set; }
		public string Priority { get; set; } = string.Empty;

	}
}
