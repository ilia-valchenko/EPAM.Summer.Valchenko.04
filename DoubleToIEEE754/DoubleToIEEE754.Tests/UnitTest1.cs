using System;
using NUnit.Framework;

namespace DoubleToIEEE754.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(17.12, TestName = "17.12ToIEEE754UsingBitConventer", ExpectedResult = "0100000000110001000111101011100001010001111010111000010100011111")]
        [TestCase(15458799817.15458, TestName = "15458799817.15458ToIEEE754UsingBitConventer", ExpectedResult = "0100001000001100110010110101010010000110010010010011110010010100")]
        [TestCase(1.00002, TestName = "1.00002ToIEEE754UsingBitConventer", ExpectedResult = "0011111111110000000000000001010011111000101101011000100011100011")]
        public string TestDoubleToIEEE754UsingBitConventer(double number)
        {
            return number.ToIEEE754UsingBitConverter();
        }
    }
}
