using Products_Managment.BLL;
using Products_Managment.DATA;
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
    public partial class Form_item_category : Form
    {

        Categories_DATA category = new Categories_DATA();
        public Form_item_category():this(null)
        {
            InitializeComponent();
        }
        public Form_item_category(Categories_DATA _category)
        {
            Category = _category;

            InitializeComponent();
        }

        public Categories_DATA Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        private void Form_item_category_Load(object sender, EventArgs e)
        {
          List<Products_DATA> product=new List<Products_DATA>();
            product = category.Products;
            product_item products = new product_item();
            DataTable table_product = new DataTable();
            table_product.Columns.Add("Id");
            table_product.Columns.Add("label_product");
            table_product.Columns.Add("qte_in_product");
            table_product.Columns.Add("price");
            table_product.Columns.Add("image", typeof(byte[]));
            table_product.Columns.Add("category_FK");
            table_product.Columns.Add("description");
            foreach (var item in product)
            {
                table_product.Rows.Add(item.Id, item.Label_product, item.Qte_in_product, item.Price, item.Image, item.Category.Id, item.Category.Description);
            }
            




            CrystalReport_item_category s = new CrystalReport_item_category();
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("description");
            table.Rows.Add(category.Id, category.Description);
            s.Subreports[0].SetDataSource(table_product);
            s.SetDataSource(table);

       //     s.Load(@"..\\Report_view\\product_item.rpt");
  
              crystalReportViewer1.ReportSource = s;
        }
    }
}
