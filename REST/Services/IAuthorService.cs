using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using REST.Models;
using REST.Resources;

namespace REST.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorResource>> GetAuthors();
        Task<AuthorResource> GetAuthor(Guid id);
        Task<IEnumerable<AuthorResource>> GetAuthors(Expression<Func<Author, bool>> predicate);
        Task<AuthorResource> CreateAuthor(Author author);
    }
}