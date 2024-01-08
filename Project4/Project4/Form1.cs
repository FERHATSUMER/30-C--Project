namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
             int sonuc = 0, i=1;
                 while (i < sayi)
                    {
                        if (i % 3 == 1)
                        sonuc += 2 * i - sayi;
                        else
                        sonuc += i;
                        i++;
                    }
                     label2.Text = sonuc.ToString();
        }
    }
}