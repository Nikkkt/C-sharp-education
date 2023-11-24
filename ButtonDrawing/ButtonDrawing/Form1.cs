namespace ButtonDrawing
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private List<Button> buttons = new List<Button>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            drawingPanel.MouseDown += DrawingPanel_MouseDown;
            drawingPanel.MouseMove += DrawingPanel_MouseMove;
            drawingPanel.MouseUp += DrawingPanel_MouseUp;
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e) { isDrawing = true; startPoint = e.Location; }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                int width = e.X - startPoint.X;
                int height = e.Y - startPoint.Y;

                Button button = new Button
                {
                    Location = new Point(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y)),
                    Size = new Size(Math.Abs(width), Math.Abs(height)),
                    BackColor = GetRandomColor(),
                    Text = (buttons.Count + 1).ToString()
                };

                UpdateButtonPositions(button);
            }
        }

        private void UpdateButtonPositions(Button newButton)
        {
            drawingPanel.Controls.Clear();
            foreach (Button existingButton in buttons) drawingPanel.Controls.Add(existingButton);
            drawingPanel.Controls.Add(newButton);
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Button newButton = new Button
                {
                    Location = new Point(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y)),
                    Size = new Size(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y)),
                    BackColor = GetRandomColor(),
                    Text = (buttons.Count + 1).ToString()
                };
                buttons.Add(newButton);
                UpdateButtonPositions(newButton);
            }
        }

        private Color GetRandomColor() { return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); }
    }
}