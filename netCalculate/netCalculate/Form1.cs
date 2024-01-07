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
            double tdogru, mdogru, tyanlýs, myanlýs, tnet, mnet;
            tdogru = Convert .ToDouble(textBox1.Text);
            mdogru=Convert.ToDouble(textBox2.Text);
            tyanlýs = Convert.ToDouble(textBox3.Text);
            myanlýs = Convert.ToDouble(textBox4.Text);
            tnet= tdogru - (tyanlýs /4);
            mnet = mdogru - (myanlýs / 4);
            textBox5.Text=tnet.ToString();
            textBox6.Text=mnet.ToString();
        }
    }
}