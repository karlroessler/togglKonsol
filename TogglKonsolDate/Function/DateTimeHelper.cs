using System;

namespace TogglKonsolDate
{
    public class DateTimeHelper : IDateTimeHelper
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Today;
        }
    }
}
