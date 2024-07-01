namespace Calculator_WinForm
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
            label1 = new Label();
            Num1 = new Label();
            num2 = new Label();
            button1 = new Button();
            num1_textBox = new TextBox();
            num2_textBox = new TextBox();
            result_label = new Label();
            operation_textbox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 0);
            label1.Name = "label1";
            label1.Size = new Size(514, 60);
            label1.TabIndex = 0;
            label1.Text = "CALCULATOR APP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Num1
            // 
            Num1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Num1.AutoSize = true;
            Num1.BackColor = Color.Transparent;
            Num1.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Num1.Location = new Point(12, 84);
            Num1.Name = "Num1";
            Num1.Size = new Size(314, 58);
            Num1.TabIndex = 1;
            Num1.Text = "Enter 1st Number: ";
            // 
            // num2
            // 
            num2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            num2.AutoSize = true;
            num2.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point);
            num2.Location = new Point(12, 218);
            num2.Name = "num2";
            num2.Size = new Size(331, 58);
            num2.TabIndex = 2;
            num2.Text = "Enter 2nd Number: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(511, 306);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 3;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // num1_textBox
            // 
            num1_textBox.Location = new Point(360, 107);
            num1_textBox.Name = "num1_textBox";
            num1_textBox.Size = new Size(410, 33);
            num1_textBox.TabIndex = 4;
            num1_textBox.TextAlign = HorizontalAlignment.Center;
            num1_textBox.TextChanged += num1_textBox_TextChanged;
            // 
            // num2_textBox
            // 
            num2_textBox.Location = new Point(360, 235);
            num2_textBox.Name = "num2_textBox";
            num2_textBox.Size = new Size(410, 33);
            num2_textBox.TabIndex = 5;
            num2_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Font = new Font("Yu Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point);
            result_label.Location = new Point(289, 365);
            result_label.Name = "result_label";
            result_label.Size = new Size(201, 56);
            result_label.TabIndex = 6;
            result_label.Text = "RESULT";
            result_label.TextAlign = ContentAlignment.MiddleCenter;
            result_label.Visible = false;
            // 
            // operation_textbox
            // 
            operation_textbox.Location = new Point(360, 170);
            operation_textbox.Name = "operation_textbox";
            operation_textbox.Size = new Size(410, 33);
            operation_textbox.TabIndex = 7;
            operation_textbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Banner", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(289, 58);
            label3.TabIndex = 8;
            label3.Text = "Enter Operation: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(795, 470);
            Controls.Add(label3);
            Controls.Add(operation_textbox);
            Controls.Add(result_label);
            Controls.Add(num2_textBox);
            Controls.Add(num1_textBox);
            Controls.Add(button1);
            Controls.Add(num2);
            Controls.Add(Num1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Num1;
        private Label num2;
        private Button button1;
        private TextBox num1_textBox;
        private TextBox num2_textBox;
        private Label result_label;
        private TextBox operation_textbox;
        private Label label3;
    }
}