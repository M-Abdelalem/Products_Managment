using Products_Managment.DAL;
using Products_Managment.DATA;
using Products_Managment.Report_view;
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
    public partial class Form_Products : Form
    {

   public   DataGridView DataGridView1
        {


            get { return dataGridView1; }
        }


        public Form_Products()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsBLLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form_Products_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
          List<  Products_DATA> list = Products_DAL.Select_ALL_Product();
            table.Columns.Add("Id");
            table.Columns.Add("اسم المنتج");
            table.Columns.Add("سعر المنتج");
            table.Columns.Add("كمية المنتج");
            table.Columns.Add("نوع المنتج");
            table.Columns.Add("Category_ID");
            table.Columns.Add("image", typeof(byte[]));
            foreach (var item in list)
            {


                table.Rows.Add(item.Id,item.Label_product, item.Price, item.Qte_in_product, item.Category.Description, item.Category.Id, item.Image); 
           


            }

          

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            List<Products_DATA> list;
            if (max_price.Text != "" && min_price.Text != "")
            {
                list = Products_DAL.Select_ALL_Product().Where
                (x =>
               (x.Label_product.Contains(textBox1.Text) || textBox1.Text == "")
                &&
                Convert.ToInt16(min_price.Text) <= Convert.ToInt16(x.Price)
                &&
                 Convert.ToInt16(x.Price) <= Convert.ToInt16(max_price.Text)
                ).ToList();
            }
            else
            {

                list = Products_DAL.Select_ALL_Product().Where(
                      x => x.Label_product.Contains(textBox1.Text) || textBox1.Text == ""




                      ).ToList();
            }
            table.Columns.Add("اسم المنتج");
            table.Columns.Add("سعر المنتج");
            table.Columns.Add("كمية المنتج");
            table.Columns.Add("نوع المنتج");

            foreach (var item in list)
            {


                table.Rows.Add(item.Label_product, item.Price, item.Qte_in_product, item.Category.Description);



            }



            dataGridView1.DataSource = table;



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            List<Products_DATA> list;
            if (max_price.Text != "" && min_price.Text != "")
            {
                list = Products_DAL.Select_ALL_Product().Where
                (x =>
               (x.Label_product.Contains(textBox1.Text) || textBox1.Text == "")
                &&
                Convert.ToInt16(min_price.Text) <= Convert.ToInt16(x.Price)
                &&
                 Convert.ToInt16(x.Price) <= Convert.ToInt16(max_price.Text)
                ).ToList();
            }
            else
            {

                list = Products_DAL.Select_ALL_Product().Where(
                      x => x.Label_product.Contains(textBox1.Text) || textBox1.Text == ""




                      ).ToList();
            }
            table.Columns.Add("اسم المنتج");
            table.Columns.Add("سعر المنتج");
            table.Columns.Add("كمية المنتج");
            table.Columns.Add("نوع المنتج");

            foreach (var item in list)
            {


                table.Rows.Add(item.Label_product, item.Price, item.Qte_in_product, item.Category.Description);



            }



            dataGridView1.DataSource = table;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            List<Products_DATA> list;
            if (max_price.Text != "" && min_price.Text != "")
            {
                list = Products_DAL.Select_ALL_Product().Where
                (x =>
               ( x.Label_product.Contains(textBox1.Text) || textBox1.Text == "")
                &&
                Convert.ToInt16(min_price.Text) <= Convert.ToInt16(x.Price)
                &&
                 Convert.ToInt16(x.Price) <= Convert.ToInt16(max_price.Text)
                ).ToList();
            }
            else
            {

                list = Products_DAL.Select_ALL_Product().Where(
                      x => x.Label_product.Contains(textBox1.Text) || textBox1.Text == ""




                      ).ToList();
            }
            table.Columns.Add("اسم المنتج");
            table.Columns.Add("سعر المنتج");
            table.Columns.Add("كمية المنتج");
            table.Columns.Add("نوع المنتج");

            foreach (var item in list)
            {


                table.Rows.Add(item.Label_product, item.Price, item.Qte_in_product, item.Category.Description);



            }



            dataGridView1.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow x =dataGridView1.SelectedRows[0];
            Products_DATA product = new Products_DATA();
            product.Id = Convert.ToInt16(x.Cells[0].Value);
            BLL.Products_BLL.Delete_Product(product);


            DataTable table = new DataTable();
            List<Products_DATA> list = Products_DAL.Select_ALL_Product();
            table.Columns.Add("Id");
            table.Columns.Add("اسم المنتج");
            table.Columns.Add("سعر المنتج");
            table.Columns.Add("كمية المنتج");
            table.Columns.Add("نوع المنتج");
            table.Columns.Add("Category_ID");
            foreach (var item in list)
            {
                table.Rows.Add(item.Id, item.Label_product, item.Price, item.Qte_in_product, item.Category.Description, item.Category.Id);
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow x = dataGridView1.SelectedRows[0];
            Products_DATA product = new Products_DATA();
            product.Id = Convert.ToInt16(x.Cells[0].Value);
            product.Label_product = x.Cells[1].Value.ToString();
            product.Price = x.Cells[3].Value.ToString();
            product.Qte_in_product =  x.Cells[2].Value.ToString();

            Categories_DATA c = new Categories_DATA();

          c.Id=Convert.ToInt16(  x.Cells[5].Value);
            product.Category = c;
            form_UPDATE_PRODUCT form = new form_UPDATE_PRODUCT(this);
           
            product.Image =(byte[]) x.Cells[6].Value;
            form.Product = product;
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow x = dataGridView1.SelectedRows[0];
            Products_DATA product = new Products_DATA();



            Form_Image form = new Form_Image();

            product.Image = (byte[])x.Cells[6].Value;
            form.Product = product;
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataGridViewRow x = dataGridView1.SelectedRows[0];
            Products_DATA product = new Products_DATA();
            product.Id = Convert.ToInt16(x.Cells[0].Value);
            product.Label_product = x.Cells[1].Value.ToString();
            product.Price = x.Cells[3].Value.ToString();
            product.Qte_in_product = x.Cells[2].Value.ToString();

            Categories_DATA c = new Categories_DATA();

            c.Id = Convert.ToInt16(x.Cells[5].Value);
            product.Category = c;
            Form_item_product report = new Form_item_product();

            product.Image = (byte[])x.Cells[6].Value;
            report.Product = product;
            this.Hide();
            report.ShowDialog();

            this.Show();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_product_report report = new Form_product_report();
            this.Hide();
            report.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ADD_Product form = new Form_ADD_Product(this);
            form.ShowDialog();

        }
    }

}
