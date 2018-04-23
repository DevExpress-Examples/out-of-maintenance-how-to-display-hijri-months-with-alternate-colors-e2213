Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler
Imports System.Globalization
Imports DevExpress.Utils

Namespace HijriScheduler

	Public Class HijriCalendarHelper
		Private hijriCal As HijriCalendar
		Private monthIntervals As TimeIntervalCollection

		Public Sub New()
			Me.hijriCal = New HijriCalendar()
			Me.monthIntervals = New TimeIntervalCollection()
			Me.monthIntervals.UniquenessProviderType = DXCollectionUniquenessProviderType.MaximizePerformance

		End Sub
		Public ReadOnly Property HijriMonths() As TimeIntervalCollection
			Get
				Return monthIntervals
			End Get
		End Property
		Public ReadOnly Property HijriCalendar() As HijriCalendar
			Get
				Return hijriCal
			End Get
		End Property

		Public Sub FillHijriMonths(ByVal visibleInterval As TimeInterval)
			Dim start As DateTime = visibleInterval.Start
			Dim visibleEnd As DateTime = visibleInterval.End

			Dim currentMonthInterval As TimeInterval = CreateCurrentMonthInterval(start)
			HijriMonths.BeginUpdate()
			Try
				HijriMonths.Clear()
				HijriMonths.Add(currentMonthInterval)

				start = currentMonthInterval.End
				Do While True
					If start >= visibleEnd Then
						Exit Do
					End If
					Dim [end] As DateTime = HijriCalendar.AddMonths(start, 1)
					If [end] > visibleEnd Then
						[end] = visibleEnd
					End If

					Dim interval As TimeInterval = New TimeInterval(start, [end])
					HijriMonths.Add(interval)
					start = interval.End
				Loop
			Finally
				HijriMonths.EndUpdate()
			End Try
		End Sub
		Public Function CreateCurrentMonthInterval(ByVal start As DateTime) As TimeInterval
			Dim year As Integer = HijriCalendar.GetYear(start)
			Dim month As Integer = HijriCalendar.GetMonth(start)

			Dim dayOfMonth As Integer = HijriCalendar.GetDayOfMonth(start)
			Dim daysInMonth As Integer = HijriCalendar.GetDaysInMonth(year, month)


			Dim remainder As Integer = daysInMonth - dayOfMonth
			Dim lastDayOfMonth As DateTime = HijriCalendar.AddDays(start, remainder)

			Return New TimeInterval(start, lastDayOfMonth)

		End Function
		Public Function IsOddHijriMonths(ByVal timeInterval As TimeInterval) As Boolean
            For Each ti As TimeInterval In HijriMonths
                If ti.IntersectsWith(timeInterval) Then
                    If HijriMonths.IndexOf(ti) Mod 2 <> 0 Then
                        Return True
                    End If
                End If
            Next

            Return False
        End Function

        Private Function FormatDateTime(ByVal [date] As DateTime) As String
            Return String.Format("Era:{0} Year:{1} Month:{2} DayOfMonth:{3}", HijriCalendar.GetEra([date]), HijriCalendar.GetYear([date]), HijriCalendar.GetMonth([date]), HijriCalendar.GetDayOfMonth([date]))

        End Function
		Public Function FormatTimeInterval(ByVal interval As TimeInterval) As String
			Return String.Format("({0}) - ({1})", FormatDateTime(interval.Start), FormatDateTime(interval.End.AddTicks(1)))
		End Function
	End Class
End Namespace
