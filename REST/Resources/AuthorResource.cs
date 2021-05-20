using System;
using REST.Models;

namespace REST.Resources
{
    public class AuthorResource : ResourceBase<Author>
    {
        public AuthorResource(Author model) : base(model)
        {
        }

        public Guid Id => Model.Id;

        public string FirstName => Model.FirstName;

        public string LastName => Model.LastName;

        public DateTime Dob => Model.Dob;
        
        public string MainCategory => Model.MainCategory;
    }
}