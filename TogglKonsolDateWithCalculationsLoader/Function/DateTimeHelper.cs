using System;

namespace TogglKonsolDateWithCalculationsLoader
{
    public class DateTimeHelper : IDateTimeHelper
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Today;
        }
    }
}
