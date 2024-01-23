using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Aspose.Pdf;
using iText.Layout.Element;
using System.Drawing.Imaging;
using System.Drawing;

namespace Tooded
{
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Tooded_DB;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        DataTable dt_toode;
        Document document;
        int boonus;
        public Kassa()
        {
            InitializeComponent();
            Indenity();
        }

        public void Indenity()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Kasutajad", connect);

            connect.Open();

            SqlDataReader read = command.ExecuteReader();
            {
                if (read.HasRows)
                {
                    int kliendikaartColumnIndex = read.GetOrdinal("kliendikaart");

                    while (read.Read())
                    {
                        int identifyColumnIndex = read.GetOrdinal("identify");

                        if (!read.IsDBNull(identifyColumnIndex) && String.Equals(read.GetString(identifyColumnIndex), "Omanik", StringComparison.OrdinalIgnoreCase))
                        {
                            connect.Close();
                            NaitaAndmed();
                            return;
                        }
                        else if (!read.IsDBNull(identifyColumnIndex) && read.GetString(identifyColumnIndex) == "Müüja")
                        {
                            connect.Close();
                            NaitaAndmed();
                            return;
                        }
                        else if (!read.IsDBNull(identifyColumnIndex) && read.GetString(identifyColumnIndex) == "Klient")
                        {
                            connect.Close();
                            NaitaAndmedKlient();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Viga! Teil ei ole piisavalt õigusi.");
                        }
                    }

                    if (!read.IsDBNull(kliendikaartColumnIndex) && read.GetInt32(kliendikaartColumnIndex) == 1)
                    {
                        connect.Close();
                        boonus = 10;
                        
                    }
                }

                else
                {
                    MessageBox.Show("Viga! Admebaasis ei ole seda kasutaja.");
                }
            }

            connect.Close();
        }

        public void NaitaAndmedKlient()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT T.Toodenimetus, K.Kategooria_nimetus as Kategooria FROM Toodetabel as T INNER JOIN Kategooriatable as K on T.Kategooriad=K.Id", connect);
            dataGridView1.AutoResizeColumns();
            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;

            connect.Close();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus as Kategooria FROM Toodetabel as T INNER JOIN Kategooriatable as K on T.Kategooriad=K.Id", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            dataGridView1.AutoResizeColumns();
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.HeaderText = "Kategooria";
            combo_kat.Name = "KategooriaColumn";
            combo_kat.DataPropertyName = "Kategooria";
            HashSet<string> uniqueCategories = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string category = item["Kategooria"].ToString();
                if (!uniqueCategories.Contains(category))
                {
                    uniqueCategories.Add(category);
                    combo_kat.Items.Add(category);
                }
            }
            dataGridView1.Columns.Add(combo_kat);
            dataGridView1.Columns["KategooriaColumn"].Visible = false;

            connect.Close();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = System.Drawing.Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), dataGridView1.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pilt puudub" + ex.Message);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nimetus = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Toodenimetus"].Value);
                string Kokku = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Hind"].Value);

                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Kogus"].Value) > 0)
                {

                    connect.Open();
                    command = new SqlCommand("UPDATE Toodetabel SET Kogus = Kogus - 1 WHERE Toodenimetus = @nimetus;", connect);
                    command.Parameters.AddWithValue("@nimetus", nimetus);
                    command.ExecuteNonQuery();
                    connect.Close();
                    listBox.Items.Add(nimetus + " " + Kokku);
                    NaitaAndmed();
                }
                else
                {
                    MessageBox.Show("Kahjuks, toode on juba otsas.");
                }
            }
        }

        private void btnKustuta_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string nimetus = listBox.SelectedItem.ToString();

                connect.Open();
                command = new SqlCommand("UPDATE Toodetabel SET Kogus = Kogus + 1 WHERE Toodenimetus = @nimetus;", connect);
                command.Parameters.AddWithValue("@nimetus", nimetus);
                command.ExecuteNonQuery();
                connect.Close();
                listBox.Items.Remove(nimetus);
                NaitaAndmed();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                boonus = 10;
            }
            else
            {
                boonus = 0;
            }
        }

        private void btnSalv_Click(object sender, EventArgs e)
        {
            double kokku = 0;
            document = new Document();//using Aspose.Pdf
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode Hind"));
            foreach (string Products in listBox.Items)
            {
                string[] nime = Products.Split(' ');
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(nime[0] + " " + nime[1] + " euro"));
                kokku += Convert.ToInt32(nime[1]);
            }
            kokku = kokku - ((kokku * boonus) / 100);
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("========================"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Kokku on " + kokku + " euro"));

            Random rnd = new Random();
            string name = Convert.ToString(rnd.Next(20000));
            document.Save(@"..\..\Arved\" + name + ".pdf");
            document.Dispose();

            MessageBox.Show("Pdf fail oli salvestatud! Nimi on " + name + ".pdf");

        }
    }
}
