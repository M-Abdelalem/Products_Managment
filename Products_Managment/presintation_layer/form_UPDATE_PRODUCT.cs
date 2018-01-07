using Products_Managment.BLL;
using Products_Managment.DAL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.presintation_layer
{
    public partial class form_UPDATE_PRODUCT : Form
    {
        Form_Products form_product;
        Products_DATA product;
        int Id;
        
        public form_UPDATE_PRODUCT():this(null)
        {
            InitializeComponent();
        
           

        }
        public form_UPDATE_PRODUCT(Form_Products _form_product)
        {
            form_product = _form_product;
            InitializeComponent();


        }

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

        public int ID
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        private void form_UPDATE_PRODUCT_Load(object sender, EventArgs e)
        {
            
            List<Categories_DATA> category_list = Categories_BLL.Select_ALL_Categories();
            this.comboBox1.DataSource = category_list;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.DisplayMember = "Description";
            Id = product.Id;
            comboBox1.SelectedValue = product.Category.Id;
            description.Text = product.Label_product;
            quantity.Text = product.Qte_in_product;
            price.Text = product.Price;
            MemoryStream ms = new MemoryStream(product.Image);
            pictureBox1.Image = Image.FromStream(ms); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products_DATA Product = new Products_DATA();
            Product.Label_product = description.Text;
            Product.Qte_in_product = quantity.Text;
            Product.Price = price.Text;
            MemoryStream memory = new MemoryStream();
            pictureBox1.Image.Save(memory, pictureBox1.Image.RawFormat);
            byte[] byte_image = memory.ToArray();
            Product.Image = byte_image;
            Product.Id = Id;
            int x = Convert.ToInt16(comboBox1.SelectedValue);
            Categories_DATA c = new Categories_DATA();
            c.Id = x;
            Product.Category = c;
            Products_BLL.Update_Product(Product);



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



            form_product.DataGridView1.DataSource = table;
            form_product.DataGridView1.Columns[0].Visible = false;
            form_product.DataGridView1.Columns[5].Visible = false;
            form_product.DataGridView1.Columns[6].Visible = false;


        }
    }
}
