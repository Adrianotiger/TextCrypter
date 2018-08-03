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

            Height = Width - 50;
            groupBox2.Top = Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (groupBox2.Top == groupBox1.Top)
            {
                groupBox2.Top = Height;
                e.Cancel = true;
            }
        }

        private void CheckBoxCrypt_CheckedChanged(object sender, EventArgs e)
        {
            bool bActive = checkBoxCrypt.Checked;
            groupBox1.Enabled = !bActive;
            textBox1.Enabled = bActive;
            Program.ActivateCrypting = bActive;
            if (radioButton_bubble.Checked) Program.Crypting = Program.CryptingMode.Bubble;
            else if (radioButton_wide.Checked) Program.Crypting = Program.CryptingMode.Wide;
            else if (radioButton_squares.Checked) Program.Crypting = Program.CryptingMode.Square;
            else if (radioButton_flipX.Checked) Program.Crypting = Program.CryptingMode.FlipX;
            else if (radioButton_random.Checked) Program.Crypting = Program.CryptingMode.Random;
            else if (radioButton_flipY.Checked) Program.Crypting = Program.CryptingMode.FlipY;
            else if (radioButton_superior.Checked) Program.Crypting = Program.CryptingMode.Superior;
            else if (radioButton_bold.Checked) Program.Crypting = Program.CryptingMode.Bold;
            else if (radioButton_italic.Checked) Program.Crypting = Program.CryptingMode.Italic;
            else if (radioButton_bracket.Checked) Program.Crypting = Program.CryptingMode.Bracket;
            else if (radioButton_fraktur.Checked) Program.Crypting = Program.CryptingMode.Fraktur;
            else if (radioButton_mathematical.Checked) Program.Crypting = Program.CryptingMode.Mathematical;
            else if (radioButton_normal.Checked) Program.Crypting = Program.CryptingMode.None;

            Program.SwitchLetters = checkBox_switch.Checked;

            if (bActive) textBox1.Text = Program.ConvertString(" Test string...");
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void ButtonOption_Click(object sender, EventArgs e)
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

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
            }
            catch(Exception)
            {

            }
        }

        private void CheckBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox2.Checked;
        }

        private void ButtonConvertClipboard_Click(object sender, EventArgs e)
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
    }
}
