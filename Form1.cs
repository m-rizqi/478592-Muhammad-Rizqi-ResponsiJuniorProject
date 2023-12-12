using Npgsql;
using System.Data;

namespace Responsi_2
{
    public partial class Form1 : Form
    {
        private List<string> departemenIds = new List<string>()
        {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"
        };

        public Form1()
        {
            InitializeComponent();

            foreach (string id in departemenIds)
            {
                tbDepartemen.AutoCompleteCustomSource.Add(id);
                tbDepartemen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbDepartemen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private NpgsqlConnection conn;
        // Replace with your database connection string
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi2;";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                sql = "select * from public.karyawan join public.departemen on public.karyawan.id_dep = public.departemen.id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"insert into public.karyawan(id_karyawan, nama, id_dep) values(2, :nama_karyawan, :id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama_karyawan", tbName.Text);
                cmd.Parameters.AddWithValue("id_dep", 1);
                cmd.ExecuteScalar();
                MessageBox.Show("Data Karyawan Berhasil Ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                sql = @"update public.karyawan set nama=:nama_karyawan, id_dep=:id_dep where id_karyawan=:id_karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("nama_karyawan", tbName.Text);
                cmd.Parameters.AddWithValue("id_dep", 2);
                cmd.ExecuteScalar();
                MessageBox.Show("Data Karyawan Berhasil Diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvList.Rows[e.RowIndex];
                tbName.Text = r.Cells["nama"].Value.ToString();
                tbDepartemen.Text = r.Cells["nama_dep"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Apakah Anda yakin ingin menghapus data" + r.Cells["nama"].Value.ToString() + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
