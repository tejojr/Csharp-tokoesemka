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
    public partial class Kasirnavigation : Form
    {
        public Kasirnavigation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Dispose();
        }

        private void Kasirnavigation_Load(object sender, EventArgs e)
        {
            t_nama.Text = Login.getNama();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Member().Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Databarang().Show();
        }
    }
}
