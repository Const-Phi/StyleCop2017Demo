namespace DemoLibraryTests
{
    using DemoLibrary;
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для <see cref="DemoClass"/>.
    /// </summary>
    public class DemoClassTests
    {
        [Test]
        public void ToString_ValidValue_Success()
        {
            // arrange
            var demo = new DemoClass { Value = 42 };

            // act
            var actual = demo.ToString();

            // assert
            Assert.AreEqual("Value is 42", actual);
        }
    }
}
