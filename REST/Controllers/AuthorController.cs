using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAuthors()
        {
            var result = await _authorService.GetAuthors();

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
    }
}