using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		IBookService _bookService;
		public BookController(IBookService bookService)
		{
			_bookService = bookService;
		}
		[HttpPost("add")]
		public IActionResult Add(Book book)
		{
			var result = _bookService.Add(book);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Book book)
		{
			var result = _bookService.Delete(book);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _bookService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Book book)
		{
			var result = _bookService.Update(book);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}


	}
}
