namespace WinFormsIntro
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            btnClick.Text = $"Count of clicks: {count}";
        }
    }
}