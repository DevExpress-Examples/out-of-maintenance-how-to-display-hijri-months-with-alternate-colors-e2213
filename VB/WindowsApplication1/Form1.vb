Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler
Imports System.Globalization


Namespace HijriScheduler
	Partial Public Class Form1
		Inherits Form
		Private hijriCalHelper As HijriCalendarHelper

		Public Sub New()
			Me.hijriCalHelper = New HijriCalendarHelper()
			InitializeComponent()
		End Sub

		Private Sub schedulerControl1_CustomDrawTimeCell(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl1.CustomDrawTimeCell
			Dim cell As SchedulerViewCellBase = CType(e.ObjectInfo, SchedulerViewCellBase)
			Dim isOddMonth As Boolean = hijriCalHelper.IsOddHijriMonths(cell.Interval)
			Dim color As Color
			If isOddMonth Then
				color = Color.White
			Else
				color = Color.LightSteelBlue
			End If
			cell.Appearance.BackColor = color
		End Sub
		Private Sub schedulerControl1_VisibleIntervalChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.VisibleIntervalChanged
			Dim interval As TimeInterval = schedulerControl1.ActiveView.GetVisibleIntervals().Interval
			hijriCalHelper.FillHijriMonths(interval)
		End Sub
		Private Sub schedulerControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.SelectionChanged
			lblInterval.Text = hijriCalHelper.FormatTimeInterval(schedulerControl1.SelectedInterval)
		End Sub
	End Class
End Namespace