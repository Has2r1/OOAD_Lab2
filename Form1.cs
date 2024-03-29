using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int curHours = 0, curMinutes = 0, curSeconds = 0;

        private void edSeconds_ValueChanged(object sender, EventArgs e)
        {
            curSeconds = (int)edSeconds.Value;
        }

        private void edMinutes_ValueChanged(object sender, EventArgs e)
        {
            curMinutes = (int)edMinutes.Value;
        }

        private void edHours_ValueChanged(object sender, EventArgs e)
        {
            curHours = (int)edHours.Value;
        }

        public interface IDigitalClock
        {
            void ShowTime();
        }

        public class AnalogClock
        {
            private int hourHandAngle;
            private int minuteHandAngle;
            private int secondHandAngle;

            private Label timeLabel;

            public AnalogClock(Label label)
            {
                timeLabel = label;
            }

            public void SetHands(int hourAngle, int minuteAngle, int secondAngle)
            {
                this.hourHandAngle = hourAngle;
                this.minuteHandAngle = minuteAngle;
                this.secondHandAngle = secondAngle;
            }

            public void ShowAnalogTime()
            {
                int hour, minute, second;
                hour = (int)Math.Round(hourHandAngle / 30.0); hour = (hour == 0) ? 12 : hour;
                minute = (int)Math.Round(minuteHandAngle / 30.0); minute = (minute == 0) ? 12 : minute;
                second = (int)Math.Round(secondHandAngle / 30.0); second = (second == 0) ? 12 : second;
                string Text = "Время: \n\n";
                Text += $"Analog clock: {hour:D2}:{minute:D2}:{second:D2}";
                this.timeLabel.Text = Text;
            }
        }

        public class AnalogClockAdapter : IDigitalClock
        {
            private readonly AnalogClock analogClock;

            public AnalogClockAdapter(AnalogClock analogClock)
            {
                this.analogClock = analogClock;
            }

            public void ShowTime()
            {
                analogClock.ShowAnalogTime();
            }
        }

        private void btShowTime_Click(object sender, EventArgs e)
        {
            AnalogClock analogClock = new AnalogClock(timeLabel);
            analogClock.SetHands(curHours, curMinutes, curSeconds);

            IDigitalClock adapter = new AnalogClockAdapter(analogClock);

            adapter.ShowTime();
        }

        


    }
}
