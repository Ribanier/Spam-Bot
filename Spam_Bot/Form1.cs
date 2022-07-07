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
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.Text);
                sayac = Convert.ToInt32(numericUpDown2.Value);
                timer1.Start();
                button1.Enabled = false;
                button2.Enabled = true;
                numericUpDown2.ReadOnly = true;
                richTextBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            numericUpDown2.Value = 5;
            numericUpDown2.ReadOnly = false;
            richTextBox1.ReadOnly = false;
            richTextBox1.Enabled = true;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
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
                    timer1.Interval = Convert.ToInt32(trackBar1.Value);
                    SendKeys.SendWait("^{V}");
                    SendKeys.SendWait("{ENTER}");

                }
                else
                {
                    timer1.Interval = Convert.ToInt32(trackBar1.Value);
                    SendKeys.SendWait("^{V}");
                }
            }

            else
            {
                sayac = sayac - 1;
                numericUpDown2.Value = sayac;
            }
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
                timer1.Interval = 100000;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
                timer1.Interval = Convert.ToInt32(trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            if(button1.Enabled==false)
            timer1.Start();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(this, "Double click to stop spamming");

        }
    }
}

