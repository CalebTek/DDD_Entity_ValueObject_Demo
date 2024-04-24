using Domain.Users;
using Xunit;

namespace Domain.UnitTests.Users
{
    public class NameTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Constructor_Should_ThrowArgumentException_WhenValueIsInvalid(string? value)
        {
            Name Action() => new Name(value);
        }
    }
}