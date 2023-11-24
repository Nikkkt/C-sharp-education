using Timer = System.Windows.Forms.Timer;

namespace EscapingButton
{
    public partial class Form1 : Form
    {
        private Button escapingButton;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            InitializeTimer();
        }

        private void InitializeUI()
        {
            Text = "Escaping Button";
            Size = new Size(400, 300);

            escapingButton = new Button
            {
                Text = "Click me!",
                Size = new Size(80, 30),
                Location = new Point(50, 50),
                BackColor = Color.LightBlue
            };

            escapingButton.MouseHover += (sender, e) => StartMoving();
            escapingButton.MouseLeave += (sender, e) => StopMoving();

            Controls.Add(escapingButton);
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += (sender, e) => MoveButton();
        }

        private void StartMoving() { if (!timer.Enabled) timer.Start(); }

        private void StopMoving() { if (timer.Enabled) timer.Stop(); }

        private void MoveButton()
        {
            int newX = escapingButton.Location.X + GetRandomOffset();
            int newY = escapingButton.Location.Y + GetRandomOffset();

            newX = Math.Max(0, Math.Min(ClientSize.Width - escapingButton.Width, newX));
            newY = Math.Max(0, Math.Min(ClientSize.Height - escapingButton.Height, newY));

            escapingButton.Location = new Point(newX, newY);
        }

        private int GetRandomOffset()
        {
            Random random = new Random();
            return random.Next(-100, 100);
        }
    }
}