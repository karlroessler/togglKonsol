using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IConvertJsonStringToListUsers
    {
        List<Users> Convert(string json);
    }
}