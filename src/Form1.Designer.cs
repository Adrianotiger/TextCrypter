namespace KeyboardTrans
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_fraktur = new System.Windows.Forms.RadioButton();
            this.radioButton_superior = new System.Windows.Forms.RadioButton();
            this.radioButton_random = new System.Windows.Forms.RadioButton();
            this.radioButton_wide = new System.Windows.Forms.RadioButton();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_bracket = new System.Windows.Forms.RadioButton();
            this.radioButton_mathematical = new System.Windows.Forms.RadioButton();
            this.radioButton_italic = new System.Windows.Forms.RadioButton();
            this.radioButton_bold = new System.Windows.Forms.RadioButton();
            this.radioButton_bubble = new System.Windows.Forms.RadioButton();
            this.radioButton_squares = new System.Windows.Forms.RadioButton();
            this.radioButton_flipX = new System.Windows.Forms.RadioButton();
            this.radioButton_flipY = new System.Windows.Forms.RadioButton();
            this.checkBox_switch = new System.Windows.Forms.CheckBox();
            this.checkBoxCrypt = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.checkBox_switch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypting method";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton_fraktur, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_superior, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_random, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_wide, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_normal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_bracket, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_mathematical, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_italic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_bold, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_bubble, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_squares, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_flipX, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_flipY, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 115);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // radioButton_fraktur
            // 
            this.radioButton_fraktur.AutoSize = true;
            this.radioButton_fraktur.Location = new System.Drawing.Point(109, 26);
            this.radioButton_fraktur.Name = "radioButton_fraktur";
            this.radioButton_fraktur.Size = new System.Drawing.Size(58, 17);
            this.radioButton_fraktur.TabIndex = 11;
            this.radioButton_fraktur.Text = "Fraktur";
            this.radioButton_fraktur.UseVisualStyleBackColor = true;
            // 
            // radioButton_superior
            // 
            this.radioButton_superior.AutoSize = true;
            this.radioButton_superior.Location = new System.Drawing.Point(3, 72);
            this.radioButton_superior.Name = "radioButton_superior";
            this.radioButton_superior.Size = new System.Drawing.Size(64, 17);
            this.radioButton_superior.TabIndex = 6;
            this.radioButton_superior.Text = "Superior";
            this.radioButton_superior.UseVisualStyleBackColor = true;
            // 
            // radioButton_random
            // 
            this.radioButton_random.AutoSize = true;
            this.radioButton_random.Location = new System.Drawing.Point(215, 95);
            this.radioButton_random.Name = "radioButton_random";
            this.radioButton_random.Size = new System.Drawing.Size(69, 17);
            this.radioButton_random.TabIndex = 4;
            this.radioButton_random.Text = "Random*";
            this.toolTip1.SetToolTip(this.radioButton_random, "Will randomly use some crypting methods.");
            this.radioButton_random.UseVisualStyleBackColor = true;
            // 
            // radioButton_wide
            // 
            this.radioButton_wide.AutoSize = true;
            this.radioButton_wide.Location = new System.Drawing.Point(3, 95);
            this.radioButton_wide.Name = "radioButton_wide";
            this.radioButton_wide.Size = new System.Drawing.Size(50, 17);
            this.radioButton_wide.TabIndex = 1;
            this.radioButton_wide.Text = "Wide";
            this.radioButton_wide.UseVisualStyleBackColor = true;
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Checked = true;
            this.radioButton_normal.Location = new System.Drawing.Point(3, 3);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_normal.TabIndex = 13;
            this.radioButton_normal.TabStop = true;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            // 
            // radioButton_bracket
            // 
            this.radioButton_bracket.AutoSize = true;
            this.radioButton_bracket.Location = new System.Drawing.Point(215, 26);
            this.radioButton_bracket.Name = "radioButton_bracket";
            this.radioButton_bracket.Size = new System.Drawing.Size(66, 17);
            this.radioButton_bracket.TabIndex = 10;
            this.radioButton_bracket.Text = "Bracket*";
            this.toolTip1.SetToolTip(this.radioButton_bracket, "Works only with lower case characters.");
            this.radioButton_bracket.UseVisualStyleBackColor = true;
            // 
            // radioButton_mathematical
            // 
            this.radioButton_mathematical.AutoSize = true;
            this.radioButton_mathematical.Location = new System.Drawing.Point(109, 3);
            this.radioButton_mathematical.Name = "radioButton_mathematical";
            this.radioButton_mathematical.Size = new System.Drawing.Size(88, 17);
            this.radioButton_mathematical.TabIndex = 12;
            this.radioButton_mathematical.Text = "Mathematical";
            this.radioButton_mathematical.UseVisualStyleBackColor = true;
            // 
            // radioButton_italic
            // 
            this.radioButton_italic.AutoSize = true;
            this.radioButton_italic.Location = new System.Drawing.Point(3, 26);
            this.radioButton_italic.Name = "radioButton_italic";
            this.radioButton_italic.Size = new System.Drawing.Size(47, 17);
            this.radioButton_italic.TabIndex = 8;
            this.radioButton_italic.Text = "Italic";
            this.radioButton_italic.UseVisualStyleBackColor = true;
            // 
            // radioButton_bold
            // 
            this.radioButton_bold.AutoSize = true;
            this.radioButton_bold.Location = new System.Drawing.Point(3, 49);
            this.radioButton_bold.Name = "radioButton_bold";
            this.radioButton_bold.Size = new System.Drawing.Size(46, 17);
            this.radioButton_bold.TabIndex = 7;
            this.radioButton_bold.Text = "Bold";
            this.radioButton_bold.UseVisualStyleBackColor = true;
            // 
            // radioButton_bubble
            // 
            this.radioButton_bubble.AutoSize = true;
            this.radioButton_bubble.Location = new System.Drawing.Point(109, 49);
            this.radioButton_bubble.Name = "radioButton_bubble";
            this.radioButton_bubble.Size = new System.Drawing.Size(58, 17);
            this.radioButton_bubble.TabIndex = 0;
            this.radioButton_bubble.Text = "Bubble";
            this.radioButton_bubble.UseVisualStyleBackColor = true;
            // 
            // radioButton_squares
            // 
            this.radioButton_squares.AutoSize = true;
            this.radioButton_squares.Location = new System.Drawing.Point(215, 3);
            this.radioButton_squares.Name = "radioButton_squares";
            this.radioButton_squares.Size = new System.Drawing.Size(68, 17);
            this.radioButton_squares.TabIndex = 2;
            this.radioButton_squares.Text = "Squares*";
            this.toolTip1.SetToolTip(this.radioButton_squares, "1. Works only on some text fields...\r\n2. Add other 3 characters to each letter.\r\n" +
        "");
            this.radioButton_squares.UseVisualStyleBackColor = true;
            // 
            // radioButton_flipX
            // 
            this.radioButton_flipX.AutoSize = true;
            this.radioButton_flipX.Location = new System.Drawing.Point(109, 72);
            this.radioButton_flipX.Name = "radioButton_flipX";
            this.radioButton_flipX.Size = new System.Drawing.Size(51, 17);
            this.radioButton_flipX.TabIndex = 3;
            this.radioButton_flipX.Text = "Flip X";
            this.radioButton_flipX.UseVisualStyleBackColor = true;
            // 
            // radioButton_flipY
            // 
            this.radioButton_flipY.AutoSize = true;
            this.radioButton_flipY.Location = new System.Drawing.Point(109, 95);
            this.radioButton_flipY.Name = "radioButton_flipY";
            this.radioButton_flipY.Size = new System.Drawing.Size(51, 17);
            this.radioButton_flipY.TabIndex = 5;
            this.radioButton_flipY.Text = "Flip Y";
            this.radioButton_flipY.UseVisualStyleBackColor = true;
            // 
            // checkBox_switch
            // 
            this.checkBox_switch.AutoSize = true;
            this.checkBox_switch.Location = new System.Drawing.Point(6, 153);
            this.checkBox_switch.Name = "checkBox_switch";
            this.checkBox_switch.Size = new System.Drawing.Size(118, 17);
            this.checkBox_switch.TabIndex = 14;
            this.checkBox_switch.Text = "switch words letters";
            this.checkBox_switch.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrypt
            // 
            this.checkBoxCrypt.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCrypt.Location = new System.Drawing.Point(63, 223);
            this.checkBoxCrypt.Name = "checkBoxCrypt";
            this.checkBoxCrypt.Size = new System.Drawing.Size(224, 24);
            this.checkBoxCrypt.TabIndex = 1;
            this.checkBoxCrypt.Text = "CRYPT!";
            this.checkBoxCrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCrypt.UseVisualStyleBackColor = true;
            this.checkBoxCrypt.CheckedChanged += new System.EventHandler(this.CheckBoxCrypt_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(63, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "  Test...";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "ℹ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "⚙";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonOption_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 176);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Windows Store:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(40, 151);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(277, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://www.microsoft.com/store/apps/9P8F03F9KZZH ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Convert text in clipboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonConvertClipboard_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Location = new System.Drawing.Point(6, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(312, 35);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Set application on Top Most";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBoxTopMost_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GitHub open source project:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(102, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(215, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Adrianotiger/TextCrypter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(354, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxCrypt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text crypter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_flipX;
        private System.Windows.Forms.RadioButton radioButton_squares;
        private System.Windows.Forms.RadioButton radioButton_wide;
        private System.Windows.Forms.RadioButton radioButton_bubble;
        private System.Windows.Forms.CheckBox checkBoxCrypt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_random;
        private System.Windows.Forms.RadioButton radioButton_flipY;
        private System.Windows.Forms.RadioButton radioButton_italic;
        private System.Windows.Forms.RadioButton radioButton_bold;
        private System.Windows.Forms.RadioButton radioButton_superior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_bracket;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioButton_fraktur;
        private System.Windows.Forms.RadioButton radioButton_mathematical;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.CheckBox checkBox_switch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}