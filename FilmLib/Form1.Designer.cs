namespace FilmLib
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxMovies = new ListBox();
            dataGridViewDetails = new DataGridView();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            listBoxFilter = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxMovies
            // 
            listBoxMovies.Anchor = AnchorStyles.Top;
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.HorizontalScrollbar = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(18, 50);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(251, 229);
            listBoxMovies.TabIndex = 0;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.Anchor = AnchorStyles.Top;
            dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetails.Location = new Point(394, 50);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.ReadOnly = true;
            dataGridViewDetails.Size = new Size(400, 274);
            dataGridViewDetails.TabIndex = 1;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top;
            buttonEdit.Location = new Point(298, 175);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 14;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top;
            buttonAdd.Location = new Point(298, 204);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top;
            buttonDelete.Location = new Point(298, 146);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 1);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(209, 25);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(89, 22);
            toolStripButton1.Text = "Підбір фільму";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(108, 22);
            toolStripButton2.Text = "Створити вибірку";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // listBoxFilter
            // 
            listBoxFilter.Anchor = AnchorStyles.Top;
            listBoxFilter.FormattingEnabled = true;
            listBoxFilter.ItemHeight = 15;
            listBoxFilter.Location = new Point(18, 305);
            listBoxFilter.Name = "listBoxFilter";
            listBoxFilter.Size = new Size(251, 109);
            listBoxFilter.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 19;
            label1.Text = "Список фільмів";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(394, 32);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 20;
            label2.Text = "Відомості";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(18, 287);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 21;
            label3.Text = "Відфільтровані фільми";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxFilter);
            Controls.Add(toolStrip1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridViewDetails);
            Controls.Add(listBoxMovies);
            MinimumSize = new Size(859, 489);
            Name = "Form1";
            Text = "Фільмотека";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMovies;
        private DataGridView dataGridViewDetails;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDelete;
        private ToolStrip toolStrip1;
        private ListBox listBoxFilter;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
