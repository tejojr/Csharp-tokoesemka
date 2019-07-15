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
    public partial class Akun : Form
    {
        SqlCommand cmd;
        Config con = new Config();
        SqlDataAdapter adapter;
        public Akun()
        {
            InitializeComponent();
        }
        void Clear()
        {
            t_id.Clear();
            t_nama.Clear();
            t_uname.Clear();
            t_pass.Clear();
            t_hp.Clear();
            t_nama.Focus();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_uname.Text = dr.Cells[2].Value.ToString();
            t_pass.Text = dr.Cells[3].Value.ToString();
            c_position.Text = dr.Cells[4].Value.ToString();
            t_hp.Text = dr.Cells[5].Value.ToString();
            b_add.Enabled = true;
            b_simpan.Enabled = false;

        }

        private void Akun_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tampil("");
            b_simpan.Enabled = false;
           
            


        }
        private void Tampil(string cari)
        {
            if(t_cari.TextLength == 0)
            {
                cmd = new SqlCommand("SELECT * FROM tb_user",con.Buka());

            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM tb_user where Nama like '%"+cari+ "%' or Username like '%" + cari + "%' or Position like '%" + cari + "%' or Hp like '%" + cari + "%'", con.Buka());

            }
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            b_simpan.Enabled = true;
            b_add.Enabled = false;
            Clear();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            b_simpan.Enabled = false;
            b_add.Enabled = true;
            
            con.CUD("INSERT into tb_user ( Nama,Username,Password,Position,Hp) values('"+t_nama.Text+ "','" + t_uname.Text + "','" + t_pass.Text + "', '" + c_position.Text + "', '" + t_hp.Text + "')", "Sukses Menambah Data");
            Tampil("");
            Clear();
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.CUD("Delete from tb_user where id = '"+t_id.Text+"'", "Sukses Menghapus Data");
            Tampil("");
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            con.CUD("UPDATE tb_user set Nama = '"+t_nama.Text+ "',Username ='" + t_uname.Text + "',  Password = '" + t_pass.Text + "', Position = '" + c_position.Text + "', Hp = '" + t_hp.Text + "'  where id = '" + t_id.Text + "'", "Sukses Mengubah Data");
            Tampil("");
            Clear();
        }
    }
}
