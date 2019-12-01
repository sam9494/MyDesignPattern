using MyDesignPattern.FactoryDesignPattern;
using NUnit.Framework;

namespace MyDesignPattern.Temp
{
    [TestFixture]
    public class TestPrintTest
    {
        [Test]
        public void should_print_hello()
        {
            var testPrint = new TestPrint();
            var actual = testPrint.PrintHello();
            Assert.AreEqual(actual,"hello");
        }

    }
}