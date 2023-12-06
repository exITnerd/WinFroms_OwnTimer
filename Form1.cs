using System;
using System.Threading;
using System.Windows.Forms;

namespace WinForms_OwnTimer
{
    public partial class OwnTimer : Form
    {
        private MyTimer myTimer;
        private int h, m, s, ms;
        private bool isRunning;

        public OwnTimer()
        {
            myTimer = new MyTimer(50);
            myTimer.TimeElapsed += TimeElapsed;
            InitializeComponent();
        }

        private void TimeElapsed(object sender, EventArgs e)
        {
            UpdateUI(() =>
            {
                ms += 50;
                if (ms == 1000) {
                    ms = 0;
                    s += 1;
                }
                else if (s == 60) {
                    s = 0;
                    m += 1;
                }
                else if (m == 60) {
                    m = 0;
                    h += 1;
                }
                else if (h == 24) {
                    myTimer.Stop();
                    MessageBox.Show("Are you there? Whole day elapsed, stopping timer!");
                    this.Close();
                }

                labelTime.Text = $"{h:00}:{m:00}:{s:00}:{ms:000}";
            });
        }

        private void OnError(object sender, EventArgs e)
        {
            MessageBox.Show("An error occurred during timer execution.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void shapyButtonStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                myTimer.Start();
                isRunning = true;
            }
        }

        private void shapyButtonStop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                myTimer.Stop();
                isRunning = false;
            }
        }

        private void shapyButtonReset_Click(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            UpdateUI(() => labelTime.Text = "00:00:00:000");
        }

        private void UpdateUI(Action action)
        {
            if (InvokeRequired)
            {
                BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }
    }
}
