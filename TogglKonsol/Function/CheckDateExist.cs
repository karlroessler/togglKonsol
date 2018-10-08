using System;

namespace TogglKonsol
{
    public class CheckDateExist : ICheckDateExist
    {
        public bool IsDateValid(string date)
        {
            return DateTime.TryParse((date), out DateTime dt);
        }
    }
}
