using System.Windows.Forms;

namespace MessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            MouseWheel += (sender, e) => { MessageBox.Show(e.Delta > 0 ? "Up" : e.Delta < 0 ? "Down" : ""); };
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int move = 10;

            switch (keyData)
            {
                case Keys.Left:
                    button1.Left -= move;
                    return true;
                case Keys.Right:
                    button1.Left += move;
                    return true;
                case Keys.Up:
                    button1.Top -= move;
                    return true;
                case Keys.Down:
                    button1.Top += move;
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}