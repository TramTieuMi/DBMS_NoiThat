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
        //private FlowLayoutPanel flwPnLichSu;
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
            //this.AutoSize = true; // Tự động giãn theo nội dung
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // Điều chỉnh cả chiều rộng và chiều cao
            this.Controls.Add(flpProducts);
            
        }

        LichSuMuaHang LichSuMua;
        public UCLichSuMuaHang(LichSuMuaHang LichSuMua)
        {
            InitializeComponent();
            this.LichSuMua = LichSuMua;
            flpProducts = new FlowLayoutPanel();
            flpProducts.Dock = DockStyle.Fill;
            this.Controls.Add(flpProducts);

            // Thêm sản phẩm vào FlowLayoutPanel nếu có

        }
       
        // Phương thức để thiết lập thông tin đơn hàng
        public void SetOrderInfo(object orderId, DateTime orderDate, string status)
        {
            // Tạo một panel để hiển thị thông tin đơn hàng
            Panel pnlOrderInfo = new Panel();
            pnlOrderInfo.AutoSize = true;
            pnlOrderInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderInfo.BackColor = Color.LightGray;
            pnlOrderInfo.Padding = new Padding(10);
            pnlOrderInfo.Margin = new Padding(10);

            // Tạo và thêm các Label vào Panel
            Label lblOrderId = new Label();
            lblOrderId.Text = $"Mã đơn hàng: {orderId}";
            lblOrderId.AutoSize = true;
            pnlOrderInfo.Controls.Add(lblOrderId);

            Label lblOrderDate = new Label();
            lblOrderDate.Text = $"Ngày đặt: {orderDate.ToShortDateString()}";
            lblOrderDate.AutoSize = true;
            lblOrderDate.Top = lblOrderId.Bottom + 5;
            pnlOrderInfo.Controls.Add(lblOrderDate);

            Label lblOrderStatus = new Label();
            lblOrderStatus.Text = $"Trạng thái: {status}";
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Top = lblOrderDate.Bottom + 5;
            pnlOrderInfo.Controls.Add(lblOrderStatus);

            // Thêm Panel vào FlowLayoutPanel
            flpProducts.Controls.Add(pnlOrderInfo);
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

        public void SetTotalOrderPrice(decimal totalPrice)
        {
            //.Text = $"Tổng giá trị: {totalPrice:C}"; // Định dạng tiền tệ
            // txtThanhTien.Text = $"Tổng: {totalPrice.ToString("N0")} ₫";
            
            txtThanhTien.Text = totalPrice.ToString("N0") + " đ";

        }
        private void UCLichSuDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
