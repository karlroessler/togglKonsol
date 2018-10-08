using System;

namespace TogglKonsolDate
{
    public class ConvertTimeAreaThisWeek : IConvertTimeAreaThisWeek
    {
        public TimeDate ThisWeek(IDateTimeHelper _dateTimeHelper)
        {
            DateTime today = _dateTimeHelper.GetDateTimeNow();
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            return new TimeDate
            {
                StartDate = today.AddDays(daysUntilSunday - 7),
                EndDate = today.AddDays(daysUntilSunday)
            };
        }
    }
}
