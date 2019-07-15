using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Toko_ESEMKA
{
    class Config
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string strkoneksi = null;
        public SqlConnection Buka()
        {
            strkoneksi = "Server=DESKTOP-A45DNAG\\SQLEXPRESS;Database=toko_ESEMKA;Integrated Security= SSPI;";
            cnn = new SqlConnection(strkoneksi);
            try
            {
                cnn.Open();
                //MessageBox.Show("Sukses");

            }
            catch (Exception e)
            {
                MessageBox.Show("GaGaL " + e);
                
            }
            return cnn;
        }
        public SqlConnection Tutup()
        {
            cnn.Close();
            return cnn;
        }
        public int CUD (string query, string info)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
                MessageBox.Show(info,"Informasi");
            }
            catch (Exception e)
            {
                MessageBox.Show("GaGaL " + e);

            }
            finally
            {
                Tutup();
            }
           
            return 1;
        }
    }
}
