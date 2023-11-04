using BFShopBussinessObjects.Entities;
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
        public OrderForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            cbx_MaHang.DataSource = _productService.GetAllProduct();
            cbx_MaHang.DisplayMember = "ProductId";
            cbx_MaHang.ValueMember = "ProductId";
        }
        private void cbx_MaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            Product pro = _productService.GetProductByProductID(cbx_MaHang.SelectedValue.ToString());
            if (pro is not null)
            {
                txt_TenHang.Text = pro.ProductName;
                txt_DonGia.Text = String.Format("{0:0,00}", pro.Price);
                txt_SoLuong.Text = "1";
                txt_GiamGia.Text = "0";
                txt_ThanhTien.Text = String.Format("{0:0,00}", pro.Price);
            }
        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            float dg, sl, gg, tt;
            sl = txt_SoLuong.Text == "" ? 0 : float.Parse(txt_SoLuong.Text);
            gg = txt_GiamGia.Text == "" ? 0 : float.Parse(txt_GiamGia.Text);
            dg = float.Parse(txt_DonGia.Text);
            tt = sl * (dg - dg * gg / 100);
            txt_ThanhTien.Text = tt == 0 ? "0" : String.Format("{0:0,00}", tt);
        }

        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            float dg, sl, gg, tt;
            sl = txt_SoLuong.Text == "" ? 0 : float.Parse(txt_SoLuong.Text);
            gg = txt_GiamGia.Text == "" ? 0 : float.Parse(txt_GiamGia.Text);
            dg = float.Parse(txt_DonGia.Text);
            tt = sl * (dg - dg * gg / 100);
            txt_ThanhTien.Text = tt == 0 ? "0" : String.Format("{0:0,00}", tt);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


    }
}
