using Mapster;
using Microsoft.EntityFrameworkCore;
using todolist_mtp.Data;
using todolist_mtp.DTO.Todo;
using todolist_mtp.Entity;
using todolist_mtp.Interfaces;

namespace todolist_mtp.Repositories
{
	public class TodoRepository(DataContext context) : ITodoRepository
	{
		private readonly DataContext _context = context;

		public async Task<TodoResponseDTO> CreateAsync(CreateTodoDTO dto)
		{
			await _context.Todos.AddAsync(dto.Adapt<Todo>());
			await _context.SaveChangesAsync();

			return dto.Adapt<TodoResponseDTO>();
		}

		public async Task<TodoResponseDTO?> DeleteAsync(int id)
		{
			var todo = await _context.Todos.FindAsync(id);

			if (todo != null)
			{
				_context.Todos.Remove(todo);
				await _context.SaveChangesAsync();

				return todo.Adapt<TodoResponseDTO>();
			}

			return null;
		}

		public async Task<List<TodoResponseDTO>> GetAllAsync()
		{
			return (await _context.Todos.ToListAsync()).Select(todo => todo.Adapt<TodoResponseDTO>()).ToList();
		}

		public async Task<TodoResponseDTO?> UpdateAsync(int id, UpdateTodoDTO dto)
		{
			var todo = await _context.Todos.FindAsync(id);

			if (todo != null)
			{
				todo.IsDone = dto.IsDone;
				todo.Description = dto.Description;
				todo.Title = dto.Title;
				todo.DueDate = dto.DueDate;
				todo.Priority= dto.Priority;

				await _context.SaveChangesAsync();

				return todo.Adapt<TodoResponseDTO>();
			}

			return null;
		}
	}
}
