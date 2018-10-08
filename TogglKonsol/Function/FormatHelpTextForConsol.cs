namespace TogglKonsol
{
    public class FormatHelpTextForConsol : IFormatHelpTextForConsol
    {
        public string Format()
        {
            string ausgabe = null;
            ausgabe = ausgabe + "-help || -h Hilfe zum Programm \n\r";
            ausgabe = ausgabe + "-entries || -e Um alle Einträge von allen User Anzuzeigen \n\r";
            ausgabe = ausgabe + "-startdate:DD-MM-YYYY || -sd:DD-MM-YYYY Start Datum für entries \n\r";
            ausgabe = ausgabe + "-enddate:DD-MM-YYYY || -ed:DD-MM-YYYY End Datum für entries \n\r";
            ausgabe = ausgabe + "-timearea:Area || -ta:Area Area sind Today,Yesterday,ThisWeek,LastWeek,ThisMonth,LastMonth \n\r";
            ausgabe = ausgabe + "-write:location || -w:location 'Zum schreiben der daten in csv format. Falls keine Location angeben wurde ist es standart auf C:/CSV/ \n\r";
            return ausgabe;
        }
    }
}
