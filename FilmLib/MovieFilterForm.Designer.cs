namespace FilmLib
{
    partial class MovieFilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFilterStudio = new TextBox();
            textBoxGenreFilter = new TextBox();
            textBoxFilterActor = new TextBox();
            textBoxFilterYear = new TextBox();
            textBoxFilterDirector = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxFilterStudio
            // 
            textBoxFilterStudio.Location = new Point(24, 32);
            textBoxFilterStudio.Name = "textBoxFilterStudio";
            textBoxFilterStudio.Size = new Size(242, 23);
            textBoxFilterStudio.TabIndex = 0;
            // 
            // textBoxGenreFilter
            // 
            textBoxGenreFilter.Location = new Point(24, 77);
            textBoxGenreFilter.Name = "textBoxGenreFilter";
            textBoxGenreFilter.Size = new Size(242, 23);
            textBoxGenreFilter.TabIndex = 1;
            // 
            // textBoxFilterActor
            // 
            textBoxFilterActor.Location = new Point(24, 121);
            textBoxFilterActor.Name = "textBoxFilterActor";
            textBoxFilterActor.Size = new Size(242, 23);
            textBoxFilterActor.TabIndex = 2;
            // 
            // textBoxFilterYear
            // 
            textBoxFilterYear.Location = new Point(337, 32);
            textBoxFilterYear.Name = "textBoxFilterYear";
            textBoxFilterYear.Size = new Size(228, 23);
            textBoxFilterYear.TabIndex = 3;
            // 
            // textBoxFilterDirector
            // 
            textBoxFilterDirector.Location = new Point(337, 77);
            textBoxFilterDirector.Name = "textBoxFilterDirector";
            textBoxFilterDirector.Size = new Size(228, 23);
            textBoxFilterDirector.TabIndex = 4;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(337, 112);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(97, 34);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "Підібрати";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(468, 112);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(97, 34);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "Студія";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 103);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Актор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 14);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Рік виходу";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 59);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Режисер";
            // 
            // MovieFilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 171);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxFilterDirector);
            Controls.Add(textBoxFilterYear);
            Controls.Add(textBoxFilterActor);
            Controls.Add(textBoxGenreFilter);
            Controls.Add(textBoxFilterStudio);
            MaximumSize = new Size(619, 210);
            MinimumSize = new Size(619, 210);
            Name = "MovieFilterForm";
            Text = "Підбір фільму";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilterStudio;
        private TextBox textBoxGenreFilter;
        private TextBox textBoxFilterActor;
        private TextBox textBoxFilterYear;
        private TextBox textBoxFilterDirector;
        private Button buttonOK;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}