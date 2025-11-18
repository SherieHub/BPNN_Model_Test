namespace BackNeural
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
            createBPNN_btn = new Button();
            trainNeuralNet_btn = new Button();
            test_btn = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // createBPNN_btn
            // 
            createBPNN_btn.BackColor = Color.FromArgb(64, 64, 64);
            createBPNN_btn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBPNN_btn.ForeColor = SystemColors.ButtonHighlight;
            createBPNN_btn.Location = new Point(140, 486);
            createBPNN_btn.Name = "createBPNN_btn";
            createBPNN_btn.Size = new Size(228, 52);
            createBPNN_btn.TabIndex = 3;
            createBPNN_btn.Text = "Create BPNN";
            createBPNN_btn.UseVisualStyleBackColor = false;
            createBPNN_btn.Click += createBPNN_btn_Click;
            // 
            // trainNeuralNet_btn
            // 
            trainNeuralNet_btn.BackColor = Color.DodgerBlue;
            trainNeuralNet_btn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trainNeuralNet_btn.ForeColor = SystemColors.ButtonHighlight;
            trainNeuralNet_btn.Location = new Point(408, 486);
            trainNeuralNet_btn.Name = "trainNeuralNet_btn";
            trainNeuralNet_btn.Size = new Size(228, 52);
            trainNeuralNet_btn.TabIndex = 4;
            trainNeuralNet_btn.Text = "Train the Neural Net";
            trainNeuralNet_btn.UseVisualStyleBackColor = false;
            trainNeuralNet_btn.Click += trainNeuralNet_btn_Click;
            // 
            // test_btn
            // 
            test_btn.BackColor = Color.LimeGreen;
            test_btn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            test_btn.ForeColor = SystemColors.ButtonHighlight;
            test_btn.Location = new Point(676, 486);
            test_btn.Name = "test_btn";
            test_btn.Size = new Size(228, 52);
            test_btn.TabIndex = 5;
            test_btn.Text = "Test";
            test_btn.UseVisualStyleBackColor = false;
            test_btn.Click += test_btn_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F);
            textBox3.Location = new Point(140, 239);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 52);
            textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(140, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 52);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F);
            textBox2.Location = new Point(140, 155);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 52);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F);
            textBox4.Location = new Point(140, 331);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 52);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F);
            textBox5.Location = new Point(571, 201);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(333, 52);
            textBox5.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 612);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(test_btn);
            Controls.Add(trainNeuralNet_btn);
            Controls.Add(createBPNN_btn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button createBPNN_btn;
        private Button trainNeuralNet_btn;
        private Button test_btn;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
