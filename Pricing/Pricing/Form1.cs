namespace Pricing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double birim, adet, kdv, toplam;
            birim=Convert.ToDouble(textBox1.Text);
            adet=Convert.ToDouble(textBox2.Text);
            kdv=Convert.ToDouble(textBox3.Text);
            toplam= birim * adet + (birim * adet * kdv);

            textBox4.Text=toplam.ToString();
        }
    }
}