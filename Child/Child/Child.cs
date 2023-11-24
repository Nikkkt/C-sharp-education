using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child
{
    public partial class Child : Form
    {
        private Form1 parent;

        public Child(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void UpdateChildTextField(string text)
        {
            textBox2.Text = text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            parent.UpdateParentTextField(textBox2.Text);
        }
    }
}
