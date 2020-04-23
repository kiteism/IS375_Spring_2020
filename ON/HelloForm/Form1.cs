using System;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Button click event
        private void Button1_Click(object sender, EventArgs e)
        {
            //Show message in label
            label1.Text = "Hello, I am a CS student!";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
