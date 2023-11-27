namespace XIIRPL2_17_TICKETING.MasterForm
{
    partial class FrmMasterMaskapai
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            txtPerusahaan = new TextBox();
            txtJumlahKru = new NumericUpDown();
            label6 = new Label();
            txtDeskripsi = new TextBox();
            button1 = new Button();
            btnSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(783, 238);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 1;
            label1.Text = "Master Maskapai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(279, 15);
            label2.TabIndex = 2;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 333);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 364);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "Perusahaan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 397);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "Jumlah Kru";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(168, 333);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(203, 23);
            txtNama.TabIndex = 6;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(168, 364);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(203, 23);
            txtPerusahaan.TabIndex = 7;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(168, 395);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(203, 23);
            txtJumlahKru.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 333);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 9;
            label6.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(560, 333);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(155, 23);
            txtDeskripsi.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(528, 435);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(640, 435);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(807, 470);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label6);
            Controls.Add(txtJumlahKru);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private TextBox txtNama;
        private TextBox txtPerusahaan;
        private NumericUpDown txtJumlahKru;
        private TextBox txtDeskripsi;
        private Button btnSimpan;
    }
}