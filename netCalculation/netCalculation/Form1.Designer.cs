namespace netCalculation
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
            turkTrue = new TextBox();
            Turkce = new Label();
            Mat = new Label();
            matTrue = new TextBox();
            Dogru = new Label();
            yanlıs = new Label();
            net = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // turkTrue
            // 
            turkTrue.Location = new Point(278, 47);
            turkTrue.Name = "turkTrue";
            turkTrue.Size = new Size(78, 27);
            turkTrue.TabIndex = 0;
            // 
            // Turkce
            // 
            Turkce.AutoSize = true;
            Turkce.Location = new Point(150, 50);
            Turkce.Name = "Turkce";
            Turkce.Size = new Size(52, 20);
            Turkce.TabIndex = 1;
            Turkce.Text = "Türkçe";
            // 
            // Mat
            // 
            Mat.AutoSize = true;
            Mat.Location = new Point(150, 111);
            Mat.Name = "Mat";
            Mat.Size = new Size(80, 20);
            Mat.TabIndex = 2;
            Mat.Text = "Matematik";
            // 
            // matTrue
            // 
            matTrue.Location = new Point(278, 124);
            matTrue.Name = "matTrue";
            matTrue.Size = new Size(78, 27);
            matTrue.TabIndex = 3;
            // 
            // Dogru
            // 
            Dogru.AutoSize = true;
            Dogru.Location = new Point(305, 9);
            Dogru.Name = "Dogru";
            Dogru.Size = new Size(51, 20);
            Dogru.TabIndex = 4;
            Dogru.Text = "Doğru";
            // 
            // yanlıs
            // 
            yanlıs.AutoSize = true;
            yanlıs.Location = new Point(444, 9);
            yanlıs.Name = "yanlıs";
            yanlıs.Size = new Size(46, 20);
            yanlıs.TabIndex = 5;
            yanlıs.Text = "Yanlış";
            // 
            // net
            // 
            net.AutoSize = true;
            net.Location = new Point(575, 9);
            net.Name = "net";
            net.Size = new Size(33, 20);
            net.TabIndex = 6;
            net.Text = "Net";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(427, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(427, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(561, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(78, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(561, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 27);
            textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(net);
            Controls.Add(yanlıs);
            Controls.Add(Dogru);
            Controls.Add(matTrue);
            Controls.Add(Mat);
            Controls.Add(Turkce);
            Controls.Add(turkTrue);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox turkTrue;
        private Label Turkce;
        private Label Mat;
        private TextBox matTrue;
        private Label Dogru;
        private Label yanlıs;
        private Label net;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}