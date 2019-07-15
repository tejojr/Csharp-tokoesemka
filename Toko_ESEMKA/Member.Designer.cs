namespace Toko_ESEMKA
{
    partial class Member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_add = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_alamat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(582, 493);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(115, 65);
            this.b_add.TabIndex = 40;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(426, 493);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(115, 65);
            this.b_delete.TabIndex = 39;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(582, 402);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(115, 65);
            this.b_update.TabIndex = 38;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.Location = new System.Drawing.Point(426, 402);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(115, 65);
            this.b_simpan.TabIndex = 37;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = true;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(187, 527);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(164, 20);
            this.t_hp.TabIndex = 35;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(187, 425);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(164, 20);
            this.t_nama.TabIndex = 32;
            // 
            // t_id
            // 
            this.t_id.Enabled = false;
            this.t_id.Location = new System.Drawing.Point(187, 394);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(164, 20);
            this.t_id.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Hp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cari";
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(686, 115);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(140, 20);
            this.t_cari.TabIndex = 23;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 228);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Akun";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 94);
            this.panel1.TabIndex = 21;
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(187, 456);
            this.t_alamat.Multiline = true;
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(164, 65);
            this.t_alamat.TabIndex = 33;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 585);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_simpan);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_alamat);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t_alamat;
    }
}