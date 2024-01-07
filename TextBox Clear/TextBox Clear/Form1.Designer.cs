namespace TextBox_Clear
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
            name = new Label();
            surneme = new Label();
            statement = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            clear = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(119, 41);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 0;
            name.Text = "Name";
            // 
            // surneme
            // 
            surneme.AutoSize = true;
            surneme.Location = new Point(119, 103);
            surneme.Name = "surneme";
            surneme.Size = new Size(67, 20);
            surneme.TabIndex = 1;
            surneme.Text = "Surname";
            // 
            // statement
            // 
            statement.AutoSize = true;
            statement.Location = new Point(119, 161);
            statement.Name = "statement";
            statement.Size = new Size(77, 20);
            statement.TabIndex = 2;
            statement.Text = "Statement";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // clear
            // 
            clear.Location = new Point(276, 226);
            clear.Name = "clear";
            clear.Size = new Size(125, 71);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clear);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(statement);
            Controls.Add(surneme);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label surneme;
        private Label statement;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button clear;
    }
}