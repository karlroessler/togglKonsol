using Moq;
using System;
using TogglKonsolDate;
using Xunit;

namespace UnitTestProject1.TogglKonsolDate
{
    public class ConvertTimeAreaWordTest
    {
        private readonly ConvertTimeAreaWord _convertTimeAreaWord;
        public ConvertTimeAreaWordTest()
        {
            var mockDateTimeHelper = new Mock<IDateTimeHelper>();
            DateTime fakeDate = new DateTime(2014, 12, 24);
            mockDateTimeHelper.Setup(o => o.GetDateTimeNow()).Returns(fakeDate);
            _convertTimeAreaWord = new ConvertTimeAreaWord(mockDateTimeHelper.Object);
        }


        [Fact]
        public void Today()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("Today");
            TimeDate Expected = new TimeDate
            {
                StartDate = new DateTime(2014, 12, 24),
                EndDate = new DateTime(2014, 12, 25)
            };
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void Yesterday()
        {

            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("Yesterday");
            TimeDate Expected = new TimeDate
            {
                StartDate = new DateTime(2014, 12, 23),
                EndDate = new DateTime(2014, 12, 24)
            };
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void ThisWeek()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("ThisWeek");
            TimeDate Expected = new TimeDate
            {
                StartDate = new DateTime(2014, 12, 21),
                EndDate = new DateTime(2014, 12, 28)
            };
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void LastWeek()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("LastWeek");
            TimeDate Expected = new TimeDate
            {
                StartDate = new DateTime(2014, 12, 13),
                EndDate = new DateTime(2014, 12, 20)
            };
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void ThisMonth()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("ThisMonth");
            TimeDate Expected = new TimeDate
            {
                StartDate = new DateTime(2014, 12, 01),
                EndDate = new DateTime(2014, 12, 31)
            };
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void LastMonth()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("LastMonth");
            TimeDate Expected = new TimeDate
            {
                StartDate = new DateTime(2014, 11, 01),
                EndDate = new DateTime(2014, 11, 30)
            };
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void WrongWord()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("Test");
            TimeDate Expected = null;
            Assert.Equal(expected: Expected, actual: Actual);
        }

        [Fact]
        public void WrongWord2()
        {
            TimeDate Actual = _convertTimeAreaWord.ConvertTimeAreaWordToTimeArea("WordToDate");
            TimeDate Expected = null;
            Assert.Equal(expected: Expected, actual: Actual);
        }
    }
}
