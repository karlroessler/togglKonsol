using System.Collections.Generic;

namespace TogglKonsol
{
    public class WriteUserApiKeyConsol : IWriteUserApiKeyConsol
    {
        private readonly IFormatUserTextForConsol _formatTextForConsol;
        private readonly IWriteConsol _writeConsol;

        public WriteUserApiKeyConsol(
            IFormatUserTextForConsol formatTextForConsol,
            IWriteConsol writeConsol)
        {
            _formatTextForConsol = formatTextForConsol;
            _writeConsol = writeConsol;
        }

        public void WriteConsol(List<Users> userlist)
        {
            string output = _formatTextForConsol.Format(userlist);
            _writeConsol.WriteLine(output);
        }
    }
}
