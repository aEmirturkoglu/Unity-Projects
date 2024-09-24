namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            tabPage3 = new TabPage();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Personel Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Name Surname";
            label2.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 232);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(457, 216);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(449, 183);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Engineer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 154);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 33);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Monthly Salary";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox9);
            groupBox3.Controls.Add(checkBox10);
            groupBox3.Controls.Add(checkBox11);
            groupBox3.Controls.Add(checkBox12);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(113, 146);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Language";
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(6, 112);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(77, 24);
            checkBox9.TabIndex = 3;
            checkBox9.Text = "Turkish";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(6, 82);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(74, 24);
            checkBox10.TabIndex = 2;
            checkBox10.Text = "French";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(6, 52);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(83, 24);
            checkBox11.TabIndex = 1;
            checkBox11.Text = "German";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(6, 26);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(78, 24);
            checkBox12.TabIndex = 0;
            checkBox12.Text = "English";
            checkBox12.UseVisualStyleBackColor = true;
            checkBox12.CheckedChanged += checkBox12_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(449, 183);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Secretary";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Location = new Point(3, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(113, 106);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 82);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(74, 24);
            checkBox6.TabIndex = 2;
            checkBox6.Text = "French";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 52);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(83, 24);
            checkBox7.TabIndex = 1;
            checkBox7.Text = "German";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(6, 26);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(78, 24);
            checkBox8.TabIndex = 0;
            checkBox8.Text = "English";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(449, 183);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Labour";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 25);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Type Per Minute";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(277, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 27);
            textBox5.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 85);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 6;
            label5.Text = "Weekly Salary";
            // 
            // button2
            // 
            button2.Location = new Point(223, 138);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "new";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(323, 138);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Secretary;
        private TabPage tabPage3;
        public TabPage tabPage2;
        private GroupBox groupBox3;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private GroupBox groupBox2;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button3;
        private Button button2;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}
