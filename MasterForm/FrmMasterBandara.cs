using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL2_17_TICKETING.MasterForm
{
    public partial class FrmMasterBandara : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterBandara()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            koneksi.conn.Open();
            String sql = "INSERT INTO tbl_bandara (nama,kodeiata,kota,negaraid,jumlahterminal,alamat) VALUES ('" + txtNama.Text + "','" + txtKodeIATA.Text + "','" + txtKota.Text + "','" + txtNegara.Text + "','" + txtJumlahTerminal.Text + "','" + txtAlamat.Text + "')";
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Simpan Data Bandara");
            koneksi.conn.Close();

            }

            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
        }

        private void FrmMasterBandara_Load(object sender, EventArgs e)
        {
            view_data();
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_bandara", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_bandara WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    koneksi.conn.Close();
                }

            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
