using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sqlConnect
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=FerhatSumer;Integrated Security=SSPI");
            da = new SqlDataAdapter("SELECT * FROM personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            // Parametreli sorgu kullanýmý (SQL injection'a karþý koruma)
            cmd.CommandText = "INSERT INTO personel(personel_id, personel_isim, personel_soyad, personel_telno) VALUES (@personel_id, @personel_isim, @personel_soyad, @personel_telno)";
            cmd.Parameters.AddWithValue("@personel_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@personel_isim", textBox2.Text);
            cmd.Parameters.AddWithValue("@personel_soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@personel_telno", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            griddoldur();
        }
    }
}
