using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DigitalLocker
{
    public partial class UploadForm : Form
    {
        string imagePath = "";
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\LockerDB.mdf;Integrated Security=True";
        string username;

        public UploadForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void UploadForm_Load(object sender, EventArgs e) { }
        private void mainPanel_Paint(object sender, PaintEventArgs e) { }

        // File Browse
        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFilePath.Text = ofd.FileName;
        }

        // Image select via PictureBox click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.png;*.jpeg;*.bmp)|*.jpg;*.png;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        // SAVE button → FolderBrowserDialog → save file → DB insert → Dashboard par jao
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.Text == "" && imagePath == "")
                {
                    MessageBox.Show("Please select a file or image first ❗");
                    return;
                }

                //  Folder select karo - File Explorer dialog
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Select folder where you want to save the file";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() != DialogResult.OK)
                    return; // user cancel kare to koi kaam nai

                string selectedFolderPath = fbd.SelectedPath;

                SqlConnection con = new SqlConnection(constr);
                con.Open();

                DateTime uploadTime = DateTime.Now;

                //  FILE save
                if (txtFilePath.Text != "")
                {
                    string fileDest = Path.Combine(selectedFolderPath, Path.GetFileName(txtFilePath.Text));
                    File.Copy(txtFilePath.Text, fileDest, true);

                    string q = "INSERT INTO Files (Username, FilePath, DateAdded, IsDeleted) VALUES (@u, @f, @d, 0)";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@f", fileDest);
                    cmd.Parameters.AddWithValue("@d", uploadTime);
                    cmd.ExecuteNonQuery();
                }

                //  IMAGE save
                if (imagePath != "")
                {
                    string imgDest = Path.Combine(selectedFolderPath, Path.GetFileName(imagePath));
                    File.Copy(imagePath, imgDest, true);

                    string q = "INSERT INTO Files (Username, FilePath, DateAdded, IsDeleted) VALUES (@u, @f, @d, 0)";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@f", imgDest);
                    cmd.Parameters.AddWithValue("@d", uploadTime);
                    cmd.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("Upload Successful ✅\nSaved in: " + selectedFolderPath);

                // Reset form
                txtFilePath.Clear();
                pictureBox1.Image = null;
                imagePath = "";

                //  Dashboard par pachi jao
                DashboardForm db = new DashboardForm(username);
                db.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Back button → Dashboard par jao
        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm db = new DashboardForm(username);
            db.Show();
            this.Close();
        }
    }
}
