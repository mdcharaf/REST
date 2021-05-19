using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using REST.Models;
using REST.Resources;

namespace REST.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorResource>> GetAuthors();
        Task<AuthorResource> GetAuthor(Guid id);
    }
}