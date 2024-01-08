namespace Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayý = Convert.ToInt32(textBox1.Text);
            int sonuc = 0;
            for (int i = 0; i < sayý; i++)
            {
                sonuc = ++i + sonuc--;
            }
            label2.Text = sonuc.ToString();
        }
    }
}