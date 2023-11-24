namespace Child
{
    public partial class Form1 : Form
    {
        private Child child;
        public Form1()
        {
            InitializeComponent();
            InitializeChildForm();
        }

        private void InitializeChildForm()
        {
            child = new Child(this);
            child.Show();
        }
        public void UpdateParentTextField(string text)
        {
            textBox1.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            child.UpdateChildTextField(textBox1.Text);
        }
    }
}