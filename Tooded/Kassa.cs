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

namespace Tooded
{
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Tooded_DB;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        DataTable dt_toode;
        Document document;
        public Kassa()
        {
            InitializeComponent();
            NaitaAndmed();
        }

        private void btnOtsi_Click(object sender, EventArgs e)
        {

        }

        private void txtOtsi_TextChanged(object sender, EventArgs e)
        {
            //if (dt_toode != null)
            //{
            //    DataView dv = dt_toode.DefaultView;
            //    dv.RowFilter = $"Toodenimetus LIKE '{txtOtsi.Text}%'";

            //    dataGridView1.DataSource = dv;
            //    dataGridView1.ClearSelection();

            //    // Select the first matching row, if any
            //    if (dataGridView1.Rows.Count > 0)
            //    {
            //        dataGridView1.Rows[0].Selected = true;
            //        dataGridView1.FirstDisplayedScrollingRowIndex = 0; // Scroll to the selected row
            //    }

            //    dataGridView1.Refresh();
            //}
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nimetus = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Toodenimetus"].Value);

                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Kogus"].Value) > 0)
                {

                    connect.Open();
                    command = new SqlCommand("UPDATE Toodetabel SET Kogus = Kogus - 1 WHERE Toodenimetus = @nimetus;", connect);
                    command.Parameters.AddWithValue("@nimetus", nimetus);
                    command.ExecuteNonQuery();
                    connect.Close();
                    listBox.Items.Add(nimetus);
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

        private void btnSalv_Click(object sender, EventArgs e)
        {
            document = new Document();//using Aspose.Pdf
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Toode  Hind  Kogus Kokku"));
            foreach (string Products in listBox.Items)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(Products));
            }

            Random rnd = new Random();
            string name = Convert.ToString(rnd.Next(20000));
            document.Save(@"..\..\Arved\"+name+".pdf");
            document.Dispose();

            MessageBox.Show("Pdf fail oli salvestatud! Nimi on "+name+".pdf");

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
    }
}
