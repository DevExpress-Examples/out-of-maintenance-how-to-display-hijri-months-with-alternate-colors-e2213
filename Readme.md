# How to display Hijri months with alternate colors


<p>This example illustrates how you can display months of the Hijri Calendar in the XtraScheduler view. An alternate coloring is used to clearly distinguish one month from another.</p><p>To perform a conversion between Gregorian and Hijri calendars, methods of the <strong>System.Globalization.HijriCalendar</strong> class are used. A custom class <strong>HijriCalendarHelper </strong>is used to break the time interval displayed in the Scheduler's View into time intervals which corresponds to Hijri months. The  HijriCalendarHelper class implements the <strong>IsOddHijriMonths(TimeInterval timeInterval)</strong> method indicating whether the number of the Hijri month (as to the specified time interval) is odd or even. <br />
The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_CustomDrawTimeCelltopic">CustomDrawTimeCell event</a> is handled to color time cells according to the value returned by the IsOddHijriMonths function. Odd months are colored White, even months are colored LightSteelBlue.</p>

<br/>


