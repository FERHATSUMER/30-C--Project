namespace Exam_Grade_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, odev, final, sonuc;
            vize = Convert.ToDouble(textBox1.Text);
            odev = Convert.ToDouble(textBox2.Text);
            final = Convert.ToDouble(textBox3.Text);
            sonuc = (vize * 0.3) + (odev * 0.2) + (final * 0.5);
            textBox4.Text=sonuc.ToString();
        }
    }
}