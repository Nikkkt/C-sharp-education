using Timer = System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        private int maxRecord = 0;
        private int colorIndex = 0;
        private int previousColorIndex = 0;
        int transitionDuration = 5000;

        private Color[] colors = {
            Color.Black,
            Color.Red,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Pink,
            Color.White
        };

        private Timer colorTimer = new Timer();
        private Timer clickTimer = new Timer();

        private DateTime transitionStartTime;
        private Color startColor;
        private Color endColor;

        public Form1()
        {
            InitializeComponent();

            colorTimer.Interval = 10;
            colorTimer.Tick += ChangeBackgroundColor;

            clickTimer.Interval = 20000;
            clickTimer.Tick += EndGame;

            BackColor = colors[0];
            colorIndex = 0;

            colorTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            transitionStartTime = DateTime.Now;
            startColor = colors[0];
            endColor = colors[1];

            clickTimer.Start();
        }

        private void ChangeBackgroundColor(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            double elapsedMilliseconds = (now - transitionStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= transitionDuration)
            {
                startColor = colors[colorIndex];
                previousColorIndex = colorIndex;
                colorIndex = (colorIndex + 1) % colors.Length;
                endColor = colors[colorIndex];
                transitionStartTime = now;
            }

            float percentage = (float)(elapsedMilliseconds / transitionDuration);

            BackColor = TransitionColor(startColor, endColor, percentage);
        }

        private int Clamp(int value, int min, int max) { return Math.Max(min, Math.Min(value, max)); }
        private Color TransitionColor(Color startColor, Color endColor, float percentage)
        {
            int r = Clamp((int)(startColor.R + (endColor.R - startColor.R) * percentage), 0, 255);
            int g = Clamp((int)(startColor.G + (endColor.G - startColor.G) * percentage), 0, 255);
            int b = Clamp((int)(startColor.B + (endColor.B - startColor.B) * percentage), 0, 255);

            return Color.FromArgb(r, g, b);
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            clickCount++;
            clickButton.Text = $"Clicks: {clickCount}";
        }

        private void EndGame(object sender, EventArgs e)
        {
            colorTimer.Stop();
            clickTimer.Stop();

            if (clickCount > maxRecord) maxRecord = clickCount;
            MessageBox.Show($"You made {clickCount} clicks. The maximum record is {maxRecord}.");

            clickCount = 0;
            colorTimer.Start();
            clickTimer.Start();
        }
    }
}