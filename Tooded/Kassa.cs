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
    public partial class Kassa : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Tooded_DB;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Kassa()
        {
            InitializeComponent();
            NaitaAndmed();
        }


        public void NaitaAndmed()
        {
            connect.Open();

            DataTable dt_toode = new DataTable();
            SqlDataAdapter adapter_toode = new SqlDataAdapter("SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus as Kategooria FROM Toodetabel as T INNER JOIN Kategooriatable as K on T.Kategooriad=K.Id", connect);
            adapter_toode.Fill(dt_toode);
            //dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;

            connect.Close();
        }
    }
}
