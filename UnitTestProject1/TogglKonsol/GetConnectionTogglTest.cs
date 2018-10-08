using Xunit;
using TogglKonsol;

namespace UnitTestProject1
{
    public class GetConnectionTogglTest
    {
        private readonly GetConnectionToggl _getConnectionToggl;

        public GetConnectionTogglTest()
        {
            _getConnectionToggl = new GetConnectionToggl();
        }

        [Fact]
        public void ReadProjectWithNumber()
        {
            string ApiToken = "ccf6fe47c4c61261b6eb9148811e4b5b";
            string url = "https://www.toggl.com/api/v8/projects/132351080";
            string json = "{\"data\":{\"id\":132351080,\"wid\":2875373,\"name\":\"An awesome project von Karl\",\"billable\":false,\"is_private\":true,\"active\":true,\"template\":false,\"at\":\"2018-08-01T06:59:56+00:00\",\"created_at\":\"2018-08-01T06:59:56+00:00\",\"server_deleted_at\":\"2018-08-01T10:16:48+00:00\",\"color\":\"9\",\"auto_estimates\":false,\"hex_color\":\"#a01aa5\"}}";
            string Actual = _getConnectionToggl.Get(ApiToken, url);
            Assert.Equal(expected: json, actual: Actual);
        }
    }
}
