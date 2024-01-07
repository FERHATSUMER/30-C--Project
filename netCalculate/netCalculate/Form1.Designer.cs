namespace netCalculate
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
            turk = new Label();
            mat = new Label();
            dogru = new Label();
            yalnıs = new Label();
            net = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // turk
            // 
            turk.AutoSize = true;
            turk.Location = new Point(180, 77);
            turk.Name = "turk";
            turk.Size = new Size(52, 20);
            turk.TabIndex = 0;
            turk.Text = "Türkçe";
            // 
            // mat
            // 
            mat.AutoSize = true;
            mat.Location = new Point(180, 130);
            mat.Name = "mat";
            mat.Size = new Size(80, 20);
            mat.TabIndex = 1;
            mat.Text = "Matemetik";
            // 
            // dogru
            // 
            dogru.AutoSize = true;
            dogru.Location = new Point(291, 25);
            dogru.Name = "dogru";
            dogru.Size = new Size(51, 20);
            dogru.TabIndex = 2;
            dogru.Text = "Doğru";
            // 
            // yalnıs
            // 
            yalnıs.AutoSize = true;
            yalnıs.Location = new Point(413, 25);
            yalnıs.Name = "yalnıs";
            yalnıs.Size = new Size(46, 20);
            yalnıs.TabIndex = 3;
            yalnıs.Text = "Yanlış";
            // 
            // net
            // 
            net.AutoSize = true;
            net.Location = new Point(549, 25);
            net.Name = "net";
            net.Size = new Size(33, 20);
            net.TabIndex = 4;
            net.Text = "Net";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(284, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(284, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(406, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(57, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(406, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(57, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(542, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(57, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(542, 139);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(57, 27);
            textBox6.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(291, 204);
            button1.Name = "button1";
            button1.Size = new Size(296, 62);
            button1.TabIndex = 11;
            button1.Text = "Net Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(net);
            Controls.Add(yalnıs);
            Controls.Add(dogru);
            Controls.Add(mat);
            Controls.Add(turk);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label turk;
        private Label mat;
        private Label dogru;
        private Label yalnıs;
        private Label net;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}