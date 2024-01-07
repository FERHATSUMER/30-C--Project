namespace Triangle_Area_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstSide, secondSide, result;
            firstSide=Convert.ToDouble(textBox1.Text);
            secondSide=Convert.ToDouble(textBox2.Text);
            result = (firstSide*secondSide)/2 ;

            textBox3.Text = result.ToString();    
        }
    }
}