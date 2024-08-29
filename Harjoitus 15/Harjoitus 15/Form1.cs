using System.Diagnostics;

namespace Harjoitus_15
{
    public partial class StopwatchForm : Form
    {
        private Stopwatch stopWatch;
        public StopwatchForm()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            timerLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}

