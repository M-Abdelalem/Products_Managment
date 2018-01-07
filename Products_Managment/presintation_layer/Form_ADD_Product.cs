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
using System.IO;
using Products_Managment.DAL;

namespace Products_Managment.presintation_layer
{
    public partial class Form_ADD_Product : Form
    {
        Form_Products product;

        public Form_Products Product
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

        public Form_ADD_Product():this(null)
        {
            InitializeComponent();
        }
        public Form_ADD_Product(Form_Products _product)
        {
            product = _product;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "صور|*.png;*.jpg;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image =Image.FromFile( open.FileName);


            }
            
        }

        private void Form_ADD_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_DBDataSet.CATEGORIES' table. You can move, or remove it, as needed.
            //this.cATEGORIESTableAdapter.Fill(this.product_DBDataSet.CATEGORIES);
            List<Categories_DATA> category_list = Categories_BLL.Select_ALL_Categories();
            this.comboBox1.DataSource = category_list;

            this.comboBox1.ValueMember = "Id";
            this.comboBox1.DisplayMember = "Description";
            //comboBox1.DataBindings;

            //this.comboBox1.ValueMember = "Id";
            //this.comboBox1.DisplayMember = "Description";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products_DATA Product = new Products_DATA();
 
          
            Product.Label_product= description.Text;
            Product.Qte_in_product = quantity.Text;
           Product.Price= price.Text;
            MemoryStream memory = new MemoryStream();
            pictureBox1.Image.Save(memory, pictureBox1.Image.RawFormat);
            byte[] byte_image = memory.ToArray();
            Product.Image = byte_image;
           int x = Convert.ToInt16(comboBox1.SelectedValue);
            Categories_DATA c = new Categories_DATA();
            c.Id = x;
            Product.Category = c;
            Products_BLL.Insert_Product(Product);
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



            product.DataGridView1.DataSource = table;
            product.DataGridView1.Columns[0].Visible = false;
            product.DataGridView1.Columns[5].Visible = false;
            product.DataGridView1.Columns[6].Visible = false;









        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
