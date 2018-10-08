using System;

namespace TogglKonsol
{
    public class ReadCommandLineArguments: IReadCommandLineArguments
    {

        private readonly ICheckDateExist _checkDateExist;

        public ReadCommandLineArguments(
            ICheckDateExist checkDateExist)
        {
            _checkDateExist = checkDateExist;
        }

        public bool ReadEntries(string[] args)
        {
            bool entries = false;

            foreach (string command in args)
            {
                if (command == "-e" || command == "-entries")
                {
                    entries = true;
                }
            }

            return entries;
        }

        public bool ReadHelp(string[] args)
        {
            bool help = false;

            foreach (string command in args)
            {
                if (command == "-h" || command == "-help")
                {
                    help = true;
                }
            }

            return help;
        }

        public string ReadWrite(string[] args)
        {
            SplitText splitText = new SplitText();
            string write = null;

            foreach (string command in args)
            {
                if (command.StartsWith("-w") || command.StartsWith("-write"))
                {
                    write = splitText.SplintOnFirst(command);

                    if (write == null)
                    {
                        write = @"C:\CSV\" + DateTime.Now + ".csv";
                    }
                }
            }

            return write;
        }

        public DateTime ReadStartDate(string[] args)
        {
            SplitText splitText = new SplitText();
            string startDateString = null;
            DateTime startDate = new DateTime();

            foreach (string command in args)
            {
                
                if (command.StartsWith("-sd") || command.StartsWith("-startdate"))
                {
                    startDateString = splitText.SplintOnFirst(command);
                    if (_checkDateExist.IsDateValid(startDateString) == false)
                    {
                        startDateString = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                    }
                    startDate = DateTime.ParseExact(startDateString, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            return startDate;
        }

        public DateTime ReadEndDate(string[] args)
        {
            SplitText splitText = new SplitText();
            string endDateString = null;
            DateTime endDate = new DateTime();

            foreach (string command in args)
            {
                if (command.StartsWith("-ed") || command.StartsWith("-enddate"))
                {
                    endDateString = splitText.SplintOnFirst(command);
                    if (_checkDateExist.IsDateValid(endDateString) == false)
                    {
                        endDateString = DateTime.Today.ToString("yyyy-MM-dd");
                    }
                    endDate = DateTime.ParseExact(endDateString, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            return endDate;
        }

        public string ReadTimeArea(string[] args)
        {
            SplitText splitText = new SplitText();
            string timeArea = null;

            foreach (string command in args)
            {
                if (command.StartsWith("-ta") || command.StartsWith("-timearea"))
                {
                    timeArea = splitText.SplintOnFirst(command);
                }
            }

            return timeArea;
        }
    }
}
