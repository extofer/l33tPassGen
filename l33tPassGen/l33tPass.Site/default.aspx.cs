using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using l33tPassGen;

namespace l33tPass.Site
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            l33t oleet = new l33t();

            if (textBox1.Text == "")
            {
                richTextBox1.Value = oleet.ReplaceWord("CONVENTIONAL");
            }
            else
            {
                richTextBox1.Value = oleet.ReplaceWord(textBox1.Text.ToString());
            }
        }


    }
}