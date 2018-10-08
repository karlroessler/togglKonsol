using System;

namespace TogglKonsolDate
{
    public class ConvertTimeAreaThisMonth : IConvertTimeAreaThisMonth
    {
        public TimeDate ThisMonth(IDateTimeHelper _dateTimeHelper)
        {
            DateTime today = _dateTimeHelper.GetDateTimeNow();
            TimeDate ausgabe = new TimeDate
            {
                StartDate = new DateTime(today.Year, today.Month, 1)
            };
            ausgabe.EndDate = ausgabe.StartDate.AddMonths(1).AddDays(-1);
            return ausgabe;
        }
    }
}
