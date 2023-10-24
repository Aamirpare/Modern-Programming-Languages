using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsShoppingApp.Inventory;

namespace WindowsFormsShoppingApp
{
    public partial class MainForm : Form
    {
        private string UserName { get; set; } = "Aamir";
        private string Password { get; set; } = "123456";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == UserName && textBoxPassword.Text == Password)
            {
                var form = new FormInventory();
                //form.WindowState = FormWindowState.Maximized;
                Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Initial loading....");
        }
    }
}
