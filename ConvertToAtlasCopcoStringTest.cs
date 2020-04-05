using System;
using AtlasCopco.SoftwareTesterTest;
using Xunit;
using FluentAssertions;

namespace AtlasCopcoXunitTest
{
	public class ConvertToAtlasCopcoStringTest
	{
		private IVariousMethods variousMethods = new VariousMethods();

		[Theory]
		[InlineData(87, "ERROR:)")]
		[InlineData(15, "AtlasCopco")]
		[InlineData(9, "Atlas")]
		[InlineData(20, "Copco")]
		[InlineData(7, "7")]
		public void ConvertIntToAtlasCopcoString(int input, string expected)
		{
			var actual = variousMethods.ConvertToAtlasCopcoString(input);
			actual.Should().Be(expected);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(101)]
		public void ConvertToAtlasCopcoStringIllegalValue(int input)
		{
			variousMethods.Invoking(x => x.ConvertToAtlasCopcoString(input))
				.Should().Throw<ArgumentException>()
				.WithMessage("numberToConvert was outside of the valid range");
		}
	}
}
