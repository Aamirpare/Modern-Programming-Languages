using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsShoppingApp.Data;

namespace WindowsFormsShoppingApp
{
    public partial class FormGridViewDemo : Form
    {
        public void BuildTreeFromString(string [] pairs)
        {
            Dictionary<string, List<string>> tree = new Dictionary<string, List<string>>();
 
            // Build a tree structure from the pairs.
            foreach (string pair in pairs)
            {
                string[] values = pair.Split(' ');
                string parent = values[0];
                string child = values[1];

                if (!tree.ContainsKey(parent))
                {
                    tree[parent] = new List<string>();
                }

                tree[parent].Add(child);
            }
        }

        public FormGridViewDemo()
        {
            InitializeComponent();

            //MyMethod("[(2,5),(4,5)]");

            var repo = new ProductRepository();
            var products = repo.GetProducts();

            dataGridView1.DataSource = products;

            ////Binding the ListBox
            listBox1.DisplayMember = "Name";
            listBox1.SelectedItem = "Id";

            listBox2.DisplayMember = "Name";
            listBox2.SelectedItem = "Id";

            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedItem = "Id";

            //listBox1.DataSource = products;
            comboBox1.DataSource = products; //repo.CloneProducts();
            comboBox1.SelectedIndexChanged += OnSelectedIndexChanged;
            
            ///Menuitems
            var fileMenu = new MenuItem[]
            {
                new MenuItem("File", new MenuItem[]
                {
                    new MenuItem("Open", OnClickOpen),
                    new MenuItem("Save", OnClickSave),
                    new MenuItem("Exit", OnClickExit),
                })
            };

            this.Menu = new MainMenu(fileMenu);

            this.Width = 850;
            this.Height = 500;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            
            if (item == null) return;
            
            if (!listBox1.Items.Contains(item))
            {
                listBox1.Items.Add(item);
            }
        }

        private void OnClickOpen(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void OnClickSave(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.ShowDialog();
        }
        private void OnClickExit(object sender, EventArgs e)
        {
           var result = MessageBox.Show("Do you want to exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
           if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            
            if (item == null) return;
            
            if(!listBox2.Items.Contains(item))
            {
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
            //var product = item as Product;
            //MessageBox.Show($"You selected : {product.Id} - {product.Name}");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
            
            if (item == null) return;

            if (!listBox1.Items.Contains(item))
            {
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
        }
    }
}
