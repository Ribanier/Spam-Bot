using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spam_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {//MessageBox.Show(richTextBox1.Lines[2]);
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Enter the text to be spammed");
                richTextBox1.Focus();
            }
            else
            {
                try
                {
                    sayac = int.Parse(textBox1.Text);
                    timer1.Interval = 1000;
                    timer1.Start();
                    button1.Enabled = false;
                    button2.Enabled = true;

                    //   satirsayisi = richTextBox1.Lines.Length;
                }
                catch
                {
                    MessageBox.Show("Do not enter letters, spaces or special characters in the countdown");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Stop();
            textBox1.Text = "5";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region
            /* sayac++;

            if (sayac > 5)
            {
                //yapistirkopyala();
                      if (satirsayac != satirsayisi)
                     Clipboard.SetText(richTextBox1.Lines[satirsayac]);
                 SendKeys.SendWait("^{V}");
                satirsayac++;
            }
        } */
            #endregion
            if (sayac == 0)
            {
                if (checkBox1.Checked)
                {
                    Clipboard.SetText(richTextBox1.Text);
                    SendKeys.SendWait("^{V}");
                    SendKeys.SendWait("{ENTER}");

                }
                else
                {
                    Clipboard.SetText(richTextBox1.Text);
                    SendKeys.SendWait("^{V}");
                }
            }

            else
            {
                sayac = sayac - 1;
                textBox1.Text = sayac.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Close();
        }
    }
}
