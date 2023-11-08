using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopRepository;
using BFShopService;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_BirdFarmShop
{
    public partial class OrderForm : Form
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IAccountService _accountService;
        List<OrderDetail> orderDetailList = new List<OrderDetail>();
        double totalOrder = 0;

        public OrderForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _orderService = new OrderService();
            _accountService = new AccountService();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            btn_ThemSanPham.Enabled = false;
            btn_LuuHoaDon.Enabled = false;
            cbx_EmailNhanVien.DataSource = _accountService.getAllAccountByRole(Constants.IsStaff);
            cbx_EmailNhanVien.DisplayMember = "Email";
            cbx_EmailNhanVien.ValueMember = "Email";
            cbx_SoDienThoai.DataSource = _accountService.getAllAccountByRole(Constants.IsCustomer);
            cbx_SoDienThoai.DisplayMember = "Phone";
            cbx_SoDienThoai.ValueMember = "Phone";
        }
        private void cbx_MaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            Product pro = _productService.GetProduct(cbx_MaHang.SelectedValue.ToString());
            if (pro is not null)
            {
                txt_TenHang.Text = pro.ProductName;
                txt_DonGia.Text = String.Format("{0:0,00}", pro.Price);
                txt_SoLuong.Text = "1";
                txt_GiamGia.Text = "0";
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
            float dg, gg, tt;
            sl = txt_SoLuong.Text == "" ? 0 : Int32.Parse(txt_SoLuong.Text);
            gg = txt_GiamGia.Text == "" ? 0 : float.Parse(txt_GiamGia.Text);
            dg = float.Parse(txt_DonGia.Text);
            tt = sl * (dg - dg * gg / 100);
            txt_ThanhTien.Text = tt == 0 ? "0" : String.Format("{0:0,00}", tt);

        }

        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            if (BFShopUtils.ContainsLettersOrSpecialCharacters(txt_GiamGia.Text))
            {
                MessageBox.Show("Phải nhập chữ số");
                txt_GiamGia.Text = "0";
                return;
            }
            int sl;
            float dg, gg, tt;
            sl = txt_SoLuong.Text == "" ? 0 : Int32.Parse(txt_SoLuong.Text);
            gg = txt_GiamGia.Text == "" ? 0 : float.Parse(txt_GiamGia.Text);
            dg = float.Parse(txt_DonGia.Text);
            tt = sl * (dg - dg * gg / 100);
            txt_ThanhTien.Text = tt == 0 ? "0" : String.Format("{0:0,00}", tt);
        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            txt_MaHoaDon.Text = _orderService.createOrderID();
            cbx_MaHang.DataSource = _productService.GetAllProduct();
            cbx_MaHang.DisplayMember = "ProductId";
            cbx_MaHang.ValueMember = "ProductId";
            btn_ThemSanPham.Enabled = true;
            btn_LuuHoaDon.Enabled = true;
        }

        private void loadDataGridView()
        {
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
            orderDetail.OrderId = txt_MaHoaDon.Text.ToString();
            orderDetail.ProductId = cbx_MaHang.SelectedValue.ToString();
            orderDetail.Product.ProductName = txt_TenHang.Text.ToString();
            orderDetail.Quantity = qtyBuy;
            orderDetail.Price = Convert.ToDouble(txt_DonGia.Text.ToString());
            orderDetail.Total = Convert.ToInt32(txt_ThanhTien.Text.ToString());
            orderDetailList.Add(orderDetail);
            loadDataGridView();
            totalOrder += orderDetail.Total;
            txt_TongTien.Text = string.Format("{0:0,00}", totalOrder);
            pro.QuantityAvailable = pro.QuantityAvailable - qtyBuy;
            pro.QuantitySold = pro.QuantitySold + qtyBuy;
            _productService.Update(pro.ProductId, pro);
        }

        private void dtg_OrderDetailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (dtg_OrderDetailList.Rows[rowIndex].Cells["ProductId"].Value is not null)
            {
                string productId = dtg_OrderDetailList.Rows[rowIndex].Cells["ProductId"].Value.ToString();
                int qtyBuy = Convert.ToInt32(dtg_OrderDetailList.Rows[rowIndex].Cells["Quantity"].Value.ToString());
                totalOrder -= orderDetailList.Find(item => item.ProductId.Equals(productId)).Total;
                txt_TongTien.Text = string.Format("{0:0,00}", totalOrder);
                orderDetailList.RemoveAll(item => item.ProductId.Equals(productId));
                Product pro = _productService.GetProduct(productId);
                pro.QuantityAvailable = pro.QuantityAvailable + qtyBuy;
                pro.QuantitySold = pro.QuantitySold - qtyBuy;
                _productService.Update(productId, pro);
                loadDataGridView();
            }
        }


    }
}