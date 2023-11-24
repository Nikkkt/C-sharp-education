using Timer = System.Windows.Forms.Timer;

namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        private DateTime newYearsDay = new DateTime(DateTime.Now.Year + 1, 1, 1);
        private DateTime startTime;

        private Timer countdownTimer;
        private Timer elapsedTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimers();
        }

        private void InitializeTimers()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += UpdateCountdown;
            countdownTimer.Start();

            elapsedTimer = new Timer();
            elapsedTimer.Interval = 1;
            elapsedTimer.Tick += UpdateElapsedMilliseconds;
            startTime = DateTime.Now;
            elapsedTimer.Start();
        }

        private void UpdateCountdown(object sender, EventArgs e)
        {
            TimeSpan timeUntilNewYear = newYearsDay - DateTime.Now;
            labelNewYear.Text = $"New Year: {timeUntilNewYear.Days} days {timeUntilNewYear.Hours} hours {timeUntilNewYear.Minutes} minutes {timeUntilNewYear.Seconds} seconds";
        }

        private void UpdateElapsedMilliseconds(object sender, EventArgs e)
        {
            long millisecondsElapsed = (long)(DateTime.Now - startTime).TotalMilliseconds;
            Text = $"Elapsed Time: {millisecondsElapsed} milliseconds";
        }
    }
}