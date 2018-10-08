using TogglKonsol;
using Xunit;

namespace UnitTestProject1
{
    public class CheckDateExistTest
    {
        private readonly CheckDateExist _checkDateExist;

        public CheckDateExistTest()
        {
            _checkDateExist = new CheckDateExist();
        }

        [Fact]
        public void DateEmpty()
        {
            bool Actual = _checkDateExist.IsDateValid("");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void DateText()
        {
            bool Actual = _checkDateExist.IsDateValid("sadsadsad");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void DateWrongMonth()
        {
            bool Actual = _checkDateExist.IsDateValid("2000-13-02");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void DateWrongDay()
        {
            bool Actual = _checkDateExist.IsDateValid("2000-11-60");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void DateWrongFormat()
        {
            bool Actual = _checkDateExist.IsDateValid("20-2000-12");
            bool Expected = false;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void TrueDate1()
        {
            bool Actual = _checkDateExist.IsDateValid("2000-11-02");
            bool Expected = true;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void TrueDate2()
        {
            bool Actual = _checkDateExist.IsDateValid("2000-06-12");
            bool Expected = true;
            Assert.Equal(expected: Expected, actual: Actual);
        }
    }
}
