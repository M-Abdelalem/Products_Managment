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
    public partial class Form_product_report : Form
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

        public Form_product_report()
        {
            InitializeComponent();
                   }
      

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

           









        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void Form_product_report_Load(object sender, EventArgs e)
        {
            CrystalReport2 s = new CrystalReport2();
         
            DataTable table = new DataTable();
            List<Products_DATA> list = Products_DAL.Select_ALL_Product();
            table.Columns.Add("Id");
           table.Columns.Add("label_product");
            table.Columns.Add("qte_in_product");
            table.Columns.Add("price");
       
         
            table.Columns.Add("image", typeof(byte[]));
            table.Columns.Add("category_FK");
            table.Columns.Add("description");
           
            foreach (var item in list)
            {


                //table.Rows.Add(item.Id, item.Label_product, item.Price, item.Qte_in_product, item.Category.Description, item.Category.Id, item.Image);
                table.Rows.Add(item.Id, item.Label_product, item.Qte_in_product, item.Price, item.Image, item.Category.Id, item.Category.Description);


            }


        

            s.SetDataSource(table);
            crystalReportViewer1.ReportSource= s;
        }
    }
}
