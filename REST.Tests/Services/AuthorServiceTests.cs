using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using REST.Models;
using REST.Repos;
using REST.Services;
using Shouldly;

namespace REST.Tests.Services
{
    [TestFixture]
    public class AuthorServiceTests
    {
        private readonly Mock<IAuthorRepository> _authorRepositoryMock = new Mock<IAuthorRepository>();
        private AuthorService _authorService; 

        public AuthorServiceTests()
        {
            _authorService = new AuthorService(_authorRepositoryMock.Object);
        }

        [Test]
        public async Task GetAuthors_MethodExecuted_ShouldGetAuthors()
        {
            // Arrange
            _authorRepositoryMock.Setup(r => r.GetAuthors()).ReturnsAsync(new List<Author>());
            
            // Act
            var result = await _authorService.GetAuthors();
            
            // Assert
            result.ShouldNotBeNull();
        }
        
    }
}