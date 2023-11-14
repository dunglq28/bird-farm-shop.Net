using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopRepository;
using BFShopService;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace PRN211_BirdFarmShop
{
    public partial class OrderForm : Form
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IAccountService _accountService;
        List<OrderDetail> orderDetailList = new List<OrderDetail>();

        int totalItem = 0;
        double totalOrder = 0;

        public OrderForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _accountService = new AccountService();
            btn_ThemSanPham.Enabled = false;
            btn_LuuHoaDon.Enabled = false;
            btn_HuyHoaDon.Enabled = false;
            btn_LưuFile.Enabled = false;
            cbx_EmailNhanVien.DataSource = _accountService.getAllAccountByRole(Constants.IsStaff);
            cbx_EmailNhanVien.DisplayMember = "Email";
            cbx_EmailNhanVien.ValueMember = "Email";
            cbx_SoDienThoai.DataSource = _accountService.getAllAccountByRole(Constants.IsCustomer);
            cbx_SoDienThoai.DisplayMember = "Phone";
            cbx_SoDienThoai.ValueMember = "Phone";
            SetEPPlusLicense();
        }
        private void SetEPPlusLicense()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }

        void ResetForm()
        {
            txt_MaHoaDon.Text = string.Empty;
            dt_NgayBan.Text = DateTime.Now.ToString("dd-MM-yyyy");
            cbx_MaHang.Text = string.Empty;
            txt_DonGia.Text = string.Empty;
            txt_GiongLoai.Text = string.Empty;
            txt_SoLuong.Text = string.Empty;
            txt_TongTien.Text = string.Empty;
            orderDetailList.Clear();
            dtg_OrderDetailList.DataSource = null;
        }

        private void cbx_MaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            Product pro = _productService.GetProduct(cbx_MaHang.SelectedValue.ToString());
            if (pro is not null)
            {
                txt_TenHang.Text = pro.ProductName;
                txt_GiongLoai.Text = pro.Category.CategoryName;
                txt_DonGia.Text = String.Format("{0:0,00}", pro.Price);
                txt_SoLuong.Text = "1";
                txt_ThanhTien.Text = String.Format("{0:0,00}", pro.Price);
            }
        }

        private void cbx_EmailNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            Account acc = null;
            if (cbx_EmailNhanVien.SelectedValue is not null)
            {
                acc = _accountService.GetAccount(cbx_EmailNhanVien.SelectedValue.ToString());
            }
            if (acc is not null)
            {
                txt_TenNhanVien.Text = acc.Fullname;
            }
        }

        private void cbx_SoDienThoai_SelectedValueChanged(object sender, EventArgs e)
        {
            Account acc = null;
            if (cbx_SoDienThoai.SelectedValue is not null)
            {
                acc = _accountService.GetAccountCusByPhone(cbx_SoDienThoai.SelectedValue.ToString());
            }
            if (acc is not null)
            {
                txt_TenKhachHang.Text = acc.Fullname;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (BFShopUtils.ContainsLettersOrSpecialCharacters(txt_SoLuong.Text.ToString()))
            {
                MessageBox.Show("Phải nhập chữ số");
                txt_SoLuong.Text = "1";
                return;
            }
            int sl;
            float dg, tt;
            sl = txt_SoLuong.Text == "" ? 0 : Int32.Parse(txt_SoLuong.Text);
            dg = float.Parse(txt_DonGia.Text);
            tt = sl * dg;
            txt_ThanhTien.Text = tt == 0 ? "0" : String.Format("{0:0,00}", tt);

        }


        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            txt_MaHoaDon.Text = _orderService.createOrderID();
            cbx_MaHang.DataSource = _productService.GetAllProduct();
            cbx_MaHang.DisplayMember = "ProductId";
            cbx_MaHang.ValueMember = "ProductId";
            dt_NgayBan.Text = DateTime.Now.ToString();

            orderDetailList.Clear();
            dtg_OrderDetailList.DataSource = null;

            loadOrderDetailListView();

            btn_ThemSanPham.Enabled = true;
            btn_LuuHoaDon.Enabled = true;
            btn_LưuFile.Enabled = true;
            btn_HuyHoaDon.Enabled = false;
        }

        private void loadOrderDetailListView()
        {
            if (dtg_OrderDetailList.Columns.Count == 0)
            {
                dtg_OrderDetailList.Columns.Add("ProductId", "Mã hàng");
                dtg_OrderDetailList.Columns.Add("ProductName", "Tên hàng");
                dtg_OrderDetailList.Columns.Add("Quantity", "Số lượng");
                dtg_OrderDetailList.Columns.Add("Price", "Đơn giá");
                dtg_OrderDetailList.Columns.Add("Total", "Thành tiền");

                dtg_OrderDetailList.Columns[0].Width = 200;
                dtg_OrderDetailList.Columns[1].Width = 250;
                dtg_OrderDetailList.Columns[2].Width = 200;
                dtg_OrderDetailList.Columns[3].Width = 200;
                dtg_OrderDetailList.Columns[4].Width = 200;

                dtg_OrderDetailList.AutoGenerateColumns = true;

                // Tên hiển thị của cột
                dtg_OrderDetailList.Columns["ProductId"].HeaderText = "Mã hàng";
                dtg_OrderDetailList.Columns["ProductName"].HeaderText = "Tên hàng";
                dtg_OrderDetailList.Columns["Quantity"].HeaderText = "Số lượng";
                dtg_OrderDetailList.Columns["Price"].HeaderText = "Đơn giá";
                dtg_OrderDetailList.Columns["Total"].HeaderText = "Thành tiền";
            }
            dtg_OrderDetailList.AutoGenerateColumns = false;
            dtg_OrderDetailList.DataSource = orderDetailList.Select(
                p => new
                {
                    p.ProductId,
                    p.Product.ProductName,
                    p.Quantity,
                    Price = string.Format("{0:0,00}", p.Price),
                    Total = string.Format("{0:0,00}", p.Total)
                }).ToList();
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (orderDetailList is not null && BFShopUtils.CheckProductIDExist(cbx_MaHang.SelectedValue.ToString(), orderDetailList))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Product pro = _productService.GetProduct(cbx_MaHang.SelectedValue.ToString());
            int qtyBuy = Convert.ToInt32(txt_SoLuong.Text.ToString());
            if (qtyBuy > pro.QuantityAvailable)
            {
                MessageBox.Show("Sản phẩm này chỉ còn " + pro.QuantityAvailable, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Product = new Product();
            orderDetail.Product.Category = new Category();
            orderDetail.OrderId = txt_MaHoaDon.Text.ToString();
            orderDetail.ProductId = cbx_MaHang.SelectedValue.ToString();
            orderDetail.Product.ProductName = txt_TenHang.Text.ToString();
            orderDetail.Product.Category.CategoryName = txt_GiongLoai.Text.ToString();
            orderDetail.Quantity = qtyBuy;
            orderDetail.Price = Convert.ToDouble(txt_DonGia.Text.ToString());
            orderDetail.Total = Convert.ToDouble(txt_ThanhTien.Text.ToString());
            orderDetailList.Add(orderDetail);
            loadOrderDetailListView();
            totalOrder += orderDetail.Total;
            totalItem += orderDetail.Quantity;
            txt_TongTien.Text = string.Format("{0:0,00}", totalOrder);

        }

        private void dtg_OrderDetailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (dtg_OrderDetailList.Rows[rowIndex].Cells["ProductId"].Value is not null)
            {
                string productId = dtg_OrderDetailList.Rows[rowIndex].Cells["ProductId"].Value.ToString();
                int qtyBuy = Convert.ToInt32(dtg_OrderDetailList.Rows[rowIndex].Cells["Quantity"].Value.ToString());
                totalOrder -= orderDetailList.Find(item => item.ProductId.Equals(productId)).Total;
                totalItem -= orderDetailList.Find(item => item.ProductId.Equals(productId)).Quantity;
                txt_TongTien.Text = string.Format("{0:0,00}", totalOrder);
                orderDetailList.RemoveAll(item => item.ProductId.Equals(productId));
                loadOrderDetailListView();
            }
        }

        private void btn_LuuHoaDon_Click(object sender, EventArgs e)
        {
            if (orderDetailList is null || orderDetailList.Count == 0)
            {
                MessageBox.Show("Hoá đơn chưa có sản phẩm, vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_orderService.Search(txt_MaHoaDon.Text.ToString()) is not null)
            {
                MessageBox.Show("Hoá đơn đã tồn tại, vui lòng thêm mới hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Order order = new Order();
            order.OrderId = txt_MaHoaDon.Text;
            order.Email = cbx_EmailNhanVien.SelectedValue.ToString();
            order.StaffName = txt_TenNhanVien.Text;
            order.CustomerPhone = cbx_SoDienThoai.SelectedValue.ToString();
            order.CustomerName = txt_TenKhachHang.Text;
            order.CreateDate = DateTime.Now;
            order.TotalItem = totalItem;
            order.TotalPrice = totalOrder;
            if (_orderService.AddNewOrder(order) && _orderDetailService.AddNewOrderDetails(orderDetailList))
            {
                foreach (var item in orderDetailList)
                {
                    Product pro = _productService.GetProduct(item.ProductId);
                    pro.QuantityAvailable = pro.QuantityAvailable - item.Quantity;
                    pro.QuantitySold = pro.QuantitySold + item.Quantity;
                    _productService.Update(pro.ProductId, pro);
                }
                MessageBox.Show("Lưu hoá đơn thành công!");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string orderID = txt_TimMaHH.Text;
            Order order = _orderService.Search(orderID);
            orderDetailList = _orderDetailService.GetOrderDetail(orderID)
            .Select(od => new OrderDetail
            {
                ProductId = od.ProductId,
                Product = od.Product,
                Quantity = od.Quantity,
                Price = od.Price,
                Total = od.Total
            })
            .ToList();
            if (order is not null && orderDetailList is not null)
            {
                txt_MaHoaDon.Text = order.OrderId;
                dt_NgayBan.Text = order.CreateDate.HasValue ? order.CreateDate.Value.ToString("dd-MM-yyyy") : string.Empty;
                cbx_EmailNhanVien.SelectedValue = order.Email;
                txt_TenNhanVien.Text = order.StaffName;
                cbx_SoDienThoai.SelectedValue = order.CustomerPhone;
                txt_TenKhachHang.Text = order.CustomerName;
                totalOrder = order.TotalPrice;
                loadOrderDetailListView();
                btn_HuyHoaDon.Enabled = true;
                btn_LưuFile.Enabled = true;
                btn_ThemSanPham.Enabled = false;
                btn_LuuHoaDon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hoá đơn không tồn tại!");
            }
        }

        private void btn_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if (_orderDetailService.DeleteOrderDetail(txt_MaHoaDon.Text.ToString())
                && _orderService.DeleteOrder(txt_MaHoaDon.Text.ToString()))
            {
                MessageBox.Show("Huỷ hoá đơn thành công!");
            }
            foreach (var item in orderDetailList)
            {
                Product pro = _productService.GetProduct(item.ProductId);
                pro.QuantityAvailable = pro.QuantityAvailable + item.Quantity;
                pro.QuantitySold = pro.QuantitySold - item.Quantity;
                _productService.Update(pro.ProductId, pro);
            }
            ResetForm();
            loadOrderDetailListView();
        }

        private void DeleteContentExcelFile(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                var allCells = worksheet.Cells;

                foreach (var cell in allCells)
                {
                    cell.Value = null;
                }

                package.Save();
            }
        }

        private void OpenExcelFile(string filePath, Order order, List<OrderDetail> odList)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    worksheet.Cells["A1:Z300"].Style.Font.Name = "Times new roman"; // Font chữ
                    worksheet.Cells["A1:B3"].Style.Font.Size = 10;
                    worksheet.Cells["A1:B3"].Style.Font.Bold = true;
                    worksheet.Cells["A1:B3"].Style.Font.Color.SetColor(Color.Blue); // Màu xanh da trời
                    worksheet.Column(1).Width = 7;
                    worksheet.Column(2).Width = 15;
                    worksheet.Column(4).Width = 30;
                    worksheet.Cells["A1:B1"].Merge = true;
                    worksheet.Cells["A1:B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A1:B1"].Value = "Trang trại chim";
                    worksheet.Cells["A2:B2"].Merge = true;
                    worksheet.Cells["A2:B2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A2:B2"].Value = "Gò Vấp - Hồ Chí Minh";
                    worksheet.Cells["A3:B3"].Merge = true;
                    worksheet.Cells["A3:B3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A3:B3"].Value = "Điện thoại: 0961287613";
                    worksheet.Cells["C2:E2"].Style.Font.Size = 16;
                    worksheet.Cells["C2:E2"].Style.Font.Bold = true;
                    worksheet.Cells["C2:E2"].Style.Font.Color.SetColor(Color.Red); // Màu đỏ
                    worksheet.Cells["C2:E2"].Merge = true;
                    worksheet.Cells["C2:E2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["C2:E2"].Value = "HÓA ĐƠN BÁN";

                    int startRow = 6;
                    worksheet.Cells[$"B{startRow}:C{startRow + 3}"].Style.Font.Size = 12;

                    worksheet.Cells[$"B{startRow}:B{startRow}"].Value = "Mã hóa đơn:";
                    worksheet.Cells[$"C{startRow}:E{startRow}"].Merge = true;
                    worksheet.Cells[$"C{startRow}:E{startRow}"].Value = order.OrderId;

                    worksheet.Cells[$"B{startRow + 1}:B{startRow + 1}"].Value = "Khách hàng:";
                    worksheet.Cells[$"C{startRow + 1}:E{startRow + 1}"].Merge = true;
                    worksheet.Cells[$"C{startRow + 1}:E{startRow + 1}"].Value = order.CustomerName;

                    worksheet.Cells[$"B{startRow + 2}:B{startRow + 2}"].Value = "Điện thoại:";
                    worksheet.Cells[$"C{startRow + 2}:E{startRow + 2}"].Merge = true;
                    worksheet.Cells[$"C{startRow + 2}:E{startRow + 2}"].Value = order.CustomerPhone;

                    worksheet.Cells["A11:F11"].Style.Font.Bold = true;
                    worksheet.Cells["A11:F11"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    for (global::System.Int32 i = 1; i < 5; i++)
                    {
                        worksheet.Column(i).Width = 20;
                    }
                    worksheet.Cells["A11:A11"].Value = "STT";
                    worksheet.Cells["B11:B11"].Value = "Tên hàng";
                    worksheet.Cells["C11:C11"].Value = "Số lượng";
                    worksheet.Cells["D11:D11"].Value = "Đơn giá";
                    worksheet.Cells["E11:E11"].Value = "Thành tiền";

                    startRow = 12;
                    int col = 0;

                    for (int hang = 0; hang < odList.Count; hang++)
                    {
                        worksheet.Cells[$"A{startRow + hang}"].Value = hang + 1;
                        worksheet.Cells[$"B{startRow + hang}"].Value = odList[hang].Product.ProductName;
                        worksheet.Cells[$"C{startRow + hang}"].Value = odList[hang].Quantity;
                        worksheet.Cells[$"D{startRow + hang}"].Value = string.Format("{0:0,00}", odList[hang].Price);
                        worksheet.Cells[$"D{startRow + hang}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"E{startRow + hang}"].Value = string.Format("{0:0,00}", odList[hang].Total);
                        worksheet.Cells[$"E{startRow + hang}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        col = startRow + hang + 2;
                    }

                    int row = 4;

                    ExcelRange exRange = worksheet.Cells[col, row];
                    exRange.Style.Font.Bold = true;
                    exRange.Value = "Tổng tiền:";
                    exRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    exRange = worksheet.Cells[col, row + 1];
                    exRange.Style.Font.Bold = true;
                    exRange.Value = string.Format("{0:0,00}", order.TotalPrice);
                    exRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    exRange = worksheet.Cells[col + 1, row];
                    exRange.Merge = true;
                    exRange.Style.Font.Italic = true;
                    exRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    DateTime d = Convert.ToDateTime(order.CreateDate);
                    exRange.Value = "Hồ Chí Minh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

                    exRange = worksheet.Cells[col + 2, row];
                    exRange.Merge = true;
                    exRange.Style.Font.Italic = true;
                    exRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    exRange.Value = "Nhân viên bán hàng: " + order.StaffName;


                    package.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LưuFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Order order = _orderService.Search(txt_MaHoaDon.Text.ToString());
            orderDetailList = _orderDetailService.GetOrderDetail(txt_MaHoaDon.Text.ToString());
            if (order is not null)
            {
                DeleteContentExcelFile("D:\\C# source\\PRN211-BirdFarmShop\\Order.xlsx");
                OpenExcelFile("D:\\C# source\\PRN211-BirdFarmShop\\Order.xlsx", order, orderDetailList);
                MessageBox.Show("In hoá đơn thành công");
            }
            else
            {
                MessageBox.Show("Hoá đơn không tồn tại!");
            }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_XemSP_Click(object sender, EventArgs e)
        {
            ProductMangementForm productfrm = new ProductMangementForm();
            productfrm.Show();
        }
    }
}