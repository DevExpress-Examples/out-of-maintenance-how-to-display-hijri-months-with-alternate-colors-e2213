<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128634602/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2213)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [HijriCalendar.cs](./CS/WindowsApplication1/HijriCalendar.cs) (VB: [HijriCalendar.vb](./VB/WindowsApplication1/HijriCalendar.vb))
<!-- default file list end -->
# How to display Hijri months with alternate colors


<p>This example illustrates how you can display months of the Hijri Calendar in the XtraScheduler view. An alternate coloring is used to clearly distinguish one month from another.</p><p>To perform a conversion between Gregorian and Hijri calendars, methods of the <strong>System.Globalization.HijriCalendar</strong> class are used. A custom class <strong>HijriCalendarHelper </strong>is used to break the time interval displayed in the Scheduler's View into time intervals which corresponds to Hijri months. The  HijriCalendarHelper class implements the <strong>IsOddHijriMonths(TimeInterval timeInterval)</strong> method indicating whether the number of the Hijri month (as to the specified time interval) is odd or even. <br />
The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_CustomDrawTimeCelltopic">CustomDrawTimeCell event</a> is handled to color time cells according to the value returned by the IsOddHijriMonths function. Odd months are colored White, even months are colored LightSteelBlue.</p>

<br/>


