using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Extractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string URL = txtURL.Text;
            string HTML = getHTML(URL);

            List<string> forms = ExtractForm(HTML);

            foreach (var item in forms)
            {
                txtConsole.Text += "\n" + item;
                txtConsole.Text += "\n\n\n========================================================\n\n";
            }
        }

        private List<string> ExtractForm(String HTML) {
            List<string> forms = new List<string>();
            int startpoint = 0;

            while (startpoint < HTML.Length)
            {
                int start = HTML.IndexOf("<form");
                int end = HTML.IndexOf("</form>");
                if (start == end)
                {
                    break;
                }

                string data = HTML.Substring(start, (end - start + 7));

                forms.Add(data);

                HTML = HTML.Substring(end + 7, HTML.Length - (end + 7) - 1);
                startpoint = end + 7;
            }

            return forms;
        }

        private string getHTML(string URL)
        {
            string result;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = client.GetAsync(URL).Result)
                    {
                        using (HttpContent content = response.Content)
                        {
                            result = content.ReadAsStringAsync().Result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtConsole.Text += "\n\n" + ex.ToString();
                throw;
            }
            
            return result;
        }
    }
}
