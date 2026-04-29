namespace DigitalLocker
{
    partial class UploadForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // mainPanel
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Controls.Add(this.lblFile);
            this.mainPanel.Controls.Add(this.txtFilePath);
            this.mainPanel.Controls.Add(this.btnFileBrowse);
            this.mainPanel.Controls.Add(this.lblImage);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.btnsave);
            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Location = new System.Drawing.Point(3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(479, 380);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "📂 Upload Files";
            // lblFile
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(30, 80);
            this.lblFile.Name = "lblFile";
            this.lblFile.Text = "Select File:";
            // txtFilePath
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtFilePath.ForeColor = System.Drawing.Color.White;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.Location = new System.Drawing.Point(30, 105);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(300, 26);
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.TabIndex = 1;
            // btnFileBrowse
            this.btnFileBrowse.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnFileBrowse.FlatAppearance.BorderSize = 0;
            this.btnFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileBrowse.ForeColor = System.Drawing.Color.White;
            this.btnFileBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFileBrowse.Location = new System.Drawing.Point(340, 103);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnFileBrowse.Text = "📁 Browse";
            this.btnFileBrowse.UseVisualStyleBackColor = false;
            this.btnFileBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // lblImage
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point(30, 155);
            this.lblImage.Name = "lblImage";
            this.lblImage.Text = "Select Image (click box):";
            // pictureBox1
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(30, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // btnsave
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(30, 310);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(160, 45);
            this.btnsave.Text = "💾 Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(210, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 45);
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // UploadForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Files";
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFileBrowse;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnBack;
    }
}
