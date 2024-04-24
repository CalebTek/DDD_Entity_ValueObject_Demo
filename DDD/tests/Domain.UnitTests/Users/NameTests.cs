using Domain.Users;
using FluentAssertions;
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

            // Assert
            FluentActions.Invoking(Action).Should().Throw<ArgumentException>()
                .Which.ParamName.Should().Be("value");
        }

        [Fact]
        public void Equals_Should_ReturnTrue_WhenNamesAreEqual()
        {
            // Arrange
            var name1 = new Name("John");
            var name2 = new Name("John");

            // Act
            bool result = name1.Equals(name2);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Equals_Should_ReturnFalse_WhenNamesAreDifferent()
        {
            // Arrange
            var name1 = new Name("John");
            var name2 = new Name("Jane");

            // Act
            bool result = name1.Equals(name2);

            // Assert
            result.Should().BeFalse();
        }

    }
}