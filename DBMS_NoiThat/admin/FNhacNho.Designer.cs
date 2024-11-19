namespace DBMS_NoiThat.admin
{
    partial class FNhacNho
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNhacNho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1194, 518);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtNhacNho
            // 
            this.txtNhacNho.AutoSize = false;
            this.txtNhacNho.BackColor = System.Drawing.Color.Transparent;
            this.txtNhacNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhacNho.Location = new System.Drawing.Point(57, 52);
            this.txtNhacNho.Name = "txtNhacNho";
            this.txtNhacNho.Size = new System.Drawing.Size(455, 57);
            this.txtNhacNho.TabIndex = 1;
            this.txtNhacNho.Text = "THÔNG BÁO TỪ HỆ THỐNG";
            // 
            // FNhacNho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1285, 689);
            this.Controls.Add(this.txtNhacNho);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FNhacNho";
            this.Text = "FNhacNho";
            this.Load += new System.EventHandler(this.FNhacNho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtNhacNho;
    }
}