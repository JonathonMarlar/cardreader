using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // get the text
                String lnum = cardInputBox.Text;
                DateTime scan_time = DateTime.Now;
                using (StreamWriter sw = File.AppendText(@"sign_in_form.csv"))
                {
                    sw.WriteLine(lnum + "," + scan_time.ToString("MM/dd/yyyy") + "," + scan_time.ToString("hh:mm:ss tt"));
                }
                cardInputBox.Text = "";
                okayLabel.Visible = true;
                instructionsLabel.Visible = false;
                Timer t = new Timer();
                t.Interval = 2000;
                t.Tick += (s, n) =>
                {
                    okayLabel.Visible = false;
                    instructionsLabel.Visible = true;
                    t.Stop();
                };
                t.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void okayLabel_Click(object sender, EventArgs e)
        {

        }

        private void cardInstructLabel_Click(object sender, EventArgs e)
        {

        }

        private void howToSwipePic_Click(object sender, EventArgs e)
        {

        }
    }
}
