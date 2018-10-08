using System;
using System.Collections.Generic;

namespace TogglKonsol
{
    public interface IReadAllTime_Entries
    {
        List<Time_entriesItem> ReadAll(List<Users> userList, DateTime startDate, DateTime endDate);
    }
}