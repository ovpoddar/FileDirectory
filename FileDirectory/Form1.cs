using System;
using System.IO;
using System.Windows.Forms;

namespace FileDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Input.Text))
                Output.Text = SearchDirectory(Input.Text, 0);
            else
                MessageBox.Show("no directory found");
        }

        private string SearchDirectory(string path, uint depth)
        {
            var result = "";
            var space = "";


            for (uint i = 0; i < depth; i++)
                space += "\t";
            depth += 1;


            foreach (var item in Directory.GetDirectories(path))
            {
                result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";
                result += SearchDirectory(item, depth);
            }


            foreach (var item in Directory.GetFiles(path))
                result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";

            return result;
        }
    }
}
