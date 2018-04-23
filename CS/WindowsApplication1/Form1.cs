using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler;
using System.Globalization;


namespace HijriScheduler {
    public partial class Form1 : Form {
        HijriCalendarHelper hijriCalHelper;

        public Form1() {
            this.hijriCalHelper = new HijriCalendarHelper();
            InitializeComponent();
        }

        private void schedulerControl1_CustomDrawTimeCell(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e) {
            SchedulerViewCellBase cell = (SchedulerViewCellBase)e.ObjectInfo;
            bool isOddMonth = hijriCalHelper.IsOddHijriMonths(cell.Interval);
            Color color = isOddMonth ? Color.White : Color.LightSteelBlue;
            cell.Appearance.BackColor = color;
        }
        private void schedulerControl1_VisibleIntervalChanged(object sender, EventArgs e) {
            TimeInterval interval = schedulerControl1.ActiveView.GetVisibleIntervals().Interval;
            hijriCalHelper.FillHijriMonths(interval);
        }
        private void schedulerControl1_SelectionChanged(object sender, EventArgs e) {
            lblInterval.Text = hijriCalHelper.FormatTimeInterval(schedulerControl1.SelectedInterval);
        }
    }
}