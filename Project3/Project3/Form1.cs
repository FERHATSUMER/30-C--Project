namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ListBox'lardaki ��e say�s�n� kontrol et
            if (listBox1.Items.Count < 5 || listBox2.Items.Count < 5)
            {
                MessageBox.Show("Her iki ListBox'ta en az 5 ��e olmal�d�r.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] dizi1 = new int[5];
            int[] dizi2 = new int[5];

            // listBox1 ve listBox2'deki de�erleri dizi1 ve dizi2'ye aktar
            for (int i = 0; i < 5; i++)
            {
                dizi1[i] = Convert.ToInt32(listBox1.Items[i]);
                dizi2[i] = Convert.ToInt32(listBox2.Items[i]);
            }

            // Dizileri kar��la�t�r ve b�y�k olan� k���k olanla topla
            for (int i = 0; i < 5; i++)
            {
                if (dizi1[i] > dizi2[i])
                    dizi1[i] += dizi2[i];
                else
                    dizi2[i] += dizi1[i];
            }

            // ListBox'lar� temizle
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            // Yeni de�erleri ListBox'lara ekle
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(dizi1[i]);
                listBox2.Items.Add(dizi2[i]);
            }
        }
    }
}