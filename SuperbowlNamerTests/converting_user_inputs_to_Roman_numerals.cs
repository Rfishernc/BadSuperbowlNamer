using BadSuperbowlNamer;
using System;
using Xunit;

namespace SuperbowlNamerTests
{
    public class converting_user_inputs_to_Roman_numerals
    {
        [Fact]
        public void input_of_1_outputs_I()
        {
            var namer = new SuperbowlNamer();
            var input = "1";
            var expectedResult = "I";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_5_outputs_V()
        {
            var namer = new SuperbowlNamer();
            var input = "5";
            var expectedResult = "V";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_9_outputs_IX()
        {
            var namer = new SuperbowlNamer();
            var input = "9";
            var expectedResult = "IX";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_12_outputs_XII()
        {
            var namer = new SuperbowlNamer();
            var input = "12";
            var expectedResult = "XII";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_16_outputs_XVI()
        {
            var namer = new SuperbowlNamer();
            var input = "16";
            var expectedResult = "XVI";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_29_outputs_XXIX()
        {
            var namer = new SuperbowlNamer();
            var input = "29";
            var expectedResult = "XXIX";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_44_outputs_XLIV()
        {
            var namer = new SuperbowlNamer();
            var input = "44";
            var expectedResult = "XLIV";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_45_outputs_XLV()
        {
            var namer = new SuperbowlNamer();
            var input = "45";
            var expectedResult = "XLV";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_68_outputs_LXVIII()
        {
            var namer = new SuperbowlNamer();
            var input = "68";
            var expectedResult = "LXVIII";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_83_outputs_LXXXIII()
        {
            var namer = new SuperbowlNamer();
            var input = "83";
            var expectedResult = "LXXXIII";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_97_outputs_XCVII()
        {
            var namer = new SuperbowlNamer();
            var input = "97";
            var expectedResult = "XCVII";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_99_outputs_XCIX()
        {
            var namer = new SuperbowlNamer();
            var input = "99";
            var expectedResult = "XCIX";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_500_outputs_D()
        {
            var namer = new SuperbowlNamer();
            var input = "500";
            var expectedResult = "D";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_501_outputs_DI()
        {
            var namer = new SuperbowlNamer();
            var input = "501";
            var expectedResult = "DI";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_649_outputs_DCXLIX()
        {
            var namer = new SuperbowlNamer();
            var input = "649";
            var expectedResult = "DCXLIX";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_798_outputs_DCCXCVIII()
        {
            var namer = new SuperbowlNamer();
            var input = "798";
            var expectedResult = "DCCXCVIII";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_891_outputs_DCCCXCI()
        {
            var namer = new SuperbowlNamer();
            var input = "891";
            var expectedResult = "DCCCXCI";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_1000_outputs_M()
        {
            var namer = new SuperbowlNamer();
            var input = "1000";
            var expectedResult = "M";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_1004_outputs_MIV()
        {
            var namer = new SuperbowlNamer();
            var input = "1004";
            var expectedResult = "MIV";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_1006_outputs_MVI()
        {
            var namer = new SuperbowlNamer();
            var input = "1006";
            var expectedResult = "MVI";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_1023_outputs_MXXIII()
        {
            var namer = new SuperbowlNamer();
            var input = "1023";
            var expectedResult = "MXXIII";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_2014_outputs_MMXIV()
        {
            var namer = new SuperbowlNamer();
            var input = "2014";
            var expectedResult = "MMXIV";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void input_of_3999_outputs_MMMCMXCIX()
        {
            var namer = new SuperbowlNamer();
            var input = "3999";
            var expectedResult = "MMMCMXCIX";

            var actualResult = namer.ConvertNumber(input);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
