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
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Tooded_DB;Integrated Security=True");


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
            bool on = false;
            foreach(var item in Kat_Box.Items)
            {
                if (item.ToString() == Kat_Box.Text)
                {
                    on = true;
                }
            }
            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kategooriatable(Kategooria_nimetus) values(@Kat)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@Kat", Kat_Box.Text);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Selline kategooriat on juba olemas!");
            }
        }
        public void NaitaKategooriad()
        {
            Kat_Box.Items.Clear();
            Kat_Box.Text = "";
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooriatable", connect);
            DataTable dt_kategooria = new DataTable();
            adapter_kategooria.Fill(dt_kategooria);
            foreach (DataRow nimetus in dt_kategooria.Rows)
            {
                if (!Kat_Box.Items.Contains(nimetus["Kategooria_nimetus"]))
                {
                    Kat_Box.Items.Add(nimetus["Kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("DELETE FROM Kategooriatable WHERE Id = @id", connect);
                    command.Parameters.AddWithValue("@id", nimetus["Id"]);
                    command.ExecuteNonQuery();
                }
            }
            connect.Close();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            ComboBox comboBox = new ComboBox();
            DataTable dt_toode = new DataTable();
            DataTable table = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus as Kategooria FROM Toodetabel as T INNER JOIN Kategooriatable as K on T.Kategooriad=K.Id", connect);
            adapter_toode.Fill(dt_toode);
            table.Columns.Add("Toode");
            table.Columns.Add("Kogus");
            table.Columns.Add("Hind");
            table.Columns.Add("Pilt");
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            foreach (DataRow item in dt_toode.Rows)
            {
                if (!combo_kat.Items.Contains(item["Kategooria"]))
                {
                    combo_kat.Items.Add(item["Kategooria"]);
                }
            }
            foreach (DataRow item in dt_toode.Rows)
            {
                table.Rows.Add(item["Toodenimetus"], item["Kogus"], item["Hind"], item["Pilt"]);
            }
            dataGridView2.DataSource = table;
            dataGridView2.Columns.Add(combo_kat);
            connect.Close();
        }

        private void KustutaKat_Click(object sender, EventArgs e)
        {
            if(Kat_Box.SelectedItem != null)
            {
                string val_kat = Kat_Box.SelectedItem.ToString();

                command = new SqlCommand("DELETE FROM Kategooriatable WHERE Kategooria_nimetus = @Kat", connect);
                connect.Open();
                command.Parameters.AddWithValue("@Kat", val_kat);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
        }

        int Id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(ToodeBox.Text.Trim()!=string.Empty && KogusBox.Text.Trim()!=string.Empty&&HindBox.Text.Trim()!=string.Empty && Kat_Box.SelectedItem != null)
            {
                try
                {
                    connect.Open();

                    command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus=@Kat", connect);
                    command.Parameters.AddWithValue("@Kat", Kat_Box.Text);
                    command.ExecuteNonQuery();
                    Id = Convert.ToInt32(command.ExecuteScalar());

                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, Kategooriad) VALUES (@toode, @kogus ,@hind, @pilt, @kat)", connect);
                    command.Parameters.AddWithValue("@toode", ToodeBox.Text);
                    command.Parameters.AddWithValue("@kogus", KogusBox.Text);
                    command.Parameters.AddWithValue("@hind", HindBox.Text);
                    command.Parameters.AddWithValue("@pilt", ToodeBox.Text + ".jpg");
                    command.Parameters.AddWithValue("@kat", Id);
                    
                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }

        private void KogusBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void HindBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
