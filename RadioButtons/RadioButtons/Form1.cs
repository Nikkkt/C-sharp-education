namespace RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e) { BackColor = Color.FromName((sender as RadioButton).Text); }
    }
}