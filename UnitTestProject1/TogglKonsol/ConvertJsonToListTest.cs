using System.Collections.Generic;
using TogglKonsol;
using Xunit;

namespace UnitTestProject1
{
    public class ConvertJsonToListTest
    {
        private readonly ConvertJsonStringToListUsers _convertJsonToList;

        public ConvertJsonToListTest()
        {
            _convertJsonToList = new ConvertJsonStringToListUsers();
        }


        [Fact]
        public void NameTest()
        {
            string Actual = null;
            string json = @"[{'apiKey':'ccf6fe47c4c61261b6eb9148811e4b5b','Name':'Karl Rößler'}]";
            List<Users> UserList = _convertJsonToList.Convert(json);
            foreach (Users item in UserList)
            {
                Actual = item.Name;
            }
            Assert.Equal(expected: "Karl Rößler", actual: Actual);
        }

        [Fact]
        public void ApiKeyTest()
        {
            string Actual = null;
            string json = @"[{'apiKey':'ccf6fe47c4c61261b6eb9148811e4b5b','Name':'Karl Rößler'}]";
            List<Users> UserList = _convertJsonToList.Convert(json);
            foreach (Users item in UserList)
            {
                Actual = item.ApiKey;
            }
            Assert.Equal(expected: "ccf6fe47c4c61261b6eb9148811e4b5b", actual: Actual);
        }

        [Fact]
        public void Multi()
        {
            string Actual = null;
            string json = @"[{'apiKey':'ccf6fe47c4c61261b6eb9148811e4b5b','Name':'Karl Rößler'},{'apiKey':'ThisIsATestKey','Name':'Test'}]";
            List<Users> UserList = _convertJsonToList.Convert(json);
            foreach (Users item in UserList)
            {
                Actual = item.ApiKey;
            }
            Assert.Equal(expected: "ThisIsATestKey", actual: Actual);
        }
    }
}
