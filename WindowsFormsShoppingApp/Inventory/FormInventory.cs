using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsShoppingApp.Inventory
{
    public partial class FormInventory : Form
    {
        public string Filter { get; set; } = "All text files *.txt | *.txt";
        public FormInventory()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = Filter;
            ofd.ShowDialog();
            var contentOfFile = File.ReadAllText(ofd.FileName);
            richTextBox1.Text = contentOfFile;
            richTextBox1.ForeColor = Color.Red;
            //MessageBox.Show(ofd.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = Filter;
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName, richTextBox1.Text);
        }
    }
}
