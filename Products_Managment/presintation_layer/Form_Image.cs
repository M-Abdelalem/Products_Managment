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
    public partial class Form_Image : Form
    {
        Products_DATA product;

        public Form_Image()
        {
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

        private void Form_Image_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(product.Image);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
