using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraScheduler;
using System.Globalization;
using DevExpress.Utils;

namespace HijriScheduler {

    public class HijriCalendarHelper {
        HijriCalendar hijriCal;
        TimeIntervalCollection monthIntervals;
        
        public HijriCalendarHelper() {
            this.hijriCal = new HijriCalendar();
            this.monthIntervals = new TimeIntervalCollection();
            this.monthIntervals.UniquenessProviderType = DXCollectionUniquenessProviderType.MaximizePerformance;

        }
        public TimeIntervalCollection HijriMonths { get { return monthIntervals; } }
        public HijriCalendar HijriCalendar { get { return hijriCal; } }

        public void FillHijriMonths(TimeInterval visibleInterval) {
            DateTime start = visibleInterval.Start;
            DateTime visibleEnd = visibleInterval.End;

            TimeInterval currentMonthInterval = CreateCurrentMonthInterval(start);
            HijriMonths.BeginUpdate();
            try {
                HijriMonths.Clear();
                HijriMonths.Add(currentMonthInterval);
            
                start = currentMonthInterval.End;
                for (;;) {
                    if (start >= visibleEnd)
                        break;
                    DateTime end = HijriCalendar.AddMonths(start, 1);
                    if (end > visibleEnd)
                        end = visibleEnd;

                    TimeInterval interval = new TimeInterval(start, end);
                    HijriMonths.Add(interval);
                    start = interval.End;
                }
            } finally {
                HijriMonths.EndUpdate();
            }
        }
        public TimeInterval CreateCurrentMonthInterval(DateTime start) {
            int year = HijriCalendar.GetYear(start);
            int month = HijriCalendar.GetMonth(start);

            int dayOfMonth = HijriCalendar.GetDayOfMonth(start);
            int daysInMonth = HijriCalendar.GetDaysInMonth(year, month);


            int remainder = daysInMonth - dayOfMonth;
            DateTime lastDayOfMonth = HijriCalendar.AddDays(start, remainder);

            return new TimeInterval(start, lastDayOfMonth);
            
        }
        public bool IsOddHijriMonths(TimeInterval timeInterval) {
            Predicate<TimeInterval> intervalMatch = delegate(TimeInterval interval) {
                return interval.IntersectsWith(timeInterval);
            };
            TimeInterval monthInterval = HijriMonths.Find(intervalMatch);
            if (monthInterval == null)
                return false;
            
           if (HijriMonths.IndexOf(monthInterval) % 2 != 0) 
                return true;
            
            return false;
        }


        private string FormatDateTime(DateTime date) {
            return String.Format("Era:{0} Year:{1} Month:{2} DayOfMonth:{3}", 
                HijriCalendar.GetEra(date),
                HijriCalendar.GetYear(date),
                HijriCalendar.GetMonth(date),
                HijriCalendar.GetDayOfMonth(date));
            
        }
        public string FormatTimeInterval(TimeInterval interval) {
            return String.Format("({0}) - ({1})", FormatDateTime(interval.Start), FormatDateTime(interval.End.AddTicks(1)));
        }
    }
}
