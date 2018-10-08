namespace TogglKonsol
{
    public class WriteHelpConsol : IWriteHelpConsol
    {
        private IFormatHelpTextForConsol _formatHelpTextForConsol;
        private IWriteConsol _writeConsol;

        public WriteHelpConsol(
            IFormatHelpTextForConsol formatHelpTextForConsol,
            IWriteConsol writeConsol)
        {
            _formatHelpTextForConsol = formatHelpTextForConsol;
            _writeConsol = writeConsol;
        }

        public void WriteHelp()
        {
            string output = _formatHelpTextForConsol.Format();
            _writeConsol.WriteLine(output);
        }
    }
}
