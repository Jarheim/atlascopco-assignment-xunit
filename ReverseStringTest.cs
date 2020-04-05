using System;
using AtlasCopco.SoftwareTesterTest;
using FluentAssertions;
using Xunit;

namespace AtlasCopcoXunitTest
{
    public class ReverseStringTest
    {
        private IVariousMethods variousMethods = new VariousMethods();

		[Fact]
		public void ReverseString()
		{
			var actual = variousMethods.ReverseString("abc123$\"");
			actual.Should().Be("\"$321cba");
		}

		[Theory]
		[InlineData(null)]
		[InlineData("")]
		public void ReverseStringIllegalValue(string input)
		{
			variousMethods.Invoking(x => x.ReverseString(input))
				.Should().Throw<ArgumentException>()
				.WithMessage("The string to reverse must contain characters");
		}
	}
}
