namespace Calculator_Y
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
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.result.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(1, 2);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(291, 128);
            this.result.TabIndex = 0;
            this.result.Text = " ";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.WindowText;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(12, 424);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 82);
            this.button8.TabIndex = 2;
            this.button8.Text = "%";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowText;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(12, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowText;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(12, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 82);
            this.button5.TabIndex = 2;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.WindowText;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(12, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 82);
            this.button6.TabIndex = 2;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.WindowText;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(73, 424);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 82);
            this.button7.TabIndex = 2;
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.WindowText;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(73, 336);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 82);
            this.button9.TabIndex = 2;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.WindowText;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(73, 248);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 82);
            this.button10.TabIndex = 2;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.WindowText;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.ForeColor = System.Drawing.SystemColors.Control;
            this.button11.Location = new System.Drawing.Point(73, 166);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 82);
            this.button11.TabIndex = 2;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.WindowText;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button12.ForeColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(134, 424);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 82);
            this.button12.TabIndex = 2;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.WindowText;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.ForeColor = System.Drawing.SystemColors.Control;
            this.button13.Location = new System.Drawing.Point(134, 336);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 82);
            this.button13.TabIndex = 2;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.WindowText;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button14.ForeColor = System.Drawing.SystemColors.Control;
            this.button14.Location = new System.Drawing.Point(134, 248);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 82);
            this.button14.TabIndex = 2;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.WindowText;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button15.ForeColor = System.Drawing.SystemColors.Control;
            this.button15.Location = new System.Drawing.Point(134, 166);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 82);
            this.button15.TabIndex = 2;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(73, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 24);
            this.button4.TabIndex = 1;
            this.button4.Text = "DEL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.squareRoot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.squareRoot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.squareRoot.Location = new System.Drawing.Point(134, 136);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(55, 24);
            this.squareRoot.TabIndex = 1;
            this.squareRoot.Text = "x²";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.bntRoot_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(215, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.operator_click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button20.Location = new System.Drawing.Point(215, 166);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(68, 82);
            this.button20.TabIndex = 1;
            this.button20.Text = "*";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.operator_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button17.Location = new System.Drawing.Point(215, 248);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 82);
            this.button17.TabIndex = 1;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.operator_click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button18.Location = new System.Drawing.Point(215, 335);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(68, 82);
            this.button18.TabIndex = 1;
            this.button18.Text = "+";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.operator_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button16.Location = new System.Drawing.Point(215, 423);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 82);
            this.button16.TabIndex = 1;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equation.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.equation.Location = new System.Drawing.Point(1, 2);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 25);
            this.equation.TabIndex = 3;
            this.equation.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 522);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Y";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox result;
        private Button button1;
        private Button button8;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button4;
        private Button squareRoot;
        private Button button2;
        private Button button20;
        private Button button17;
        private Button button18;
        private Button button16;
        private Label equation;
    }
}