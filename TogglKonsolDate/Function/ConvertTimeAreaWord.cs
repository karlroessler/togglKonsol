using System;
using System.Reflection;

namespace TogglKonsolDate
{
    public class ConvertTimeAreaWord : IConvertTimeAreaWord
    {

        private readonly IDateTimeHelper _dateTimeHelper;

        public ConvertTimeAreaWord(IDateTimeHelper dateTimeHelper)
        {
            _dateTimeHelper = dateTimeHelper;
        }

        public TimeDate ConvertTimeAreaWordToTimeArea(string timeAreaWord)
        {
            TimeDate timeArea = null;

            try
            {
                Type dateType = Type.GetType("TogglKonsolDate.ConvertTimeArea" + timeAreaWord);
                ConstructorInfo dateConstructor = dateType.GetConstructor(Type.EmptyTypes);
                object dateClassObject = dateConstructor.Invoke(parameters: new object[] { });
                MethodInfo dateMethod = dateType.GetMethod(timeAreaWord);
                timeArea = (TimeDate)dateMethod.Invoke(dateClassObject, new object[] { _dateTimeHelper });
            }
            catch
            {
                timeArea = null;
            }

            return timeArea;
        }
    }
}
