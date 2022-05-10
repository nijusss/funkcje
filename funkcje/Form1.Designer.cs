namespace funkcje
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
            this.ab = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.x1b = new System.Windows.Forms.TextBox();
            this.x2b = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ab
            // 
            this.ab.Location = new System.Drawing.Point(44, 175);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(61, 23);
            this.ab.TabIndex = 0;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(261, 175);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(62, 23);
            this.cc.TabIndex = 1;
            this.cc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(160, 175);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(60, 23);
            this.bb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delta = b^2 - 4ac";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "b";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "*x^2 +";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "*x +";
            // 
            // wd
            // 
            this.wd.Location = new System.Drawing.Point(364, 175);
            this.wd.Name = "wd";
            this.wd.ReadOnly = true;
            this.wd.Size = new System.Drawing.Size(100, 23);
            this.wd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wynik Delty";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Policz Deltę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(597, 175);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(167, 23);
            this.addText.TabIndex = 13;
            // 
            // x1b
            // 
            this.x1b.Location = new System.Drawing.Point(242, 364);
            this.x1b.Name = "x1b";
            this.x1b.Size = new System.Drawing.Size(55, 23);
            this.x1b.TabIndex = 14;
            // 
            // x2b
            // 
            this.x2b.Location = new System.Drawing.Point(505, 364);
            this.x2b.Name = "x2b";
            this.x2b.Size = new System.Drawing.Size(53, 23);
            this.x2b.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "x1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "x2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Miejsca zerowe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.x2b);
            this.Controls.Add(this.x1b);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.ab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ab;
        private TextBox cc;
        private TextBox bb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox wd;
        private Label label7;
        private Button button1;
        private TextBox addText;
        private TextBox x1b;
        private TextBox x2b;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}