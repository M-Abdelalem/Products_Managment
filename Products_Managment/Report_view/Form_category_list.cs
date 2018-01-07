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
    public partial class Form_category_list : Form
    {
        public Form_category_list()
        {
            InitializeComponent();
        }

        private void Form_category_list_Load(object sender, EventArgs e)
        {
            List<Categories_DATA> list_category = new List<Categories_DATA>();
            list_category = Categories_BLL.Select_ALL_Categories();

            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("number");
            table.Columns.Add("description");
            int number = 1;
            foreach (var item in list_category)
            {
                table.Rows.Add(number, item.Id, item.Description);
                number++;

            }
            CrystalReport_category s = new CrystalReport_category();

            s.SetDataSource(table);
            crystalReportViewer1.ReportSource = s;

        }
    }
}
