using System;

namespace TogglKonsolDate
{
    public class ConvertTimeAreaLastMonth : IConvertTimeAreaLastMonth
    {
        public TimeDate LastMonth(IDateTimeHelper _dateTimeHelper)
        {
            DateTime today = _dateTimeHelper.GetDateTimeNow();
            var date = new DateTime(today.Year, today.Month, 1);
            return new TimeDate
            {
                StartDate = date.AddMonths(-1),
                EndDate = date.AddDays(-1)
            };
        }
    }
}
