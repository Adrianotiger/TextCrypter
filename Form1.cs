using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardTrans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Height = Width;
            groupBox2.Top = Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool bActive = checkBox1.Checked;
            groupBox1.Enabled = !bActive;
            textBox1.Enabled = bActive;
            Program.ActivateCrypting = bActive;
            if (radioButton1.Checked) Program.Crypting = Program.CryptingMode.Bubble;
            else if (radioButton2.Checked) Program.Crypting = Program.CryptingMode.Wide;
            else if (radioButton3.Checked) Program.Crypting = Program.CryptingMode.Square;
            else if (radioButton4.Checked) Program.Crypting = Program.CryptingMode.FlipX;
            else if (radioButton5.Checked) Program.Crypting = Program.CryptingMode.Random;
            else if (radioButton6.Checked) Program.Crypting = Program.CryptingMode.FlipY;
            else if (radioButton7.Checked) Program.Crypting = Program.CryptingMode.Superior;
            else if (radioButton8.Checked) Program.Crypting = Program.CryptingMode.Bold;
            else if (radioButton9.Checked) Program.Crypting = Program.CryptingMode.Italic;
            else if (radioButton10.Checked) Program.Crypting = Program.CryptingMode.Bracket;
            else if (radioButton11.Checked) Program.Crypting = Program.CryptingMode.Fraktur;
            else if (radioButton12.Checked) Program.Crypting = Program.CryptingMode.Mathematical;

            if (bActive) textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Top == groupBox1.Top)
            {
                groupBox2.Top = Height;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Top = groupBox1.Top;
                groupBox2.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }
<<<<<<< HEAD

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Program.ActivateCrypting)
            {
                MessageBox.Show("Please activate crypting before using this function.");
            }
            else
            { 
                String s;
                String s2;
                try
                {
                    s = System.Windows.Forms.Clipboard.GetText(TextDataFormat.UnicodeText);
                    s2 = Program.ConvertString(s);
                    System.Windows.Forms.Clipboard.SetText(s2);
                    MessageBox.Show(s + "\r\n------------------------------------\r\n - string converted successfully to: - \r\n------------------------------------\r\n" + s2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
=======
>>>>>>> parent of 9d9617e... Ignore CTRL
    }
}
