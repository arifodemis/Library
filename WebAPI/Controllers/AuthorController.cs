using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorController : ControllerBase
	{
		IAuthorService _authorService;
		public AuthorController(IAuthorService authorService)
		{
			_authorService = authorService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _authorService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);

		}
		[HttpPost("add")]
		public IActionResult Post(Author author)
		{
			var result = _authorService.Add(author);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Author author)
		{
			var result = _authorService.Delete(author);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Author author)
		{
			var result = _authorService.Update(author);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

	}
}
