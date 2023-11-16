namespace FormsChangeBackground
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
            btnMavi = new Button();
            btnKırmızı = new Button();
            btnSarı = new Button();
            btnYesil = new Button();
            SuspendLayout();
            // 
            // btnMavi
            // 
            btnMavi.BackColor = SystemColors.Highlight;
            btnMavi.ForeColor = SystemColors.ButtonFace;
            btnMavi.Location = new Point(198, 133);
            btnMavi.Name = "btnMavi";
            btnMavi.Size = new Size(128, 34);
            btnMavi.TabIndex = 0;
            btnMavi.Text = "Mavi";
            btnMavi.UseVisualStyleBackColor = false;
            btnMavi.Click += btnMavi_Click;
            // 
            // btnKırmızı
            // 
            btnKırmızı.BackColor = Color.FromArgb(192, 0, 0);
            btnKırmızı.ForeColor = SystemColors.ButtonFace;
            btnKırmızı.Location = new Point(198, 202);
            btnKırmızı.Name = "btnKırmızı";
            btnKırmızı.Size = new Size(128, 34);
            btnKırmızı.TabIndex = 1;
            btnKırmızı.Text = "Kırmızı";
            btnKırmızı.UseVisualStyleBackColor = false;
            btnKırmızı.Click += btnKırmızı_Click;
            // 
            // btnSarı
            // 
            btnSarı.BackColor = Color.Yellow;
            btnSarı.ForeColor = SystemColors.ActiveCaptionText;
            btnSarı.Location = new Point(392, 133);
            btnSarı.Name = "btnSarı";
            btnSarı.Size = new Size(128, 34);
            btnSarı.TabIndex = 2;
            btnSarı.Text = "Sarı";
            btnSarı.UseVisualStyleBackColor = false;
            btnSarı.Click += btnSarı_Click;
            // 
            // btnYesil
            // 
            btnYesil.BackColor = Color.Green;
            btnYesil.ForeColor = SystemColors.ButtonHighlight;
            btnYesil.Location = new Point(392, 202);
            btnYesil.Name = "btnYesil";
            btnYesil.Size = new Size(128, 34);
            btnYesil.TabIndex = 3;
            btnYesil.Text = "Yeşil";
            btnYesil.UseVisualStyleBackColor = false;
            btnYesil.Click += btnYesil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYesil);
            Controls.Add(btnSarı);
            Controls.Add(btnKırmızı);
            Controls.Add(btnMavi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMavi;
        private Button btnKırmızı;
        private Button btnSarı;
        private Button btnYesil;
    }
}