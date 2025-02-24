using System.Data;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rira_Task.Infrastructure.DateUtility
{
    public static class ConvertPersianDate
    {
        public static string ToPersianDate(this DateTime date)
        {
            System.Globalization.PersianCalendar calendar = new System.Globalization.PersianCalendar();
            return $"{calendar.GetYear(date)}/{calendar.GetMonth(date).ToString().PadLeft(2, '0')}/{calendar.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";
        }

        public static DateTime ToGlobalDate(string persianDate)
        {
            System.Globalization.PersianCalendar calendar = new System.Globalization.PersianCalendar();
            var _perianYear = Int32.Parse(persianDate.Substring(0, 4));
            var _perianMonth = Int32.Parse(persianDate.Substring(5, 2));
            var _perianDaye = Int32.Parse(persianDate.Substring(8, 2));
            return new DateTime(_perianYear, _perianMonth, _perianDaye,calendar);   
        }
    }
}