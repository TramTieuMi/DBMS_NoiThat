namespace DBMS_NoiThat.UC
{
    partial class UCDiscount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_LiDo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_MGG = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LB_GTG = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BTN_AD = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LB_LiDo
            // 
            this.LB_LiDo.BackColor = System.Drawing.Color.Transparent;
            this.LB_LiDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LiDo.Location = new System.Drawing.Point(15, 10);
            this.LB_LiDo.Name = "LB_LiDo";
            this.LB_LiDo.Size = new System.Drawing.Size(134, 22);
            this.LB_LiDo.TabIndex = 0;
            this.LB_LiDo.Text = "guna2HtmlLabel1";
            // 
            // LB_MGG
            // 
            this.LB_MGG.BackColor = System.Drawing.Color.Transparent;
            this.LB_MGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MGG.Location = new System.Drawing.Point(15, 48);
            this.LB_MGG.Name = "LB_MGG";
            this.LB_MGG.Size = new System.Drawing.Size(134, 22);
            this.LB_MGG.TabIndex = 1;
            this.LB_MGG.Text = "guna2HtmlLabel2";
            // 
            // LB_GTG
            // 
            this.LB_GTG.BackColor = System.Drawing.Color.Transparent;
            this.LB_GTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_GTG.Location = new System.Drawing.Point(230, 49);
            this.LB_GTG.Name = "LB_GTG";
            this.LB_GTG.Size = new System.Drawing.Size(134, 22);
            this.LB_GTG.TabIndex = 2;
            this.LB_GTG.Text = "guna2HtmlLabel3";
            // 
            // BTN_AD
            // 
            this.BTN_AD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_AD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_AD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTN_AD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_AD.ForeColor = System.Drawing.Color.White;
            this.BTN_AD.Location = new System.Drawing.Point(472, 20);
            this.BTN_AD.Name = "BTN_AD";
            this.BTN_AD.Size = new System.Drawing.Size(119, 41);
            this.BTN_AD.TabIndex = 3;
            this.BTN_AD.Text = "Áp Dụng";
            this.BTN_AD.Click += new System.EventHandler(this.BTN_AD_Click);
            // 
            // UCDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_AD);
            this.Controls.Add(this.LB_GTG);
            this.Controls.Add(this.LB_MGG);
            this.Controls.Add(this.LB_LiDo);
            this.Name = "UCDiscount";
            this.Size = new System.Drawing.Size(615, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LB_LiDo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_MGG;
        private Guna.UI2.WinForms.Guna2HtmlLabel LB_GTG;
        private Guna.UI2.WinForms.Guna2Button BTN_AD;
    }
}
