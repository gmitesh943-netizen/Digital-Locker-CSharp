using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalLocker
{
    public partial class ViewForm : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LockerDB.mdf;Integrated Security=True";
        string username;

        public ViewForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // DataGridView styling
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#1E293B");
            dataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0F172A");
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#3B82F6");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            LoadData();
        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection(constr);

            // FilePath + DateAdded show karo
            string query = @"SELECT FilePath AS [File Path], 
                                    DateAdded AS [Upload Date & Time]
                             FROM Files 
                             WHERE Username=@u AND IsDeleted=0
                             ORDER BY DateAdded DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@u", username);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            // Column width
            if (dataGridView1.Columns.Count >= 2)
            {
                dataGridView1.Columns["File Path"].Width = 420;
                dataGridView1.Columns["Upload Date & Time"].Width = 180;
            }
        }

        // Open selected file
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Pehla ek file select karo ❗");
                return;
            }

            string path = dataGridView1.CurrentRow.Cells["File Path"].Value?.ToString();
            if (string.IsNullOrEmpty(path)) return;

            try { Process.Start(path); }
            catch { MessageBox.Show("File open nai thai.\nPath: " + path); }
        }

        // Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Pehla ek file select karo ❗");
                return;
            }

            string path = dataGridView1.CurrentRow.Cells["File Path"].Value?.ToString();
            if (string.IsNullOrEmpty(path)) return;

            DialogResult dr = MessageBox.Show("Aa file delete karvu che?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes) return;

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("UPDATE Files SET IsDeleted=1 WHERE FilePath=@p AND Username=@u", con);
            cmd.Parameters.AddWithValue("@p", path);
            cmd.Parameters.AddWithValue("@u", username);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted ✅");
            LoadData();
        }

        // Back → Dashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm db = new DashboardForm(username);
            db.Show();
            this.Close();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e) { }
    }
}
