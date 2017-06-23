using System.Collections.Generic;

namespace Starling.Models.Payments
{
    public class RecurrenceRule
    {
        public int Count { get; set; }
        public List<string> Days { get; set; }
        public string Frequency { get; set; }
        public int Interval { get; set; }
        public int MonthDay { get; set; }
        public int MonthWeek { get; set; }
        public string StartDate { get; set; }
        public string UntilDate { get; set; }
        public string WeekStart { get; set; }
    }
}