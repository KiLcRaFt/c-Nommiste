using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tooded
{
    public partial class Login : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Tooded_DB;Integrated Security=True");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string log = txtbLog.Text.Trim();
            string pass = txtbPass.Text.Trim();

            SqlCommand command = new SqlCommand("SELECT * FROM Kasutajad WHERE nimi = @log AND pass = @pass", connect);

            command.Parameters.AddWithValue("@log", log);
            command.Parameters.AddWithValue("@pass", pass);

            connect.Open();

            SqlDataReader read = command.ExecuteReader();
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        int identifyColumnIndex = read.GetOrdinal("identify");

                        if (!read.IsDBNull(identifyColumnIndex) && String.Equals(read.GetString(identifyColumnIndex), "Omanik", StringComparison.OrdinalIgnoreCase))
                        {
                            this.Hide();
                            var form1 = new Form1();
                            form1.ShowDialog();
                            return;
                        }
                        else if (read.GetString(identifyColumnIndex) == "Müüja")
                        {
                            this.Hide();
                            var Kassa = new Kassa();
                            Kassa.ShowDialog();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Viga! Teil ei ole piisavalt õigusi.");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Viga! Admebaasis ei ole seda kasutaja.");
                }
            }

            connect.Close();

        }

    }
}
