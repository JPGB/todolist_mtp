using todolist_mtp.DTO.Todo;
using todolist_mtp.Entity;

namespace todolist_mtp.Interfaces
{
	public interface ITodoRepository
	{
		Task<TodoResponseDTO> CreateAsync(CreateTodoDTO dto);
		Task<TodoResponseDTO?> DeleteAsync(int id);
		Task<TodoResponseDTO?> UpdateAsync(int id, UpdateTodoDTO dto);
		Task<List<TodoResponseDTO>> GetAllAsync();


	}
}
