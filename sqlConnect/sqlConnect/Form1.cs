using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlConnect
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }


        void griddoldur()
        {
            con = new SqlConnection("Server=DESKTOP-JTLF5M6; Initial Catalog=FerhatSumer;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From Personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
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
            cmd.CommandText = "INSERT INTO Personel(id, isim, soyisim, telno) VALUES (@id, @isim, @soyisim, @telno)";
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@isim", textBox2.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox3.Text);
            cmd.Parameters.AddWithValue("@telno", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Personel SET isim=@isim, soyisim=@soyisim, telno=@telno WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@isim", textBox2.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox3.Text);
            cmd.Parameters.AddWithValue("@telno", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Personel WHERE id="+textBox1.Text;


            da.Fill(ds, "Personel");

            textBox1.Text = ds.Tables["Personel"].Rows[Convert.ToInt32(textBox1.Text)]["id"].ToString();
            textBox2.Text = ds.Tables["Personel"].Rows[Convert.ToInt32(textBox1.Text)]["isim"].ToString();
            textBox3.Text = ds.Tables["Personel"].Rows[Convert.ToInt32(textBox1.Text)]["soyisim"].ToString();
            textBox4.Text = ds.Tables["Personel"].Rows[Convert.ToInt32(textBox1.Text)]["telno"].ToString();

            con.Close();

        }
    }
}
