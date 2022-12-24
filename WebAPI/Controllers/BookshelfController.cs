using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookshelfController : ControllerBase
	{
		IBookshelfService _bookshelfService;
		public BookshelfController(IBookshelfService bookshelfService)
		{
			_bookshelfService = bookshelfService;
		}
		[HttpPost("add")]
		public IActionResult Add(Bookshelf bookshelf)
		{
			var result = _bookshelfService.Add(bookshelf);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Bookshelf bookshelf)
		{
			var result = _bookshelfService.Delete(bookshelf);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _bookshelfService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Bookshelf bookshelf)
		{
			var result = _bookshelfService.Update(bookshelf);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}


	}
}
