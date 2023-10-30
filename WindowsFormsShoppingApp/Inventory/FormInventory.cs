using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsShoppingApp.Inventory
{
    public partial class FormInventory : Form
    {
        public string Filter { get; set; } = "All text files *.txt | *.txt | All Files | *.*";
        public FormInventory()
        {
            InitializeComponent();

            var fileMenu = new MenuItem[]
            {
                new MenuItem("Open", (o, e)=> { btnBrowse_Click(o, e); }),
                new MenuItem("Save"),
                new MenuItem("Exit")
            };
            var appMenu = new MenuItem[]{
                new MenuItem("File", fileMenu),
                new MenuItem("Edit")
            };
            this.Menu = new MainMenu(appMenu);
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
