using CalendarConsole.Demo;
using System;

namespace CalendarConsole
{
    class Program
    {
        public static string credentialsPath = "credentials.json";
        static void Main(string[] args)
        {
            GoogleCalendar gCalendar = new GoogleCalendar(credentialsPath);

            gCalendar.ShowUpCommingEvent();
            gCalendar.CreateEvent();
        }
    }
}
