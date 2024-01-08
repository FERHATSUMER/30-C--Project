namespace Random_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            {
//                Random rndm = new Random();
//                int num = rndm.Next(0, 15);

//                listBox1.Items.Add(num.ToString());
//            }
            int num;
            int[] nums = new int[10];
            Random rndm = new Random();
            int i = 0;
            while (i < 10)
            {
                num = rndm.Next(0, 15);
                nums[i] = num;
                listBox1.Items.Add(num);
                i++;
            }
        }
    }
}