using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;


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
                richTextBox1.Value = oleet.ReplaceWord(ReadTextFile());
            }
            else
            {
                richTextBox1.Value = oleet.ReplaceWord(textBox1.Text.ToString());
            }
        }

        
        string ReadTextFile()
        {

            using (StreamReader streamReader = File.OpenText(Server.MapPath("~") + @"\12letterwords.txt"))
            {
                    int count = 0;
                    List<string> wordlist = new List<string>();

                    string inputString;

                    while ((inputString = streamReader.ReadLine()) != null)
                    {
                        wordlist.Add(inputString);
                        inputString = streamReader.ReadLine();
                        count++;
                    }

                    Random random = new Random();
                    int rand = random.Next(count);


                    return wordlist[rand];
            }

            

        }


    }
}