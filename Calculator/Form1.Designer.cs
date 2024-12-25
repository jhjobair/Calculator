namespace Calculator
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
            TxtResult = new TextBox();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            BtnCE = new Button();
            BtnPlus = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            BtnMinus = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            Btn0 = new Button();
            BtnEqual = new Button();
            BtnX = new Button();
            BtnDivition = new Button();
            SuspendLayout();
            // 
            // TxtResult
            // 
            TxtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtResult.BackColor = SystemColors.ButtonHighlight;
            TxtResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtResult.HideSelection = false;
            TxtResult.ImeMode = ImeMode.NoControl;
            TxtResult.Location = new Point(18, 10);
            TxtResult.Margin = new Padding(2);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(366, 58);
            TxtResult.TabIndex = 0;
            TxtResult.TabStop = false;
            TxtResult.TextAlign = HorizontalAlignment.Right;
            TxtResult.TextChanged += textBox1_TextChanged;
            // 
            // Btn1
            // 
            Btn1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn1.Location = new Point(19, 97);
            Btn1.Margin = new Padding(2);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(66, 63);
            Btn1.TabIndex = 1;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn2.Location = new Point(122, 97);
            Btn2.Margin = new Padding(2);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(65, 63);
            Btn2.TabIndex = 2;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn3.Location = new Point(217, 97);
            Btn3.Margin = new Padding(2);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(66, 63);
            Btn3.TabIndex = 3;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // BtnCE
            // 
            BtnCE.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCE.Location = new Point(318, 97);
            BtnCE.Margin = new Padding(2);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(67, 63);
            BtnCE.TabIndex = 4;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = true;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPlus.Location = new Point(318, 174);
            BtnPlus.Margin = new Padding(2);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(66, 62);
            BtnPlus.TabIndex = 8;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // Btn6
            // 
            Btn6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn6.Location = new Point(217, 174);
            Btn6.Margin = new Padding(2);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(66, 62);
            Btn6.TabIndex = 7;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn5
            // 
            Btn5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn5.Location = new Point(121, 174);
            Btn5.Margin = new Padding(2);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(66, 62);
            Btn5.TabIndex = 6;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn4
            // 
            Btn4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn4.Location = new Point(18, 174);
            Btn4.Margin = new Padding(2);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(66, 62);
            Btn4.TabIndex = 5;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMinus.Location = new Point(318, 255);
            BtnMinus.Margin = new Padding(2);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(66, 62);
            BtnMinus.TabIndex = 12;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += BtnMinus_Click;
            // 
            // Btn9
            // 
            Btn9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn9.Location = new Point(217, 255);
            Btn9.Margin = new Padding(2);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(66, 62);
            Btn9.TabIndex = 11;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Btn8
            // 
            Btn8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn8.Location = new Point(121, 255);
            Btn8.Margin = new Padding(2);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(66, 62);
            Btn8.TabIndex = 10;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn7
            // 
            Btn7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn7.Location = new Point(18, 255);
            Btn7.Margin = new Padding(2);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(66, 62);
            Btn7.TabIndex = 9;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // Btn0
            // 
            Btn0.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Btn0.Location = new Point(19, 336);
            Btn0.Margin = new Padding(2);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(66, 62);
            Btn0.TabIndex = 13;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEqual.Location = new Point(319, 336);
            BtnEqual.Margin = new Padding(2);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(66, 62);
            BtnEqual.TabIndex = 14;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = true;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // BtnX
            // 
            BtnX.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnX.Location = new Point(121, 336);
            BtnX.Margin = new Padding(2);
            BtnX.Name = "BtnX";
            BtnX.Size = new Size(66, 62);
            BtnX.TabIndex = 15;
            BtnX.Text = "x";
            BtnX.UseVisualStyleBackColor = true;
            BtnX.Click += BtnX_Click;
            // 
            // BtnDivition
            // 
            BtnDivition.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDivition.Location = new Point(217, 336);
            BtnDivition.Margin = new Padding(2);
            BtnDivition.Name = "BtnDivition";
            BtnDivition.Size = new Size(66, 62);
            BtnDivition.TabIndex = 16;
            BtnDivition.Text = "÷";
            BtnDivition.UseVisualStyleBackColor = true;
            BtnDivition.Click += BtnDivition_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(402, 447);
            Controls.Add(BtnDivition);
            Controls.Add(BtnX);
            Controls.Add(BtnEqual);
            Controls.Add(Btn0);
            Controls.Add(BtnMinus);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(BtnPlus);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(BtnCE);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(TxtResult);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResult;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button BtnCE;
        private Button BtnPlus;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnMinus;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button Btn0;
        private Button BtnEqual;
        private Button BtnX;
        private Button BtnDivition;
    }
}