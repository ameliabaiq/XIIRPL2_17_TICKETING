namespace XIIRPL2_17_TICKETING.MasterForm
{
    partial class FrmMasterKodePromo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKodePromo = new TextBox();
            txtBerlakuSampai = new DateTimePicker();
            txtPersentaseDiskon = new NumericUpDown();
            txtMaksimumDiskon = new NumericUpDown();
            label7 = new Label();
            txtDeskripsi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 0;
            label1.Text = "Master Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(294, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 309);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Kode Promo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 336);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Berlaku Sampai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 367);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 4;
            label5.Text = "Presentase Diskon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 399);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 5;
            label6.Text = "Maksimum Diskon";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(169, 301);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(227, 23);
            txtKodePromo.TabIndex = 6;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(169, 330);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(227, 23);
            txtBerlakuSampai.TabIndex = 7;
            txtBerlakuSampai.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtPersentaseDiskon
            // 
            txtPersentaseDiskon.Location = new Point(169, 359);
            txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            txtPersentaseDiskon.Size = new Size(227, 23);
            txtPersentaseDiskon.TabIndex = 8;
            txtPersentaseDiskon.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(169, 391);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(227, 23);
            txtMaksimumDiskon.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(451, 309);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 10;
            label7.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(547, 301);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(100, 23);
            txtDeskripsi.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(507, 420);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(604, 420);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 207);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(780, 455);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label7);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPersentaseDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(txtKodePromo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            ((System.ComponentModel.ISupportInitialize)txtPersentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKodePromo;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtPersentaseDiskon;
        private NumericUpDown txtMaksimumDiskon;
        private Label label7;
        private TextBox txtDeskripsi;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}