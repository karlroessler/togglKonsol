using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglKonsolDateWithCalculationsLoader.PropertiesDate
{
    class DateTimeRange
    {
        public abstract class DateTimeRangeCalculatorBase
        {
            //public IDateTimeProvider DateTimeProvider { protected get; set; }

            public abstract string Name { get; }

            public abstract bool DoesMatchInput(string input);

            public abstract DateTimeRange CalculateFromInput(string input = "");

            //protected DateTime Today => DateTimeProvider.Today;

            protected bool EqualsLowerMatch(string input, string match)
                => input?.ToLower() == match?.ToLower();
        }
    }
}
