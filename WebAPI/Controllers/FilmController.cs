using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FilmController : ControllerBase
	{
		IFilmService _filmService;
		public FilmController(IFilmService filmService)
		{
			_filmService = filmService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _filmService.GetAll();
			if(result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

	}
}
