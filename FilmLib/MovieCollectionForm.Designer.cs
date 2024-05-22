namespace FilmLib
{
    partial class MovieCollectionForm
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
            textBoxLengthFilter = new TextBox();
            textBoxHardDrive = new TextBox();
            textBoxGenreFilter = new TextBox();
            textBoxActorFilter = new TextBox();
            textBoxDirectorFilter = new TextBox();
            buttonOK = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxLengthFilter
            // 
            textBoxLengthFilter.Location = new Point(15, 27);
            textBoxLengthFilter.Name = "textBoxLengthFilter";
            textBoxLengthFilter.Size = new Size(218, 23);
            textBoxLengthFilter.TabIndex = 0;
            // 
            // textBoxHardDrive
            // 
            textBoxHardDrive.Location = new Point(15, 71);
            textBoxHardDrive.Name = "textBoxHardDrive";
            textBoxHardDrive.Size = new Size(218, 23);
            textBoxHardDrive.TabIndex = 1;
            // 
            // textBoxGenreFilter
            // 
            textBoxGenreFilter.Location = new Point(15, 115);
            textBoxGenreFilter.Name = "textBoxGenreFilter";
            textBoxGenreFilter.Size = new Size(218, 23);
            textBoxGenreFilter.TabIndex = 2;
            // 
            // textBoxActorFilter
            // 
            textBoxActorFilter.Location = new Point(287, 27);
            textBoxActorFilter.Name = "textBoxActorFilter";
            textBoxActorFilter.Size = new Size(271, 23);
            textBoxActorFilter.TabIndex = 3;
            // 
            // textBoxDirectorFilter
            // 
            textBoxDirectorFilter.Location = new Point(287, 71);
            textBoxDirectorFilter.Name = "textBoxDirectorFilter";
            textBoxDirectorFilter.Size = new Size(271, 23);
            textBoxDirectorFilter.TabIndex = 4;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(297, 108);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(97, 34);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 6;
            label1.Text = "Тривалість";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 7;
            label2.Text = "Розмір носія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 97);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 9);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Актори";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 53);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Режисер";
            // 
            // button1
            // 
            button1.Location = new Point(449, 108);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 11;
            button1.Text = "Скасувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MovieCollectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 171);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonOK);
            Controls.Add(textBoxDirectorFilter);
            Controls.Add(textBoxActorFilter);
            Controls.Add(textBoxGenreFilter);
            Controls.Add(textBoxHardDrive);
            Controls.Add(textBoxLengthFilter);
            MaximumSize = new Size(619, 210);
            MinimumSize = new Size(619, 210);
            Name = "MovieCollectionForm";
            Text = "Створити вибірку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLengthFilter;
        private TextBox textBoxHardDrive;
        private TextBox textBoxGenreFilter;
        private TextBox textBoxActorFilter;
        private TextBox textBoxDirectorFilter;
        private Button buttonOK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}