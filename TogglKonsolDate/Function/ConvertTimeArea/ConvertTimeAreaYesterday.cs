using System;

namespace TogglKonsolDate
{
    public class ConvertTimeAreaYesterday : IConvertTimeAreaYesterday
    {

        public TimeDate Yesterday(IDateTimeHelper _dateTimeHelper)
        {
            DateTime today = _dateTimeHelper.GetDateTimeNow();
            return new TimeDate
            {
                StartDate = today.AddDays(-1),
                EndDate = today
            };
        }
    }
}
