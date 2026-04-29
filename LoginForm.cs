using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalLocker
{
    public partial class LoginForm : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LockerDB.mdf;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter Username & Password ");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(constr);
                string query = "SELECT * FROM Users WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Login Success ✅");
                    DashboardForm f = new DashboardForm(txtUsername.Text);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login ❌");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e) 
        { }
    }
}
