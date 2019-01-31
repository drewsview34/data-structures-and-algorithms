using MultiBracketValidation13;
using System;
using Xunit;

namespace MultiBracketValidation13XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void BracketValidationOne()
        {
            //arrange
            string one = "{{}})";

            //act
            var result = Program.BracketValidation(one);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void BracketValidationTwo()
        {
            //arrange
            string one = "{{}}";

            //act
            var result = Program.BracketValidation(one);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void BracketValidationThree()
        {
            //arrange
            string one = "[({{}})]";

            //act
            var result = Program.BracketValidation(one);

            //assert
            Assert.True(result);
        }
    }
}