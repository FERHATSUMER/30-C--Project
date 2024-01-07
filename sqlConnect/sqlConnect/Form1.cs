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
            da = new SqlDataAdapter("Select * From dbo.PERSONEL1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "PERSONEL1");
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
            cmd.CommandText = "INSERT INTO PERSONEL1(PERSONEL_ID, MARKA, MODEL, KM) VALUES (@PERSONEL_ID, @MARKA, @MODEL, @KM)";
            cmd.Parameters.AddWithValue("@PERSONEL_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@MARKA", textBox2.Text);
            cmd.Parameters.AddWithValue("@MODEL", textBox3.Text);
            cmd.Parameters.AddWithValue("@KM", int.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE PERSONEL1 SET marka=@MARKA, model=@MODEL, km=@KM WHERE id=@PERSONEL_ID";
            cmd.Parameters.AddWithValue("@PERSONEL_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@MARKA", textBox2.Text);
            cmd.Parameters.AddWithValue("@MODEL", textBox3.Text);
            cmd.Parameters.AddWithValue("@KM", textBox4.Text);
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
            cmd.CommandText = "SELECT * FROM PERSONEL1 WHERE PERSONEL_ID6=" + textBox1.Text;


            da.Fill(ds, "PERSONEL1");

            textBox1.Text = ds.Tables["PERSONEL1"].Rows[Convert.ToInt32(textBox1.Text)]["PERSONEL_ID"].ToString();
            textBox2.Text = ds.Tables["PERSONEL1"].Rows[Convert.ToInt32(textBox1.Text)]["MARKA"].ToString();
            textBox3.Text = ds.Tables["PERSONEL1"].Rows[Convert.ToInt32(textBox1.Text)]["MODEL"].ToString();
            textBox4.Text = ds.Tables["PERSONEL1"].Rows[Convert.ToInt32(textBox1.Text)]["KM"].ToString();

            con.Close();

        }
    }
}
