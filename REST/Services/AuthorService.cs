using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST.Models;
using REST.Repos;
using REST.Resources;

namespace REST.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repo;

        public AuthorService(IAuthorRepository repo)
        {
            _repo = repo ?? throw new ArgumentNullException();
        }

        public async Task<IEnumerable<AuthorResource>> GetAuthors()
        {
            return (await _repo.GetAuthors()).Select(a => new AuthorResource(a));
        }

        public async Task<AuthorResource> GetAuthor(Guid id)
        {
            var author = await _repo.GetAuthor(id);
            return author == null ? null : new AuthorResource(author);
        }
    }
}