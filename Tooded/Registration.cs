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
    public partial class Registration : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Tooded_DB;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool on = false;

            if (ToString() == txtboxLog.Text && ToString() == txtboxPass.Text)
            {
                on = true;
            }
            
            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kasutajad(nimi, pass, email, identify) values(@nimi, @pass, @email, 'Klient')", connect);
                connect.Open();
                command.Parameters.AddWithValue("@nimi", txtboxLog.Text);
                command.Parameters.AddWithValue("@pass", txtboxPass.Text);
                command.Parameters.AddWithValue("@email", txtboxEmail.Text);
                command.ExecuteNonQuery();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Selline inimene on juba olemas!");
            }
        }
    }
}
