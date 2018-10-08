using System;
using System.Collections.Generic;
using System.Linq;

namespace TogglKonsol
{
    class FormatTime_EntriesForConsol : IFormatTime_EntriesForConsol
    {
        public string Format(List<Time_entriesItem> timelist)
        {
            string output = null;
            int pointLength = 0;
            int maxLengthDescription = timelist.Max(str => str == null ? 0 : str.Description.Length);
            if (maxLengthDescription < 11)
            {
                maxLengthDescription = 11;
            }

            int maxLengthStart = timelist.Max(str => str == null ? 0 : str.Start.Length);
            int maxLengthAT = timelist.Max(str => str == null ? 0 : str.At.Length);
            int maxLengthDuration = timelist.Max(str => str == null ? 0 : (int)Math.Floor(Math.Log10(str.Duration)));
            output = "Description" + new String(' ', maxLengthDescription - 11) + " Start" + new String(' ', maxLengthStart - 5) + " AT\r\n";

            for (int i = 0; i < timelist.Count; i++)
            {
                pointLength = maxLengthDescription - timelist[i].Description.Length;
                output = output + timelist[i].Description + new String(' ', pointLength) + " " + timelist[i].Start + "\r\n";
            }

            return output;
        }
    }
}
