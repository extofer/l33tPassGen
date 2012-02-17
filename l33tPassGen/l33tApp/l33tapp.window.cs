using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using l33tPassGen;


namespace l33tApp
{
    public partial class l33tapp : Form
    {
        public l33tapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l33t oleet = new l33t();

            

            listBox1.Items.Add(oleet.ReplaceWord("CONVENTIONAL"));


        }
    }
}
