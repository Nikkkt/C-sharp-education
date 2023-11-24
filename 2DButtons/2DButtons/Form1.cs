namespace _2DButtons
{
    public partial class Form1 : Form
    {
        private int numRows = 10;
        private int numCols = 10;
        private int buttonWidth = 50;
        private int buttonHeight = 50;

        public Form1()
        {
            // InitializeComponent();

            Button[,] buttonArray = new Button[numRows, numCols];

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    var b = new Button();
                    b.BackColor = Color.FromArgb(new Random().Next(256), new Random().Next(256), new Random().Next(256));
                    b.Cursor = Cursors.Hand;
                    b.ForeColor = Color.FromArgb(0, 0, 0);
                    b.Width = buttonWidth;
                    b.Height = buttonHeight;
                    b.Location = new Point(col * buttonWidth, row * buttonHeight);
                    b.Click += OnClick;
                    b.Text = ((row * numCols) + col + 1).ToString();
                    b.Parent = this;
                    buttonArray[row, col] = b;
                }
            }
        }

        private void OnClick(object? sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Visible = false;
        }

    }
}