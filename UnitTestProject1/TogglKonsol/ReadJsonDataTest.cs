using Xunit;
using TogglKonsol;

namespace UnitTestProject1
{
    public class ReadJsonDataTest
    {
        private readonly ReadJsonData _readJsonData;
        public ReadJsonDataTest()
        {
            _readJsonData = new ReadJsonData();
        }


        [Fact]
        public void ReadUsersJson()
        {
            string json = "[{\"apiKey\": \"ccf6fe47c4c61261b6eb9148811e4b5b\",\"Name\": \"Karl Rößler\"}]";
            string Actual = _readJsonData.Read("test.json");
            Assert.Equal(expected: json, actual: Actual);
        }
    }
}
