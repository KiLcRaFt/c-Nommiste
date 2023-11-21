using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaKategooriad();
            NaitaAndmed();
        }

        private void Lisa_Kat_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            command = new SqlCommand("INSERT INTO Kategooriatable(Kategooria_nimetus) values(@Kat)");
            command.Parameters.AddWithValue("@Kat", Kat_Box.Text);
            command.ExecuteNonQuery();
            Kat_Box.Items.Clear();
            NaitaKategooriad();
            connect.Close();
        }
        public void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooriatable", connect);
            DataTable dt_kategooria = new DataTable();
            adapter_kategooria.Fill(dt_kategooria);
            foreach (DataRow nimetus in dt_kategooria.Rows)
            {
                Kat_Box.Items.Add(nimetus["Kategooria_nimetus"]);
            }
            connect.Close();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetabel", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView2.DataSource = dt_toode;
            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
