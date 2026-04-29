using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalLocker
{
    public partial class DashboardForm : Form
    {
        string username;

        public DashboardForm(string user)
        {
            InitializeComponent();
            username = user;
            lblWelcome.Text = " Welcome " + username;
        }

        private void btnUpload_MouseEnter(object sender, EventArgs e) { btnUpload.BackColor = ColorTranslator.FromHtml("#2563EB"); }
        private void btnUpload_MouseLeave(object sender, EventArgs e) { btnUpload.BackColor = ColorTranslator.FromHtml("#3B82F6"); }
        private void btnView_MouseEnter(object sender, EventArgs e)   { btnView.BackColor = ColorTranslator.FromHtml("#2563EB"); }
        private void btnView_MouseLeave(object sender, EventArgs e)   { btnView.BackColor = ColorTranslator.FromHtml("#3B82F6"); }
        private void btnLogout_MouseEnter(object sender, EventArgs e) { btnLogout.BackColor = ColorTranslator.FromHtml("#2563EB"); }
        private void btnLogout_MouseLeave(object sender, EventArgs e) { btnLogout.BackColor = ColorTranslator.FromHtml("#3B82F6"); }
        private void mainPanel_Paint(object sender, PaintEventArgs e) { }
        private void DashboardForm_Load(object sender, EventArgs e)   { }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            UploadForm f = new UploadForm(username);
            f.Show();
        }

        // 🔷 View button → directly ViewForm open thay
        private void btnView_Click(object sender, EventArgs e)
        {
            ViewForm f = new ViewForm(username);
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }
    }
}
