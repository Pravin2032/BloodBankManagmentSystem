namespace BloodBankManagmentSystem.UI
{
    partial class AllReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAllReports = new System.Windows.Forms.Label();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonDonors = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonBloodStockSupplier = new System.Windows.Forms.Button();
            this.buttonBloodRequest = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelAllReports);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 82);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1252, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelAllReports
            // 
            this.labelAllReports.AutoSize = true;
            this.labelAllReports.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllReports.Location = new System.Drawing.Point(547, 16);
            this.labelAllReports.Name = "labelAllReports";
            this.labelAllReports.Size = new System.Drawing.Size(191, 45);
            this.labelAllReports.TabIndex = 0;
            this.labelAllReports.Text = "All Reports";
            this.labelAllReports.Click += new System.EventHandler(this.labelAllReports_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsers.Location = new System.Drawing.Point(552, 141);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(184, 66);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonDonors
            // 
            this.buttonDonors.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDonors.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonors.Location = new System.Drawing.Point(272, 294);
            this.buttonDonors.Name = "buttonDonors";
            this.buttonDonors.Size = new System.Drawing.Size(184, 66);
            this.buttonDonors.TabIndex = 2;
            this.buttonDonors.Text = "Donors";
            this.buttonDonors.UseVisualStyleBackColor = false;
            this.buttonDonors.Click += new System.EventHandler(this.buttonDonors_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSupplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.Location = new System.Drawing.Point(552, 294);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(184, 66);
            this.buttonSupplier.TabIndex = 3;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.UseVisualStyleBackColor = false;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonBloodStockSupplier
            // 
            this.buttonBloodStockSupplier.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBloodStockSupplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodStockSupplier.Location = new System.Drawing.Point(845, 420);
            this.buttonBloodStockSupplier.Name = "buttonBloodStockSupplier";
            this.buttonBloodStockSupplier.Size = new System.Drawing.Size(184, 101);
            this.buttonBloodStockSupplier.TabIndex = 4;
            this.buttonBloodStockSupplier.Text = "Blood Stock Supplier";
            this.buttonBloodStockSupplier.UseVisualStyleBackColor = false;
            this.buttonBloodStockSupplier.Click += new System.EventHandler(this.buttonBloodStock_Click);
            // 
            // buttonBloodRequest
            // 
            this.buttonBloodRequest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBloodRequest.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodRequest.Location = new System.Drawing.Point(249, 436);
            this.buttonBloodRequest.Name = "buttonBloodRequest";
            this.buttonBloodRequest.Size = new System.Drawing.Size(227, 85);
            this.buttonBloodRequest.TabIndex = 5;
            this.buttonBloodRequest.Text = "Blood Request";
            this.buttonBloodRequest.UseVisualStyleBackColor = false;
            this.buttonBloodRequest.Click += new System.EventHandler(this.buttonBloodRequest_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPayment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.Location = new System.Drawing.Point(845, 294);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(184, 66);
            this.buttonPayment.TabIndex = 6;
            this.buttonPayment.Text = "Payment";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 101);
            this.button1.TabIndex = 7;
            this.button1.Text = "Blood Stock Donor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonBloodRequest);
            this.Controls.Add(this.buttonBloodStockSupplier);
            this.Controls.Add(this.buttonSupplier);
            this.Controls.Add(this.buttonDonors);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllReport";
            this.Load += new System.EventHandler(this.AllReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAllReports;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonDonors;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonBloodStockSupplier;
        private System.Windows.Forms.Button buttonBloodRequest;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}