using Xunit;
using TogglKonsol;

namespace UnitTestProject1
{
    public class SplitTextTest
    {
        private readonly SplitText _splitText;

        public SplitTextTest()
        {
            _splitText = new SplitText();
        }

        [Fact]
        public void Split1()
        {
            string Actual = _splitText.SplintOnFirst("This:Is:ATest");
            string Expected = "Is:ATest";
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void Split2()
        {
            string Actual = _splitText.SplintOnFirst("ThisIs:ATest");
            string Expected = "ATest";
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void Split3()
        {
            string Actual = _splitText.SplintOnFirst("ThisIsATest");
            string Expected = null;
            Assert.Equal(expected: Expected, actual: Actual);
        }
    }
}
