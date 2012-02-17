using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using l33tPassGen;


namespace l33tWindow.App
{
    public partial class frmL33t : Form
    {
        public frmL33t()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            l33t oleet = new l33t();

            if (textBox1.Text == "")
            {
                richTextBox1.Text = oleet.ReplaceWord("CONVENTIONAL"); 
            }
            else 
            {
                richTextBox1.Text = oleet.ReplaceWord(textBox1.Text.ToString()); 
            }




        }
    }
}
