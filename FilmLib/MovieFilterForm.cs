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
    public partial class MovieFilterForm : Form
    {

        public string Studio { get; private set; }
        public string Genre { get; private set; }
        public string Year { get; private set; }
        public string Director { get; private set; }
        public string LeadActor { get; private set; }

        public MovieFilterForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Studio = textBoxFilterStudio.Text;
            Genre = textBoxGenreFilter.Text;
            Year = textBoxFilterYear.Text;
            Director = textBoxFilterDirector.Text;
            LeadActor = textBoxFilterActor.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
