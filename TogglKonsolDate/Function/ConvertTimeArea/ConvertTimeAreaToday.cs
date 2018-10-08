using System;
namespace TogglKonsolDate
{
    public class ConvertTimeAreaToday : IConvertTimeAreaToday
    {
        public TimeDate Today(IDateTimeHelper _dateTimeHelper)
        {
            DateTime today = _dateTimeHelper.GetDateTimeNow();
            return new TimeDate
            {
                StartDate = today,
                EndDate = today.AddDays(1)
            };
        }
    }
}
