using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using REST.DB;
using REST.Models;

namespace REST.Repos
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly RestDbContext _context;

        public AuthorRepository(RestDbContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<Author> GetAuthor(Guid id)
        {
            return await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Author>> GetAuthors(Expression<Func<Author, bool>> predicate)
        {
            return await _context.Authors.Where(predicate).ToListAsync();
        }

        public async Task<Author> CreateAuthor(Author author)
        {
            author.Id = Guid.NewGuid();
            await _context.AddAsync(author);
            await _context.SaveChangesAsync();
            
            return author;
        }
    }
}