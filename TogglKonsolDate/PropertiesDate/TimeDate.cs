using System;

namespace TogglKonsolDate
{
    public class TimeDate
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override bool Equals(object value)
        {
            if (value == null)
            {
                return false;
            }

            TimeDate date = value as TimeDate;

            return (date != null)
                && (StartDate == date.StartDate)
                && (EndDate == date.EndDate);
        }
    }
}
