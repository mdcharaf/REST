using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using REST.Models;

namespace REST.Repos
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthors();
        Task<Author> GetAuthor(Guid id);
        Task<IEnumerable<Author>> GetAuthors(Expression<Func<Author, bool>> predicate);
        Task<Author> CreateAuthor(Author author);
    }
}