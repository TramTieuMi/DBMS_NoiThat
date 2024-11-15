namespace DBMS_NoiThat.user
{
    partial class FLichSu
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flwPnLichSu = new System.Windows.Forms.FlowLayoutPanel();
            this.ucLichSuMuaHang1 = new DBMS_NoiThat.UC.UCLichSuMuaHang();
            this.flwPnLichSu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(119, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(243, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // flwPnLichSu
            // 
            this.flwPnLichSu.AutoScroll = true;
            this.flwPnLichSu.Controls.Add(this.ucLichSuMuaHang1);
            this.flwPnLichSu.Location = new System.Drawing.Point(44, 128);
            this.flwPnLichSu.Name = "flwPnLichSu";
            this.flwPnLichSu.Size = new System.Drawing.Size(1276, 460);
            this.flwPnLichSu.TabIndex = 6;
            this.flwPnLichSu.Paint += new System.Windows.Forms.PaintEventHandler(this.flwPnLichSu_Paint_1);
            // 
            // ucLichSuMuaHang1
            // 
            this.ucLichSuMuaHang1.AutoScroll = true;
            this.ucLichSuMuaHang1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucLichSuMuaHang1.Location = new System.Drawing.Point(3, 3);
            this.ucLichSuMuaHang1.Name = "ucLichSuMuaHang1";
            this.ucLichSuMuaHang1.Size = new System.Drawing.Size(1273, 145);
            this.ucLichSuMuaHang1.TabIndex = 0;
            this.ucLichSuMuaHang1.Load += new System.EventHandler(this.ucLichSuMuaHang1_Load_1);
            // 
            // FLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 566);
            this.Controls.Add(this.flwPnLichSu);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "FLichSu";
            this.Text = "FLichSu";
            this.Load += new System.EventHandler(this.FLichSu_Load);
            this.flwPnLichSu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.FlowLayoutPanel flwPnLichSu;
        private UC.UCLichSuMuaHang ucLichSuMuaHang1;
    }
}