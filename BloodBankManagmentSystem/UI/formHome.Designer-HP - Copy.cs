namespace BloodBankManagmentSystem
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonBloodRequest = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonHospital = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonBloodStock = new System.Windows.Forms.Button();
            this.buttonDonor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1092, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // UserButton
            // 
            this.UserButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton.ForeColor = System.Drawing.Color.Black;
            this.UserButton.Location = new System.Drawing.Point(12, 128);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(215, 53);
            this.UserButton.TabIndex = 11;
            this.UserButton.Text = "Users";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Location = new System.Drawing.Point(0, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1134, 71);
            this.panel8.TabIndex = 12;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // buttonBloodRequest
            // 
            this.buttonBloodRequest.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodRequest.ForeColor = System.Drawing.Color.Black;
            this.buttonBloodRequest.Location = new System.Drawing.Point(12, 366);
            this.buttonBloodRequest.Name = "buttonBloodRequest";
            this.buttonBloodRequest.Size = new System.Drawing.Size(215, 50);
            this.buttonBloodRequest.TabIndex = 17;
            this.buttonBloodRequest.Text = "Blood Request";
            this.buttonBloodRequest.UseVisualStyleBackColor = true;
            this.buttonBloodRequest.Click += new System.EventHandler(this.buttonBloodRequest_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.ForeColor = System.Drawing.Color.Black;
            this.buttonSupplier.Location = new System.Drawing.Point(12, 251);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(215, 53);
            this.buttonSupplier.TabIndex = 16;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonHospital
            // 
            this.buttonHospital.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHospital.ForeColor = System.Drawing.Color.Black;
            this.buttonHospital.Location = new System.Drawing.Point(12, 477);
            this.buttonHospital.Name = "buttonHospital";
            this.buttonHospital.Size = new System.Drawing.Size(215, 45);
            this.buttonHospital.TabIndex = 15;
            this.buttonHospital.Text = "Hospital";
            this.buttonHospital.UseVisualStyleBackColor = true;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.ForeColor = System.Drawing.Color.Black;
            this.buttonPayment.Location = new System.Drawing.Point(12, 422);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(215, 49);
            this.buttonPayment.TabIndex = 15;
            this.buttonPayment.Text = "Payment";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonBloodStock
            // 
            this.buttonBloodStock.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBloodStock.ForeColor = System.Drawing.Color.Black;
            this.buttonBloodStock.Location = new System.Drawing.Point(12, 310);
            this.buttonBloodStock.Name = "buttonBloodStock";
            this.buttonBloodStock.Size = new System.Drawing.Size(215, 50);
            this.buttonBloodStock.TabIndex = 14;
            this.buttonBloodStock.Text = "Blood Stock";
            this.buttonBloodStock.UseVisualStyleBackColor = true;
            this.buttonBloodStock.Click += new System.EventHandler(this.buttonBloodStock_Click);
            // 
            // buttonDonor
            // 
            this.buttonDonor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDonor.ForeColor = System.Drawing.Color.Black;
            this.buttonDonor.Location = new System.Drawing.Point(12, 187);
            this.buttonDonor.Name = "buttonDonor";
            this.buttonDonor.Size = new System.Drawing.Size(215, 58);
            this.buttonDonor.TabIndex = 12;
            this.buttonDonor.Text = "Donors";
            this.buttonDonor.UseVisualStyleBackColor = true;
            this.buttonDonor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 663);
            this.Controls.Add(this.buttonHospital);
            this.Controls.Add(this.buttonBloodRequest);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonSupplier);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.buttonBloodStock);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.buttonDonor);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonDonor;
        private System.Windows.Forms.Button buttonBloodStock;
        private System.Windows.Forms.Button buttonHospital;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonBloodRequest;
    }
}

