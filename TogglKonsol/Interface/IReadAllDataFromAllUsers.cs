using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IReadAllDataFromAllUsers
    {
        List<Item> ReadAll(List<Users> userlist);
    }
}