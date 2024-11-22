namespace DBMS_NoiThat.admin
{
    partial class LoyaltyCustomerAdmin
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
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblLoyaltyTier = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.pbRewardImage = new System.Windows.Forms.PictureBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbRewardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(43, 462);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(158, 26);
            this.txtCustomerId.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(344, 428);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(36, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Tên";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoyaltyTier
            // 
            this.lblLoyaltyTier.AutoSize = true;
            this.lblLoyaltyTier.Location = new System.Drawing.Point(443, 429);
            this.lblLoyaltyTier.Name = "lblLoyaltyTier";
            this.lblLoyaltyTier.Size = new System.Drawing.Size(35, 20);
            this.lblLoyaltyTier.TabIndex = 2;
            this.lblLoyaltyTier.Text = "Tier";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(43, 528);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 49);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(39, 429);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(230, 20);
            this.lblThongBao.TabIndex = 5;
            this.lblThongBao.Text = "Nhập mã hoặc tên khách hàng ";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(550, 428);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerId.TabIndex = 6;
            this.lblCustomerId.Text = "Mã Khách hàng";
            // 
            // pbRewardImage
            // 
            this.pbRewardImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRewardImage.Image = global::DBMS_NoiThat.Properties.Resources._2192009;
            this.pbRewardImage.Location = new System.Drawing.Point(815, 79);
            this.pbRewardImage.Name = "pbRewardImage";
            this.pbRewardImage.Size = new System.Drawing.Size(538, 323);
            this.pbRewardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRewardImage.TabIndex = 7;
            this.pbRewardImage.TabStop = false;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(33, 79);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 62;
            this.dataGridViewCustomers.RowTemplate.Height = 28;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(682, 323);
            this.dataGridViewCustomers.TabIndex = 8;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // LoyaltyCustomerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 863);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.pbRewardImage);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLoyaltyTier);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerId);
            this.Name = "LoyaltyCustomerAdmin";
            this.Text = "LoyaltyCustomer";
            this.Load += new System.EventHandler(this.LoyaltyCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRewardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblLoyaltyTier;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.PictureBox pbRewardImage;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
    }
}