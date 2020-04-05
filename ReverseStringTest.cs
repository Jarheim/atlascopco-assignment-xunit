using System;
using AtlasCopco.SoftwareTesterTest;
using FluentAssertions;
using Xunit;

namespace AtlasCopcoXunitTest
{
    public class ReverseStringTest
    {
        private IVariousMethods variousMethods = new VariousMethods();

		[Theory]
		[InlineData("abc123$\"", "\"$321cba")]
		[InlineData("a", "a")]
		public void ReverseString(string input, string expected)
		{
			var actual = variousMethods.ReverseString(input);
			actual.Should().Be(expected);
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
