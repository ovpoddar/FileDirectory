using FileDirectory.Helpers;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDirectory
{
    public partial class Form1 : Form
    {
        private string _path { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(_path) && Filehelper.IsAccessible(_path))
            {
                UiAccess(false);
                var responce = Filehelper.SearchDirectory(_path, 0);
                Output.Text = responce;
                UiAccess(true);
            }
            else
                MessageBox.Show("no directory found");
        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() != DialogResult.OK) return;
            _path = folder.SelectedPath;
            Input.Text = _path;
        }

        private void Input_TextChanged(object sender, EventArgs e) =>
            _path = Input.Text;

        private void UiAccess(bool state)
        {
            Input.Enabled = state;
            button.Enabled = state;
            Input.Enabled = state;
        }
    }
}
