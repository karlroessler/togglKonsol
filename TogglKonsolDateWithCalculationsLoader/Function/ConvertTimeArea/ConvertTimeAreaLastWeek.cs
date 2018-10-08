using System;
using System.Collections.Generic;

namespace TogglKonsolDateWithCalculationsLoader
{
    public class ConvertTimeAreaLastWeek : IConvertTimeAreaLastWeek
    {
        public TimeDate LastWeek(IDateTimeHelper _dateTimeHelper)
        {
            DateTime today = _dateTimeHelper.GetDateTimeNow();
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            return new TimeDate
            {
                StartDate = today.AddDays(daysUntilMonday - 16),
                EndDate = today.AddDays(daysUntilMonday - 9)
            };

        }
    }
}
