using Mapster;
using Microsoft.AspNetCore.Mvc;
using todolist_mtp.DTO.Todo;
using todolist_mtp.Entity;
using todolist_mtp.Interfaces;
using todolist_mtp.Repositories;

namespace todolist_mtp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TodoController(ITodoRepository todoRepository) : ControllerBase
	{
		private readonly ITodoRepository _todoRepository = todoRepository;

		[HttpPost]
		public async Task<IActionResult> Create(CreateTodoDTO todo)
		{
			await _todoRepository.CreateAsync(todo);
			return Ok(todo.Adapt<TodoResponseDTO>());
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await _todoRepository.GetAllAsync());
		}

		[HttpPut]
		public async Task<IActionResult> Update(int id, UpdateTodoDTO dto)
		{
			var todo = await _todoRepository.UpdateAsync(id, dto);

			if (todo == null)
			{
				return NotFound();
			}

			return Ok(todo);
		}

		[HttpDelete]
		public async Task<IActionResult> Delete(int id)
		{
			var todo = await _todoRepository.DeleteAsync(id);

			if (todo == null)
			{
				return NotFound();
			}

			return Ok(todo);
		}
	}
}
