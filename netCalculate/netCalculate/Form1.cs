namespace netCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBox6.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //net hesaplama 
            double tdogru, mdogru, tyanl�s, myanl�s, tnet, mnet;
            tdogru = Convert .ToDouble(textBox1.Text);
            mdogru=Convert.ToDouble(textBox2.Text);
            tyanl�s = Convert.ToDouble(textBox3.Text);
            myanl�s = Convert.ToDouble(textBox4.Text);
            tnet= tdogru - (tyanl�s /4);
            mnet = mdogru - (myanl�s / 4);
            textBox5.Text=tnet.ToString();
            textBox6.Text=mnet.ToString();
        }
    }
}