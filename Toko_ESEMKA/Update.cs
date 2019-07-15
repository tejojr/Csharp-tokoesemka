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
    public partial class Update : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string no;
        
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            no = Databarang.getID();
            id.Text = Databarang.getNama();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {

        }
    }
}
