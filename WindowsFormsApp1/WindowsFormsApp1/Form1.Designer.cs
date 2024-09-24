namespace WindowsFormsApp1
{
    partial class CalculatorForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num1TextBox = new System.Windows.Forms.TextBox();
            this.Num2TextBox = new System.Windows.Forms.TextBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.SubtractRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.DivideRadioButton = new System.Windows.Forms.RadioButton();
            this.ModulusRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultLabel = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1TextBox
            // 
            this.Num1TextBox.Location = new System.Drawing.Point(38, 25);
            this.Num1TextBox.Name = "Num1TextBox";
            this.Num1TextBox.Size = new System.Drawing.Size(100, 22);
            this.Num1TextBox.TabIndex = 0;
            this.Num1TextBox.Text = "num1";
            // 
            // Num2TextBox
            // 
            this.Num2TextBox.Location = new System.Drawing.Point(648, 25);
            this.Num2TextBox.Name = "Num2TextBox";
            this.Num2TextBox.Size = new System.Drawing.Size(100, 22);
            this.Num2TextBox.TabIndex = 1;
            this.Num2TextBox.Text = "num2";
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Location = new System.Drawing.Point(337, 74);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(35, 20);
            this.AddRadioButton.TabIndex = 2;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "+";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractRadioButton
            // 
            this.SubtractRadioButton.AutoSize = true;
            this.SubtractRadioButton.Location = new System.Drawing.Point(337, 100);
            this.SubtractRadioButton.Name = "SubtractRadioButton";
            this.SubtractRadioButton.Size = new System.Drawing.Size(32, 20);
            this.SubtractRadioButton.TabIndex = 3;
            this.SubtractRadioButton.TabStop = true;
            this.SubtractRadioButton.Text = "-";
            this.SubtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            this.MultiplyRadioButton.AutoSize = true;
            this.MultiplyRadioButton.Location = new System.Drawing.Point(337, 126);
            this.MultiplyRadioButton.Name = "MultiplyRadioButton";
            this.MultiplyRadioButton.Size = new System.Drawing.Size(33, 20);
            this.MultiplyRadioButton.TabIndex = 4;
            this.MultiplyRadioButton.TabStop = true;
            this.MultiplyRadioButton.Text = "*";
            this.MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DivideRadioButton
            // 
            this.DivideRadioButton.AutoSize = true;
            this.DivideRadioButton.Location = new System.Drawing.Point(337, 152);
            this.DivideRadioButton.Name = "DivideRadioButton";
            this.DivideRadioButton.Size = new System.Drawing.Size(32, 20);
            this.DivideRadioButton.TabIndex = 5;
            this.DivideRadioButton.TabStop = true;
            this.DivideRadioButton.Text = "/";
            this.DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModulusRadioButton
            // 
            this.ModulusRadioButton.AutoSize = true;
            this.ModulusRadioButton.Location = new System.Drawing.Point(337, 178);
            this.ModulusRadioButton.Name = "ModulusRadioButton";
            this.ModulusRadioButton.Size = new System.Drawing.Size(40, 20);
            this.ModulusRadioButton.TabIndex = 6;
            this.ModulusRadioButton.TabStop = true;
            this.ModulusRadioButton.Text = "%";
            this.ModulusRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(304, 345);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(191, 22);
            this.ResultLabel.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(337, 316);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(114, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "calculate result";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ModulusRadioButton);
            this.Controls.Add(this.DivideRadioButton);
            this.Controls.Add(this.MultiplyRadioButton);
            this.Controls.Add(this.SubtractRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.Num2TextBox);
            this.Controls.Add(this.Num1TextBox);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button CalculateButton;
        public System.Windows.Forms.TextBox Num1TextBox;
        public System.Windows.Forms.TextBox Num2TextBox;
        public System.Windows.Forms.RadioButton AddRadioButton;
        public System.Windows.Forms.RadioButton SubtractRadioButton;
        public System.Windows.Forms.RadioButton MultiplyRadioButton;
        public System.Windows.Forms.RadioButton DivideRadioButton;
        public System.Windows.Forms.RadioButton ModulusRadioButton;
        public System.Windows.Forms.TextBox ResultLabel;
    }
}

