using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmLib.Models;

namespace FilmLib
{
    public partial class EditMovie : Form
    {
        public string Title
        {
            get => textBoxTitle.Text;
            set => textBoxTitle.Text = value;
        }

        public string Studio
        {
            get => textBoxStudio.Text;
            set => textBoxStudio.Text = value;
        }

        public string Genre
        {
            get => textBoxGenre.Text;
            set => textBoxGenre.Text = value;
        }

        public int YearOfRelease
        {
            get => Convert.ToInt32(textBoxYear.Text);
            set => textBoxYear.Text = value.ToString();
        }

        public string Director
        {
            get => textBoxDirector.Text;
            set => textBoxDirector.Text = value;
        }

        public string LeadActors
        {
            get => textBoxActors.Text;
            set => textBoxActors.Text = value;
        }

        public string Summary
        {
            get => textBoxSummary.Text;
            set => textBoxSummary.Text = value;
        }

        public double Score
        {
            get => Convert.ToDouble(textBoxScore.Text);
            set => textBoxScore.Text = value.ToString();
        }

        public string Location
        {
            get => textBoxLocation.Text;
            set => textBoxLocation.Text = value;
        }

        public long FileSize
        {
            get => Convert.ToInt64(textBoxSize.Text);
            set => textBoxSize.Text = value.ToString();
        }

        public int Lenght
        {
            get => Convert.ToInt32(textBoxLenght.Text);
            set => textBoxLenght.Text = value.ToString();
        }

        public EditMovie()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Cancel operation
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
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
    }
}

