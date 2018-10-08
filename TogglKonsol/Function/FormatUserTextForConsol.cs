using System;
using System.Collections.Generic;
using System.Linq;

namespace TogglKonsol
{
    class FormatUserTextForConsol : IFormatUserTextForConsol
    {
        public string Format(List<Users> userlist)
        {
            string output = null;
            int maxLengthApiKey = userlist.Max(str => str == null ? 0 : str.ApiKey.Length);
            int maxLengthName = userlist.Max(str => str == null ? 0 : str.Name.Length);
            int maxLength = maxLengthApiKey + maxLengthName;
            int pointLength = 0;
            output = (char)9484 + new String('-', maxLength +1) + (char)9488 + "\r\n";
            output = output + "|Name" + new String(' ', maxLengthName - 4) + " API-Key" + new String(' ', maxLengthApiKey - 7) + "|\r\n";


            for (int i = 0; i < userlist.Count; i++)
            {
                pointLength = maxLengthName - userlist[i].Name.Length;
                output = output + "|" + userlist[i].Name + new String(' ', pointLength) + " " + userlist[i].ApiKey + "|\r\n";
            }

            output = output + (char)9492 + new String('-', maxLength + 1) + (char)9496 + "\r\n";

            return output;
        }
    }
}
