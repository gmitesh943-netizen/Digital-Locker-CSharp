using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalLocker
{
    public partial class RegisterForm : Form
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LockerDB.mdf;Integrated Security=True";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields ❌");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(constr);
                string query = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registered Successfully ✅");
                txtUsername.Clear();
                txtPassword.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e) 
        { 
        }

    }
}
