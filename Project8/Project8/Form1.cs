namespace Project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            double salary;
            name = textBox1.Text;
            surname = textBox2.Text;
            salary = Convert.ToDouble(textBox3.Text);
            listBox1.Items.Add(name + " " + surname + " " + salary);
        }
    }
}