using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
	public class CategoriesController : ControllerBase
	{
		ICategorytService _categoryService;
		
		public CategoriesController(ICategorytService categoryService)
		{
			_categoryService = categoryService;
		}
		
		[HttpGet("getall")]		
		public IActionResult GetAll()
		{
			//Swagger
			var result = _categoryService.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}