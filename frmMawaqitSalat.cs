using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace روح_وريحان
{
    public partial class frmMawaqitSalat : Form
    {
        private TimeSpan remainingTime;
        private DateTime CurrentTime = DateTime.Now;

        private DateTime Lfajer = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 04, 33, 0);
        private DateTime Xoro9 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 05, 0);
        private DateTime Dohr = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 33, 0);
        private DateTime L3asser = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 12, 0);
        private DateTime Lmaghrib = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 01, 0);
        private DateTime L3ixa2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 31, 0);



        public frmMawaqitSalat()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void DateMiladiAndHijri()
        {
            //التاريخ الهجري

            CultureInfo arCulture = new CultureInfo("ar-SA");
            DateTime today = DateTime.Today;
            string formattedDate = today.ToString("dddd dd MMMM yyyy", arCulture);

            lbDateHijri.Text = formattedDate.ToString();

            //التاريخ الميلادي

            lbDateMiladi.Text = CurrentTime.ToString("dd dddd , MMMM, yyyy", new CultureInfo("ar-AE"));
        }

        private void frmMawaqitSalat_Load(object sender, EventArgs e)
        {
            //Time Only
            lbDateTime.Text = " ==> " + CurrentTime.ToString("tt HH:mm:ss");

            // Date
            DateMiladiAndHijri();

        }

        private void WhatIsNextSalat()
        {
            CurrentTime = DateTime.Now; // تحديث الوقت الحالي

            if (CurrentTime <= Lfajer)
            {
                lbNextAdan.Text = "الفجر";
                lbAdanTime.Text = "الفجر";

                remainingTime = Lfajer - CurrentTime;

                if (remainingTime.Seconds <= 0)
                {
                    timer1.Enabled = false;
                }

            }

            else if (CurrentTime <= Xoro9)
            {
                lbNextAdan.Text = "الشروق";
                lbAdanTime.Text = "الشروق";

                remainingTime = Xoro9 - CurrentTime;

                if (remainingTime.Seconds <= 0)
                {
                    timer1.Enabled = false;
                }
            }

            else if (CurrentTime <= Dohr)
            {
                lbNextAdan.Text = "الظهر";
                lbAdanTime.Text = "الظهر";

                remainingTime = Dohr - CurrentTime;

                if (remainingTime.Seconds <= 0)
                {
                    timer1.Enabled = false;
                }
            }

            else if (CurrentTime <= L3asser)
            {
                lbNextAdan.Text = "العصر";
                lbAdanTime.Text = "العصر";

                remainingTime = L3asser - CurrentTime;

                if (remainingTime.Seconds <= 0)
                {
                    timer1.Enabled = false;
                }
            }

            else if (CurrentTime <= Lmaghrib)
            {
                lbNextAdan.Text = "المغرب";
                lbAdanTime.Text = "المغرب";

                remainingTime = Lmaghrib - CurrentTime;

                if (remainingTime.Seconds <= 0)
                {
                    timer1.Enabled = false;
                }
            }

            else if (CurrentTime <= L3ixa2)
            {
                lbNextAdan.Text = "العشاء";
                lbAdanTime.Text = "العشاء";

                remainingTime = L3ixa2 - CurrentTime;

                if (remainingTime.Seconds <= 0)
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                lbNextAdan.Text = "الفجر";
                lbAdanTime.Text = "الفجر";

                DateTime nextFajr = Lfajer.AddDays(1); 
                remainingTime = nextFajr - CurrentTime;

                if (remainingTime.TotalSeconds <= 0)
                {
                    timer1.Enabled = false;
                }
            }
        }

        private void ShowNotify()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "حان وقت اذان صلاة " + lbAdanTime.Text;
            notifyIcon1.BalloonTipTitle = "اذان " + lbAdanTime.Text;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatIsNextSalat();

            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;

                ShowNotify();
                
            }
            

            lbTimerNextAdan.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }


    }
}
