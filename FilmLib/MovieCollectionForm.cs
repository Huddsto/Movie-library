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
    public partial class MovieCollectionForm : Form
    {
        public string Length { get; private set; }
        public string HardDriveSize { get; private set; }
        public string Genre { get; private set; }
        public string LeadActors { get; private set; }
        public string Director { get; private set; }
        public MovieCollectionForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Length = textBoxLengthFilter.Text;
            HardDriveSize = textBoxHardDrive.Text;
            Genre = textBoxGenreFilter.Text;
            LeadActors = textBoxActorFilter.Text;
            Director = textBoxDirectorFilter.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
