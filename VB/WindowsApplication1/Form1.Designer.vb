Imports Microsoft.VisualBasic
Imports System
Namespace HijriScheduler
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler4 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			Me.pnlInterval = New System.Windows.Forms.Panel()
			Me.lblInterval = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlInterval.SuspendLayout()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 41)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(572, 443)
			Me.schedulerControl1.Start = New System.DateTime(2010, 4, 19, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.Enabled = False
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler3)
			Me.schedulerControl1.Views.WeekView.Enabled = False
			Me.schedulerControl1.Views.WorkWeekView.Enabled = False
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
'			Me.schedulerControl1.CustomDrawTimeCell += New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(Me.schedulerControl1_CustomDrawTimeCell);
'			Me.schedulerControl1.SelectionChanged += New System.EventHandler(Me.schedulerControl1_SelectionChanged);
'			Me.schedulerControl1.VisibleIntervalChanged += New System.EventHandler(Me.schedulerControl1_VisibleIntervalChanged);
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
			Me.dateNavigator1.HotDate = Nothing
			Me.dateNavigator1.Location = New System.Drawing.Point(572, 0)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
			Me.dateNavigator1.Size = New System.Drawing.Size(179, 484)
			Me.dateNavigator1.TabIndex = 1
			' 
			' pnlInterval
			' 
			Me.pnlInterval.Controls.Add(Me.label1)
			Me.pnlInterval.Controls.Add(Me.lblInterval)
			Me.pnlInterval.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlInterval.Location = New System.Drawing.Point(0, 0)
			Me.pnlInterval.Name = "pnlInterval"
			Me.pnlInterval.Size = New System.Drawing.Size(572, 41)
			Me.pnlInterval.TabIndex = 2
			' 
			' lblInterval
			' 
			Me.lblInterval.AutoSize = True
			Me.lblInterval.Location = New System.Drawing.Point(107, 14)
			Me.lblInterval.Name = "lblInterval"
			Me.lblInterval.Size = New System.Drawing.Size(35, 13)
			Me.lblInterval.TabIndex = 0
			Me.lblInterval.Text = "label1"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 14)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(89, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Selected interval:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(751, 484)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.pnlInterval)
			Me.Controls.Add(Me.dateNavigator1)
			Me.Name = "Form1"
			Me.Text = "Hijri Calendar Example"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlInterval.ResumeLayout(False)
			Me.pnlInterval.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
		Private pnlInterval As System.Windows.Forms.Panel
		Private lblInterval As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

