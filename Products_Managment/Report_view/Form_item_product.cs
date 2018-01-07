using Products_Managment.BLL;
using Products_Managment.DAL;
using Products_Managment.DATA;
using Products_Managment.presintation_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.Report_view
{
    public partial class Form_item_product : Form
    {

        Products_DATA product;
        internal Products_DATA Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public Form_item_product()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Products_BLL.Select_Item_Product(Product);
        }

        private void Form_item_product_Load(object sender, EventArgs e)
        {
            product_item s = new product_item();
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("label_product");
            table.Columns.Add("qte_in_product");
            table.Columns.Add("price");
            table.Columns.Add("image", typeof(byte[]));
            table.Columns.Add("category_FK");
            table.Columns.Add("description");
            table.Rows.Add(product.Id, product.Label_product, product.Qte_in_product, product.Price, product.Image, product.Category.Id, product.Category.Description);
            s.SetDataSource(table);
            crystalReportViewer1.ReportSource = s;
        }
    }
}
