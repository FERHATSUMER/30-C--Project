namespace ButtonTextBoxListBox
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ogrenciIsimleri = new ComboBox();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 41);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 0;
            button1.Text = "Mesaj Yaz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 27);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(583, 40);
            button2.Name = "button2";
            button2.Size = new Size(109, 28);
            button2.TabIndex = 2;
            button2.Text = "Mesajı Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ogrenciIsimleri
            // 
            ogrenciIsimleri.FormattingEnabled = true;
            ogrenciIsimleri.Items.AddRange(new object[] { "Ali", "Veli", "Bager", "Ahmet", "Yılmaz", "Mustafa", "Tolga" });
            ogrenciIsimleri.Location = new Point(241, 128);
            ogrenciIsimleri.Name = "ogrenciIsimleri";
            ogrenciIsimleri.Size = new Size(151, 28);
            ogrenciIsimleri.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(491, 127);
            button3.Name = "button3";
            button3.Size = new Size(137, 29);
            button3.TabIndex = 4;
            button3.Text = "Öğrenci Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 240);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(540, 228);
            button4.Name = "button4";
            button4.Size = new Size(193, 45);
            button4.TabIndex = 6;
            button4.Text = "Label Change";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "HTML", "CSS", "JavaScript", "React.js" });
            listBox1.Location = new Point(368, 295);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(202, 144);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(ogrenciIsimleri);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private ComboBox ogrenciIsimleri;
        private Button button3;
        private Label label1;
        private Button button4;
        private ListBox listBox1;
    }
}