using System;
using System.Globalization;
using NUnit.Framework;

namespace CustomerLibrary.Tests
{
    [TestFixture]
    public class Customer_Tests
    {
        [TestCase(null, null, TestName = "ToStringStandard", ExpectedResult = "Customer: Jon Skeet, +99365320076, 1000000", Description = "Stadrand representation")]
        [TestCase("N", null, TestName = "ToStringOnlyName", ExpectedResult = "Customer: Jon Skeet", Description = "Represent customer using only it's name")]
        [TestCase("Err", null, TestName = "ToStringInvalidForamt", ExpectedException = typeof(FormatException), Description = "Represent customer by nonexistent format")]
        [TestCase("NP", null, TestName = "ToStringNameAndPhone", ExpectedResult = "Customer: Jon Skeet, +99365320076", Description = "Represent customer by name and contact phone")]
        public string TestToString(string format, IFormatProvider provider)
        {
            Customer customer = new Customer("Jon Skeet", "+99365320076", 1000000);
            return customer.ToString(format, provider);
        }

        [TestCase("S+", null, TestName = "PrintStandardExpectedNamePhoneRevenue", ExpectedResult = "Customer info. Name:Jon Skeet, Contact phone:+99365320076, Revenue:1000000", Description = "Stadrand representation")]
        [TestCase("S++", null, TestName = "PrintStandardWithNewLineExpectedNamePhoneRevenue", ExpectedResult = "Customer info.\nName:Jon Skeet\nContact phone:+99365320076\nRevenue:1000000", Description = "Standard representation which represent each field on a new line")]
        [TestCase("Err", null, TestName = "PrintInvalidForamt", ExpectedException = typeof(FormatException), Description = "Represent customer by nonexistent format")]
        [TestCase(null, null, TestName = "PrintWithoutParameters", ExpectedResult = "Customer info. Name:Jon Skeet, Contact phone:+99365320076, Revenue:1000000", Description = "Print without parameters")]
        public string TestPrint(string format, IFormatProvider provider)
        {
            Customer customer = new Customer("Jon Skeet", "+99365320076", 1000000);
            return customer.Print(format, provider);
        }
    }
}
