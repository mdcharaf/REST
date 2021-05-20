using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST.ActionsParameters;
using REST.Models;
using REST.Resources;
using REST.Services;

namespace REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors([FromQuery] AuthorParameters authorParameters)
        {
            if (string.IsNullOrWhiteSpace(authorParameters?.MainCategory))
            {
                return new JsonResult(await _authorService.GetAuthors());
            }

            authorParameters.MainCategory = authorParameters.MainCategory.Trim();
            var result = await _authorService.GetAuthors(a => a.MainCategory == authorParameters.MainCategory);
            
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(Guid id)
        {
            var author = await _authorService.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }

            return Ok(new JsonResult(author));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorParameter authorParameter)
        {
            var author = new Author
            {
                FirstName = authorParameter.FirstName,
                LastName = authorParameter.LastName,
                Dob = authorParameter.Dob,
                MainCategory = authorParameter.MainCategory
            };
            
            var result = await _authorService.CreateAuthor(author);

            return CreatedAtAction("GetAuthor", new {id = result.Id}, result);
        }
    }
}