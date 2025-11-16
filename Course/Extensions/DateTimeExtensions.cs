using System.Globalization;

//namespace Course.Extensions (posso falar que é do namespace system para não precisar ficar importando desse namespace toda vez que eu quero usar, já que a datetime é o system
namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) //"estou extentendo o tipo DateTime"
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}
