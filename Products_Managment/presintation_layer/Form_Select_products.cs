using Products_Managment.DAL;
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

namespace Products_Managment.presintation_layer
{
    public partial class Form_Select_products : Form
    {
        Form_orders orders_form;


        public Form_Select_products():this(null)
        {
            InitializeComponent();
        }
        public Form_Select_products(Form_orders _orders_form)
        {

            orders_form = _orders_form;
            InitializeComponent();
        }

        public Form_orders Orders_form
        {
            get
            {
                return orders_form;
            }

            set
            {
                orders_form = value;
            }
        }

        private void Form_Select_products_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            List<Products_DATA> list = Products_DAL.Select_ALL_Product();
            table.Columns.Add("Id");
            table.Columns.Add("اسم المنتج");
            table.Columns.Add("سعر المنتج");
            table.Columns.Add("كمية المنتج");
            table.Columns.Add("نوع المنتج");
            table.Columns.Add("Category_ID");
            table.Columns.Add("image", typeof(byte[]));
            foreach (var item in list)
            {


                table.Rows.Add(item.Id, item.Label_product, item.Price, item.Qte_in_product, item.Category.Description, item.Category.Id, item.Image);



            }



            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Products_DATA pro = new Products_DATA();
            pro.Id =Convert.ToInt16( row.Cells[0].Value);
            pro.Label_product = row.Cells[1].Value.ToString();
            pro.Qte_in_product = row.Cells[3].Value.ToString() ;
            pro.Price = row.Cells[2].Value.ToString();
            Categories_DATA ctegory = new Categories_DATA();
          

            ctegory.Description = row.Cells[4].Value.ToString();
            ctegory.Id =Convert.ToInt16( row.Cells[5].Value);
            pro.Category = ctegory;
          orders_form.Product = pro;
            this.Close();

        }
    }
}
