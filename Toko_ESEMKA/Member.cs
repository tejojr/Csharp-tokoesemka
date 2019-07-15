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
    
    public partial class Member : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        Config con = new Config();
        public Member()
        {
            InitializeComponent();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tampil("");
            b_simpan.Enabled = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_alamat.Text = dr.Cells[2].Value.ToString();
            t_hp.Text = dr.Cells[3].Value.ToString();
            b_add.Enabled = true;
            b_simpan.Enabled = false;
        }
        private void Tampil(string cari)
        {
            if (t_cari.TextLength == 0)
            {
                cmd = new SqlCommand("SELECT * FROM tb_member", con.Buka());

            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM tb_member where Nama like '%" + cari + "%' or Alamat like '%" + cari + "%' or Hp like '%" + cari + "%' or TglGabung like '%" + cari + "%'", con.Buka());

            }
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            b_simpan.Enabled = true;
            b_add.Enabled = false;
            Clear();
        }
        void Clear()
        {
            t_id.Clear();
            t_nama.Clear();
            t_alamat.Clear();
           
            t_hp.Clear();
            t_nama.Focus();
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            b_simpan.Enabled = false;
            b_add.Enabled = true;

            
            con.CUD("INSERT into tb_member ( Nama,Alamat,Hp,TglGabung) values('" + t_nama.Text + "','" + t_alamat.Text + "','" + t_hp.Text + "','"+DateTime.Now.ToShortDateString()+"')", "Sukses Menambah Data");
            Tampil("");
            Clear();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.CUD("DELETE FROM tb_member where Id = '"+t_id.Text+"' ", "Sukses Menghapus Data");
            Tampil("");
            Clear();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            con.CUD("UPDATE tb_member set Nama = '"+t_nama.Text+"',Alamat= '"+t_alamat.Text+"',Hp = '"+t_hp.Text+"' where Id = '" + t_id.Text + "'", "Sukses Mengubah Data");
            Tampil("");
            Clear();
        }
    }
}
