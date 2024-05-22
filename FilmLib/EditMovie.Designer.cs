namespace FilmLib
{
    partial class EditMovie
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
            textBoxDirector = new TextBox();
            textBoxYear = new TextBox();
            textBoxSize = new TextBox();
            textBoxLocation = new TextBox();
            textBoxScore = new TextBox();
            textBoxSummary = new TextBox();
            textBoxActors = new TextBox();
            textBoxGenre = new TextBox();
            textBoxStudio = new TextBox();
            textBoxTitle = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            buttonBrowse = new Button();
            textBoxLenght = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // textBoxDirector
            // 
            textBoxDirector.Location = new Point(12, 209);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(261, 23);
            textBoxDirector.TabIndex = 31;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(336, 27);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 30;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(336, 114);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(100, 23);
            textBoxSize.TabIndex = 29;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(336, 209);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(281, 23);
            textBoxLocation.TabIndex = 28;
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(336, 162);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(100, 23);
            textBoxScore.TabIndex = 27;
            // 
            // textBoxSummary
            // 
            textBoxSummary.Location = new Point(489, 27);
            textBoxSummary.Multiline = true;
            textBoxSummary.Name = "textBoxSummary";
            textBoxSummary.Size = new Size(209, 158);
            textBoxSummary.TabIndex = 26;
            // 
            // textBoxActors
            // 
            textBoxActors.Location = new Point(12, 162);
            textBoxActors.Name = "textBoxActors";
            textBoxActors.Size = new Size(261, 23);
            textBoxActors.TabIndex = 25;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(12, 114);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(261, 23);
            textBoxGenre.TabIndex = 24;
            // 
            // textBoxStudio
            // 
            textBoxStudio.Location = new Point(12, 70);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(261, 23);
            textBoxStudio.TabIndex = 23;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(261, 23);
            textBoxTitle.TabIndex = 22;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 255);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 38);
            buttonSave.TabIndex = 32;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(141, 255);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 38);
            buttonCancel.TabIndex = 33;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click_1;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(623, 209);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 34;
            buttonBrowse.Text = "Огляд";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBoxLenght
            // 
            textBoxLenght.Location = new Point(336, 70);
            textBoxLenght.Name = "textBoxLenght";
            textBoxLenght.Size = new Size(100, 23);
            textBoxLenght.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 9);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 46;
            label10.Text = "Опис сюжету";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 191);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 45;
            label9.Text = "Розташування на диску";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 96);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 44;
            label8.Text = "Розмір";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 53);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 43;
            label7.Text = "Тривалість (у секундах)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 144);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 42;
            label6.Text = "Оцінка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 9);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 41;
            label5.Text = "Рік виходу";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 40;
            label4.Text = "Актори";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 39;
            label3.Text = "Жанр";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 38;
            label2.Text = "Студія";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 37;
            label1.Text = "Назва";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 191);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 47;
            label11.Text = "Режисер";
            // 
            // EditMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 325);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLenght);
            Controls.Add(buttonBrowse);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDirector);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxScore);
            Controls.Add(textBoxSummary);
            Controls.Add(textBoxActors);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxStudio);
            Controls.Add(textBoxTitle);
            MaximumSize = new Size(726, 364);
            MinimumSize = new Size(726, 364);
            Name = "EditMovie";
            Text = "Редагування фільму";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDirector;
        private TextBox textBoxYear;
        private TextBox textBoxSize;
        private TextBox textBoxLocation;
        private TextBox textBoxScore;
        private TextBox textBoxSummary;
        private TextBox textBoxActors;
        private TextBox textBoxGenre;
        private TextBox textBoxStudio;
        private TextBox textBoxTitle;
        private Button buttonSave;
        private Button buttonCancel;
        private Button buttonBrowse;
        private TextBox textBoxLenght;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
    }
}