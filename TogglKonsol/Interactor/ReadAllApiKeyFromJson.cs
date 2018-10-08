using System.Collections.Generic;

namespace TogglKonsol
{
    class ReadListApiKey : IReadListApiKey
    {
        private readonly IReadJsonData _readJsonData;
        private readonly IConvertJsonStringToListUsers _convertJsonToList;

        public ReadListApiKey(
            IReadJsonData readJsonData,
            IConvertJsonStringToListUsers convertJsonToList)
        {
            _readJsonData = readJsonData;
            _convertJsonToList = convertJsonToList;
        }

        public List<Users> Execute()
        {
            string json = _readJsonData.Read("users.json");
            return _convertJsonToList.Convert(json);
        }
    }
}
