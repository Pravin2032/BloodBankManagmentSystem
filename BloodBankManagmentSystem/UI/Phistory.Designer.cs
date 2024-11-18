namespace BloodBankManagmentSystem.UI
{
    partial class Phistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPHistory = new System.Windows.Forms.Label();
            this.dataGridViewPaymentHistory = new System.Windows.Forms.DataGridView();
            this.buttonPSearch = new System.Windows.Forms.Button();
            this.textBoxPSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelPHistory);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1255, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelPHistory
            // 
            this.labelPHistory.AutoSize = true;
            this.labelPHistory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPHistory.Location = new System.Drawing.Point(488, 18);
            this.labelPHistory.Name = "labelPHistory";
            this.labelPHistory.Size = new System.Drawing.Size(252, 41);
            this.labelPHistory.TabIndex = 0;
            this.labelPHistory.Text = "Payment History";
            // 
            // dataGridViewPaymentHistory
            // 
            this.dataGridViewPaymentHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentHistory.Location = new System.Drawing.Point(53, 172);
            this.dataGridViewPaymentHistory.Name = "dataGridViewPaymentHistory";
            this.dataGridViewPaymentHistory.RowHeadersWidth = 51;
            this.dataGridViewPaymentHistory.RowTemplate.Height = 24;
            this.dataGridViewPaymentHistory.Size = new System.Drawing.Size(1216, 460);
            this.dataGridViewPaymentHistory.TabIndex = 1;
            this.dataGridViewPaymentHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaymentHistory_CellContentClick);
            // 
            // buttonPSearch
            // 
            this.buttonPSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPSearch.Location = new System.Drawing.Point(332, 106);
            this.buttonPSearch.Name = "buttonPSearch";
            this.buttonPSearch.Size = new System.Drawing.Size(134, 47);
            this.buttonPSearch.TabIndex = 2;
            this.buttonPSearch.Text = "Search";
            this.buttonPSearch.UseVisualStyleBackColor = true;
            this.buttonPSearch.Click += new System.EventHandler(this.buttonPSearch_Click);
            // 
            // textBoxPSearch
            // 
            this.textBoxPSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPSearch.Location = new System.Drawing.Point(495, 115);
            this.textBoxPSearch.Name = "textBoxPSearch";
            this.textBoxPSearch.Size = new System.Drawing.Size(502, 30);
            this.textBoxPSearch.TabIndex = 3;
            // 
            // Phistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 663);
            this.Controls.Add(this.textBoxPSearch);
            this.Controls.Add(this.buttonPSearch);
            this.Controls.Add(this.dataGridViewPaymentHistory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phistory";
            this.Load += new System.EventHandler(this.Phistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPHistory;
        private System.Windows.Forms.DataGridView dataGridViewPaymentHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPSearch;
        private System.Windows.Forms.TextBox textBoxPSearch;
    }
}