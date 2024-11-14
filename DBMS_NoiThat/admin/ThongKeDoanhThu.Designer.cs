namespace DBMS_NoiThat.admin
{
    partial class ThongKeDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewDT = new System.Windows.Forms.DataGridView();
            this.labelDoanhThu = new System.Windows.Forms.Label();
            this.BieuDoCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1Ngay = new System.Windows.Forms.ComboBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButton1Thang = new System.Windows.Forms.RadioButton();
            this.radioButton1Ngay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSPBanChay = new System.Windows.Forms.Button();
            this.buttonDoanhThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDT
            // 
            this.dataGridViewDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDT.Location = new System.Drawing.Point(29, 353);
            this.dataGridViewDT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridViewDT.Name = "dataGridViewDT";
            this.dataGridViewDT.RowHeadersVisible = false;
            this.dataGridViewDT.RowHeadersWidth = 62;
            this.dataGridViewDT.RowTemplate.Height = 28;
            this.dataGridViewDT.Size = new System.Drawing.Size(1037, 191);
            this.dataGridViewDT.TabIndex = 7;
            // 
            // labelDoanhThu
            // 
            this.labelDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.labelDoanhThu.Location = new System.Drawing.Point(45, 306);
            this.labelDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDoanhThu.Name = "labelDoanhThu";
            this.labelDoanhThu.Size = new System.Drawing.Size(417, 31);
            this.labelDoanhThu.TabIndex = 6;
            this.labelDoanhThu.Text = "Tổng Doanh Thu:";
            this.labelDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BieuDoCot
            // 
            chartArea2.Name = "ChartArea1";
            this.BieuDoCot.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BieuDoCot.Legends.Add(legend2);
            this.BieuDoCot.Location = new System.Drawing.Point(664, 10);
            this.BieuDoCot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BieuDoCot.Name = "BieuDoCot";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SanPham";
            this.BieuDoCot.Series.Add(series2);
            this.BieuDoCot.Size = new System.Drawing.Size(402, 327);
            this.BieuDoCot.TabIndex = 10;
            this.BieuDoCot.Text = "San Pham";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(32, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(612, 196);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox1Ngay);
            this.groupBox3.Controls.Add(this.numericUpDownYear);
            this.groupBox3.Controls.Add(this.comboBoxMonth);
            this.groupBox3.Controls.Add(this.radioButtonNam);
            this.groupBox3.Controls.Add(this.radioButton1Thang);
            this.groupBox3.Controls.Add(this.radioButton1Ngay);
            this.groupBox3.Location = new System.Drawing.Point(50, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(504, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(378, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(236, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lọc theo:";
            // 
            // comboBox1Ngay
            // 
            this.comboBox1Ngay.FormattingEnabled = true;
            this.comboBox1Ngay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1Ngay.Location = new System.Drawing.Point(133, 21);
            this.comboBox1Ngay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1Ngay.Name = "comboBox1Ngay";
            this.comboBox1Ngay.Size = new System.Drawing.Size(42, 21);
            this.comboBox1Ngay.TabIndex = 5;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(412, 22);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownYear.TabIndex = 4;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(277, 21);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(42, 21);
            this.comboBoxMonth.TabIndex = 4;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.ForeColor = System.Drawing.Color.White;
            this.radioButtonNam.Location = new System.Drawing.Point(394, 57);
            this.radioButtonNam.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 3;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Năm";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButton1Thang
            // 
            this.radioButton1Thang.AutoSize = true;
            this.radioButton1Thang.ForeColor = System.Drawing.Color.White;
            this.radioButton1Thang.Location = new System.Drawing.Point(267, 57);
            this.radioButton1Thang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton1Thang.Name = "radioButton1Thang";
            this.radioButton1Thang.Size = new System.Drawing.Size(56, 17);
            this.radioButton1Thang.TabIndex = 2;
            this.radioButton1Thang.TabStop = true;
            this.radioButton1Thang.Text = "Tháng";
            this.radioButton1Thang.UseVisualStyleBackColor = true;
            // 
            // radioButton1Ngay
            // 
            this.radioButton1Ngay.AutoSize = true;
            this.radioButton1Ngay.ForeColor = System.Drawing.Color.White;
            this.radioButton1Ngay.Location = new System.Drawing.Point(116, 57);
            this.radioButton1Ngay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.radioButton1Ngay.Name = "radioButton1Ngay";
            this.radioButton1Ngay.Size = new System.Drawing.Size(59, 17);
            this.radioButton1Ngay.TabIndex = 1;
            this.radioButton1Ngay.TabStop = true;
            this.radioButton1Ngay.Text = "1 Ngày";
            this.radioButton1Ngay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSPBanChay);
            this.groupBox2.Controls.Add(this.buttonDoanhThu);
            this.groupBox2.Location = new System.Drawing.Point(102, 127);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(389, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // buttonSPBanChay
            // 
            this.buttonSPBanChay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.buttonSPBanChay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSPBanChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSPBanChay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSPBanChay.Location = new System.Drawing.Point(197, 15);
            this.buttonSPBanChay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSPBanChay.Name = "buttonSPBanChay";
            this.buttonSPBanChay.Size = new System.Drawing.Size(154, 23);
            this.buttonSPBanChay.TabIndex = 3;
            this.buttonSPBanChay.Text = "Sản Phẩm Bán Chạy";
            this.buttonSPBanChay.UseVisualStyleBackColor = false;
            this.buttonSPBanChay.Click += new System.EventHandler(this.buttonSPBanChay_Click);
            // 
            // buttonDoanhThu
            // 
            this.buttonDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.buttonDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoanhThu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDoanhThu.Location = new System.Drawing.Point(35, 15);
            this.buttonDoanhThu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDoanhThu.Name = "buttonDoanhThu";
            this.buttonDoanhThu.Size = new System.Drawing.Size(85, 23);
            this.buttonDoanhThu.TabIndex = 2;
            this.buttonDoanhThu.Text = "Thống kê";
            this.buttonDoanhThu.UseVisualStyleBackColor = false;
            this.buttonDoanhThu.Click += new System.EventHandler(this.buttonDoanhThu_Click);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1077, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BieuDoCot);
            this.Controls.Add(this.dataGridViewDT);
            this.Controls.Add(this.labelDoanhThu);
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoCot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDT;
        private System.Windows.Forms.Label labelDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoCot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSPBanChay;
        private System.Windows.Forms.Button buttonDoanhThu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButton1Thang;
        private System.Windows.Forms.RadioButton radioButton1Ngay;
        private System.Windows.Forms.ComboBox comboBox1Ngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}