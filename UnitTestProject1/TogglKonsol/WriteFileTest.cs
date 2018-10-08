using Xunit;
using TogglKonsol;

namespace UnitTestProject1
{
    public class WriteFileTest
    {
        readonly public WriteFile _writeFile;

        public WriteFileTest()
        {
            _writeFile = new WriteFile();
        }

        [Fact]
        public void EmptyPath()
        {
            bool Actual = _writeFile.CSVFile("This is a Text","");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void MissingDrive()
        {
            bool Actual = _writeFile.CSVFile("This is a Text", @"test\funktioniertAllSuper.csv");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void MissingChar()
        {
            bool Actual = _writeFile.CSVFile("This is a Text", @"C:test\funktioniertAllSuper.csv");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void CorrectPath()
        {
            bool Actual = _writeFile.CSVFile("This is a Text", @"C:\test\funktioniertAllSuper.csv");
            bool Expected = true;
            Assert.Equal(expected: Expected, actual: Actual);
        }
    }
}
