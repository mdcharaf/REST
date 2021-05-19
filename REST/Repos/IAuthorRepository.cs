using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using REST.Models;

namespace REST.Repos
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthors();
        Task<Author> GetAuthor(Guid id);
    }
}