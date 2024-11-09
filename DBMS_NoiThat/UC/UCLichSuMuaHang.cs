using DBMS_NoiThat.Entity;
using DBMS_NoiThat.user;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.UC
{
    public partial class UCLichSuMuaHang : UserControl
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        string tensp;
        string mota;
        string soluong;
        string mau;
        string trangthai;
        string ngaymua;
        string tongtien;


        private FlowLayoutPanel flpProducts;
        public UCLichSuMuaHang()
        {
            InitializeComponent();
           
            // Khởi tạo FlowLayoutPanel (nếu chưa có)
            flpProducts = new FlowLayoutPanel();
            flpProducts.Dock = DockStyle.Fill;
            this.Controls.Add(flpProducts);
            
        }

        LichSuMuaHang LichSuMua;
        public UCLichSuMuaHang(LichSuMuaHang LichSuMua)
        {
            InitializeComponent();
            this.LichSuMua = LichSuMua;
            // nganh = lichSuNTD.Nganh;
            // Khởi tạo FlowLayoutPanel nếu chưa có
            flpProducts = new FlowLayoutPanel();
            flpProducts.Dock = DockStyle.Fill;
            this.Controls.Add(flpProducts);


            //txtTenSP.Text = LichSuMua.TenSanPham.ToString();

            //txtMoTa.Text = $"Mô tả: {LichSuMua.MoTa.ToString()}";

            //txtMau.Text = "Màu sắc: " + LichSuMua.Mau.ToString();

            //txtSoLuong.Text = "Số lượng: "+LichSuMua.SoLuong.ToString();

            //txtNgayMua.Text = "Ngày mua hàng: " + LichSuMua.NgayMua.ToString();

            //txtTrangThai.Text = "Trạng thái: " + LichSuMua.TrangThai.ToString();

            //  txtThanhTien.Text = "Tổng tiền " + LichSuMua.ThanhTien.ToString();
            //CK_Chon = new CheckBox();
            //CK_Chon.Checked = gioHang.Check;

            // Thêm sản phẩm vào FlowLayoutPanel nếu có
           
        }
        // Phương thức để thiết lập thông tin đơn hàng
        public void SetOrderInfo(object orderId, DateTime orderDate, string status)
        {
            //lblOrderID.Text = $"Mã đơn hàng: {orderId}";
            //txtNgayMua.Text = $"Ngày mua: {orderDate.ToShortDateString()}";
            //txtTrangThai.Text = $"Trạng thái: {status}";
        }

        // Phương thức để thêm sản phẩm vào danh sách
        public void AddProduct(LichSuMuaHang product)
        {
            // Tạo Panel để chứa thông tin của từng sản phẩm
            Panel pnlProduct = new Panel();
            pnlProduct.AutoSize = true;
            pnlProduct.BorderStyle = BorderStyle.FixedSingle;
            pnlProduct.BackColor = Color.WhiteSmoke; // Màu nền nhẹ nhàng
            pnlProduct.Padding = new Padding(10); // Khoảng cách bên trong Panel
            pnlProduct.Margin = new Padding(10); // Khoảng cách giữa các Panel

            // Tạo và thêm các Label vào Panel
            Label lblTenSP = new Label();
            lblTenSP.Text = $"Tên sản phẩm: {product.TenSanPham}";
            lblTenSP.AutoSize = true;
            pnlProduct.Controls.Add(lblTenSP);

            Label lblMoTa = new Label();
            lblMoTa.Text = $"Mô tả: {product.MoTa}";
            lblMoTa.AutoSize = true;
            lblMoTa.Top = lblTenSP.Bottom + 5;
            pnlProduct.Controls.Add(lblMoTa);

            Label lblMau = new Label();
            lblMau.Text = $"Màu sắc: {product.Mau}";
            lblMau.AutoSize = true;
            lblMau.Top = lblMoTa.Bottom + 5;
            pnlProduct.Controls.Add(lblMau);

            Label lblSoLuong = new Label();
            lblSoLuong.Text = $"Số lượng: {product.SoLuong}";
            lblSoLuong.AutoSize = true;
            lblSoLuong.Top = lblMau.Bottom + 5;
            pnlProduct.Controls.Add(lblSoLuong);

            Label lblNgayMua = new Label();
            lblNgayMua.Text = $"Ngày mua hàng: {product.NgayMua.ToShortDateString()}";
            lblNgayMua.AutoSize = true;
            lblNgayMua.Top = lblSoLuong.Bottom + 5;
            pnlProduct.Controls.Add(lblNgayMua);

            Label lblTrangThai = new Label();
            lblTrangThai.Text = $"Trạng thái: {product.TrangThai}";
            lblTrangThai.AutoSize = true;
            lblTrangThai.Top = lblNgayMua.Bottom + 5;
            pnlProduct.Controls.Add(lblTrangThai);

            // Thêm Panel vào FlowLayoutPanel
            flpProducts.Controls.Add(pnlProduct);


        }
        

        private void UCLichSuDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
