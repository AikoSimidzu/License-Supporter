using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseAdder
{
    public partial class Form1 : Form
    {
        // Paste your domain and panel password
        private static string Domain = "", Pass = "";        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Link for add user
            string Add = $"{Domain}/drawlicense.php?hwid={textBox1.Text}&p={Pass}&date={textBox2.Text}";
            // check text boxes
            if (textBox1.Text != null && textBox2.Text != null)
            {
                using (WebClient wc = new WebClient())
                {
                    try
                    {
                        if (!wc.DownloadString(Add).Contains("OK"))
                        {
                            MessageBox.Show("Incorrect password!");
                        }
                        else
                        {
                            MessageBox.Show("Added!");
                        }
                    }
                    catch { MessageBox.Show("Please try again!"); }
                }
            }
            else
            {
                MessageBox.Show("Please fill all lines!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Delete = $"{Domain}/drawlicense.php?hwid={textBox3.Text}&p={Pass}&del=1";
            if (textBox3.Text != null)
            {
                using (WebClient wc = new WebClient())
                {
                    try
                    {
                        if (!wc.DownloadString(Delete).Contains("OK"))
                        {
                            MessageBox.Show("Incorrect password!");
                        }
                        else
                        {
                            MessageBox.Show("Deleted!");
                        }
                    }
                    catch { MessageBox.Show("Please try again!"); }
                }
            }
            else
            {
                MessageBox.Show("Please fill all lines!");
            }
        }
    }
}
