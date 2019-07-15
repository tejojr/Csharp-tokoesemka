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
    public partial class Databarang : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        Config con = new Config();
        static string Id, nama;
        public Databarang()
        {
            InitializeComponent();
        }

        private void Databarang_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tampil("");
            b_simpan.Enabled = false;
        }
        private void Tampil(string cari)
        {
            if (t_cari.TextLength == 0)
            {
                cmd = new SqlCommand("SELECT * FROM tb_barang", con.Buka());

            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM tb_barang where Nama like '%" + cari + "%' or Distributor like '%" + cari + "%' or Ketegori like '%" + cari + "%'", con.Buka());

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

            con.CUD("INSERT into tb_barang ( Nama,Distributor,HBeli,HJual,Kategori,Stok) values('" + t_nama.Text + "','" + t_dist.Text + "','" + t_beli.Text + "', '" + t_jual.Text + "', '" + t_kategori.Text + "', '"+t_stok.Text+"')", "Sukses Menambah Data");
            Tampil("");
            Clear();
        }
        void Clear()
        {
            t_id.Clear();
            t_nama.Clear();
            t_beli.Clear();
            t_dist.Clear();
            t_jual.Clear();
            t_kategori.Clear();
            t_stok.Clear();
            t_nama.Focus();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            b_add.Enabled = true;
            b_simpan.Enabled = false;
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_dist.Text = dr.Cells[2].Value.ToString();
            t_beli.Text = dr.Cells[3].Value.ToString();
            t_jual.Text = dr.Cells[4].Value.ToString();
            t_kategori.Text = dr.Cells[5].Value.ToString();
            t_stok.Text = dr.Cells[6].Value.ToString();
            Id = t_id.Text;
            nama = t_nama.Text;
            b_tambah.Enabled = true;
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            con.CUD("UPDATE tb_barang set Nama = '" + t_nama.Text + "',Distributor ='" + t_dist.Text + "',  HBeli = '" + t_beli.Text + "', HJual = '" + t_jual.Text + "', Kategori = '" + t_kategori.Text + "', Stok = '"+t_stok.Text+"'  where id = '" + t_id.Text + "'", "Sukses Mengubah Data");
            Tampil("");
            Clear();
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(t_cari.Text);
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.CUD("Delete from tb_barang where id = '" + t_id.Text + "'", "Sukses Menghapus Data");
            Tampil("");
        }
        public static string getID()
        {
            return Id;
        }
        public static string getNama()
        {
            return nama;
        }

        private void b_tambah_Click(object sender, EventArgs e)
        {
            new Update().Show();
        }
    }
}
