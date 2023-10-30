using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsShoppingApp.Data;

namespace WindowsFormsShoppingApp
{
    public partial class FormGridViewDemo : Form
    {
        public FormGridViewDemo()
        {
            InitializeComponent();
            var products = new ProductRepository().GetProducts();
            dataGridView1.DataSource = products;

            var jsonData = ContentFormater.ToPrettyJson(products);
            //Binding the ListBox
            listBox1.DisplayMember = "Name";
            listBox1.SelectedItem = "Id";

            listBox2.DisplayMember = "Name";
            listBox2.SelectedItem = "Id";

            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedItem = "Id";

            listBox1.DataSource = products;
            comboBox1.DataSource = products;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = listBox1.SelectedItem as Product;
            //MessageBox.Show($"You selected : {product.Id} - {product.Name}");
            listBox2.Items.Add(product);
        }
    }
}
