using Newtonsoft.Json;
using System.Collections.Generic;

namespace TogglKonsol
{
    public class ConvertJsonStringToListUsers : IConvertJsonStringToListUsers
    {

        public List<Users> Convert(string json)
        {
            return JsonConvert.DeserializeObject<List<Users>>(json);
        }
    }
}
