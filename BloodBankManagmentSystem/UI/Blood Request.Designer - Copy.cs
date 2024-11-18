namespace BloodBankManagmentSystem.UI
{
    partial class Blood_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Request));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBloodRequest = new System.Windows.Forms.Label();
            this.labelRequestorName = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDateOfRequest = new System.Windows.Forms.Label();
            this.labelReasonOfRequest = new System.Windows.Forms.Label();
            this.textBoxRequestorName = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxQuentity = new System.Windows.Forms.TextBox();
            this.textBoxReasonOfRequest = new System.Windows.Forms.TextBox();
            this.comboBoxBloodType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataOfRequest = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelBloodRequest);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1263, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelBloodRequest
            // 
            this.labelBloodRequest.AutoSize = true;
            this.labelBloodRequest.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodRequest.Location = new System.Drawing.Point(548, 15);
            this.labelBloodRequest.Name = "labelBloodRequest";
            this.labelBloodRequest.Size = new System.Drawing.Size(222, 41);
            this.labelBloodRequest.TabIndex = 0;
            this.labelBloodRequest.Text = "Blood Request";
            this.labelBloodRequest.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRequestorName
            // 
            this.labelRequestorName.AutoSize = true;
            this.labelRequestorName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestorName.Location = new System.Drawing.Point(263, 136);
            this.labelRequestorName.Name = "labelRequestorName";
            this.labelRequestorName.Size = new System.Drawing.Size(154, 25);
            this.labelRequestorName.TabIndex = 1;
            this.labelRequestorName.Text = "Requestor Name";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(263, 190);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(78, 25);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact";
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodType.Location = new System.Drawing.Point(263, 238);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(108, 25);
            this.labelBloodType.TabIndex = 3;
            this.labelBloodType.Text = "Blood Type";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(263, 296);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(127, 25);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity (ml)";
            // 
            // labelDateOfRequest
            // 
            this.labelDateOfRequest.AutoSize = true;
            this.labelDateOfRequest.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfRequest.Location = new System.Drawing.Point(260, 352);
            this.labelDateOfRequest.Name = "labelDateOfRequest";
            this.labelDateOfRequest.Size = new System.Drawing.Size(157, 25);
            this.labelDateOfRequest.TabIndex = 5;
            this.labelDateOfRequest.Text = "Date Of  Request";
            // 
            // labelReasonOfRequest
            // 
            this.labelReasonOfRequest.AutoSize = true;
            this.labelReasonOfRequest.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReasonOfRequest.Location = new System.Drawing.Point(263, 400);
            this.labelReasonOfRequest.Name = "labelReasonOfRequest";
            this.labelReasonOfRequest.Size = new System.Drawing.Size(174, 25);
            this.labelReasonOfRequest.TabIndex = 6;
            this.labelReasonOfRequest.Text = "Reason Of Request";
            // 
            // textBoxRequestorName
            // 
            this.textBoxRequestorName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestorName.Location = new System.Drawing.Point(559, 131);
            this.textBoxRequestorName.Name = "textBoxRequestorName";
            this.textBoxRequestorName.Size = new System.Drawing.Size(364, 30);
            this.textBoxRequestorName.TabIndex = 7;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(559, 185);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(364, 30);
            this.textBoxContact.TabIndex = 8;
            // 
            // textBoxQuentity
            // 
            this.textBoxQuentity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuentity.Location = new System.Drawing.Point(559, 291);
            this.textBoxQuentity.Name = "textBoxQuentity";
            this.textBoxQuentity.Size = new System.Drawing.Size(364, 30);
            this.textBoxQuentity.TabIndex = 9;
            // 
            // textBoxReasonOfRequest
            // 
            this.textBoxReasonOfRequest.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReasonOfRequest.Location = new System.Drawing.Point(559, 395);
            this.textBoxReasonOfRequest.Multiline = true;
            this.textBoxReasonOfRequest.Name = "textBoxReasonOfRequest";
            this.textBoxReasonOfRequest.Size = new System.Drawing.Size(364, 120);
            this.textBoxReasonOfRequest.TabIndex = 10;
            // 
            // comboBoxBloodType
            // 
            this.comboBoxBloodType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBloodType.FormattingEnabled = true;
            this.comboBoxBloodType.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBoxBloodType.Location = new System.Drawing.Point(559, 238);
            this.comboBoxBloodType.Name = "comboBoxBloodType";
            this.comboBoxBloodType.Size = new System.Drawing.Size(364, 31);
            this.comboBoxBloodType.TabIndex = 11;
            // 
            // dateTimePickerDataOfRequest
            // 
            this.dateTimePickerDataOfRequest.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataOfRequest.Location = new System.Drawing.Point(559, 347);
            this.dateTimePickerDataOfRequest.Name = "dateTimePickerDataOfRequest";
            this.dateTimePickerDataOfRequest.Size = new System.Drawing.Size(364, 30);
            this.dateTimePickerDataOfRequest.TabIndex = 12;
            this.dateTimePickerDataOfRequest.ValueChanged += new System.EventHandler(this.dateTimePickerDataOfRequest_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSave.Location = new System.Drawing.Point(360, 574);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 61);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonClear.Location = new System.Drawing.Point(559, 574);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(139, 61);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonHistory.Location = new System.Drawing.Point(751, 574);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(139, 61);
            this.buttonHistory.TabIndex = 15;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(934, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hospital";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Blood_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDataOfRequest);
            this.Controls.Add(this.comboBoxBloodType);
            this.Controls.Add(this.textBoxReasonOfRequest);
            this.Controls.Add(this.textBoxQuentity);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxRequestorName);
            this.Controls.Add(this.labelReasonOfRequest);
            this.Controls.Add(this.labelDateOfRequest);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelBloodType);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelRequestorName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Blood_Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood_Request";
            this.Load += new System.EventHandler(this.Blood_Request_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBloodRequest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRequestorName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDateOfRequest;
        private System.Windows.Forms.Label labelReasonOfRequest;
        private System.Windows.Forms.TextBox textBoxRequestorName;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxQuentity;
        private System.Windows.Forms.TextBox textBoxReasonOfRequest;
        private System.Windows.Forms.ComboBox comboBoxBloodType;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataOfRequest;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button button1;
    }
}