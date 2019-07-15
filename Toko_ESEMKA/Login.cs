using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Toko_ESEMKA
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlDataReader reader;
        Config con = new Config();
        static string nama;
        string pos;
        static int id;
        public Login()
        {
            InitializeComponent();
        }
         private void Bersih()
        {
            t_uname.Clear();
            t_pass.Clear();
            t_uname.Focus();
        }
        public static string getNama()
        {
            return nama;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (t_uname.TextLength == 0 || t_pass.TextLength==0)
            {
                MessageBox.Show("Mohon Isi Semua TextBOX");
                Bersih();
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM tb_user where Username = '"+t_uname.Text+"' and Password = '"+t_pass.Text+"'",con.Buka());
                    using(reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id = (int)reader["Id"];
                                nama = (string)reader["Nama"];
                                pos = (string)reader["Position"];
                            }
                            if (pos.ToString().Equals("Admin"))
                            {
                                MessageBox.Show("Admin");
                                new AdminNavigation().Show();
                                this.Hide();
                            } else if (pos.ToString().Equals("Kasir"))
                            {
                                MessageBox.Show("Kasir");
                                new Kasirnavigation().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login Gagal");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Login Gagal");
                        }
                    }
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Tutup();
                    Bersih();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
              

               
        }
    }
}
