using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PublisherController : ControllerBase
	{
		IPublisherService _publisherService;
		public PublisherController(IPublisherService publisherService)
		{
			_publisherService = publisherService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _publisherService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);

		}
		[HttpPost("add")]
		public IActionResult Post(Publisher publisher)
		{
			var result = _publisherService.Add(publisher);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(Publisher publisher)
		{
			var result = _publisherService.Delete(publisher);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(Publisher publisher)
		{
			var result = _publisherService.Update(publisher);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
