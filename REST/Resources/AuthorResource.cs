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

        public string FirstNAme => Model.FirstName;

        public string LastName => Model.LastName;

        public string MainCategory => Model.MainCategory;
    }
}