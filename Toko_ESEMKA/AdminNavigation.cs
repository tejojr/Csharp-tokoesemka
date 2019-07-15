using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_ESEMKA
{
    public partial class AdminNavigation : Form
    {
        public AdminNavigation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Dispose();
           
        }

        private void AdminNavigation_Load(object sender, EventArgs e)
        {
            t_nama.Text = Login.getNama();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Akun().Show();
            //this.Hide();
        }
    }
}
