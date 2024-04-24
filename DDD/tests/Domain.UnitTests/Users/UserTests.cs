using Domain.Users;
using FluentAssertions;

namespace Domain.UnitTests.Users
{
    public class UserTests
    {
        [Fact]
        public void Create_Should_ReturnUser_WhenNameIsValid()
        {
            // Arrange
            var name = new Name("John Doe");

            // Act
            var user = User.Create(name);

            // Assert
            user.Should().NotBeNull();
        }
    }
}
