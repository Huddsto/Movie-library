using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib
{
    public partial class AddMovie : Form
    {
        public string Title => textBoxTitle.Text;
        public string Studio => textBoxStudio.Text;
        public string Genre => textBoxGenre.Text;
        public string YearOfRelease => textBoxYear.Text;
        public string Director => textBoxDirector.Text;
        public string LeadActors => textBoxActors.Text;
        public string Summary => textBoxSummary.Text;
        public string Score => textBoxScore.Text;
        public string Location => textBoxLocation.Text;
        public string FileSize => textBoxSize.Text;
        public string Lenght => textBoxLenght.Text;

        public AddMovie()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    textBoxLocation.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
