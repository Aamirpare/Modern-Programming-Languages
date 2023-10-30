using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsShoppingApp
{
    public partial class FormApplicationMain : Form
    {
        string Filter { get; set; } = "All text files *.txt | *.txt | All Files | *.*";
        public void Configure()
        {
            this.Text = "Application Main Form - Editor";
            richTextBoxEditor.Font = new Font("Arial", 14.0f);
            //this.BackColor = Color.Black;
            this.WindowState = FormWindowState.Maximized;
        }

        public void CreateMenu()
        {
            var fileMenu = new MenuItem[]
               {
                new MenuItem("File", new MenuItem[]
                {
                    new MenuItem("Open", OnOpenClick ),
                    new MenuItem("Save"),
                    new MenuItem("Exit", OnExitClick)
                })
               };
            var mainMenu = new MainMenu(fileMenu);

            this.Menu = mainMenu;

        }

        public FormApplicationMain()
        {
            InitializeComponent();
            Configure();
            CreateMenu();
        }
        void OnOpenClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = Filter;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var contentOfFile = File.ReadAllText(ofd.FileName);
                richTextBoxEditor.Text = contentOfFile;
                richTextBoxEditor.ForeColor = Color.Red;
            }
        }

        void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
