namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
        double vize, final, sonuc;
        vize=Convert.ToDouble(textBox1.Text);
        final=Convert.ToDouble(textBox2.Text);
        sonuc=(vize*0.4) + (final*0.6);
        if(sonuc >= 50) { 
        textBox3.Text="Tebrikler";
        }
        else
        {
            textBox3.Text = "Kaldýnýz";
        }

        }

      
    }
}