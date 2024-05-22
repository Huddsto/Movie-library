namespace FilmLib
{
    partial class AddMovie
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
            buttonAdd = new Button();
            buttonCancel = new Button();
            textBoxTitle = new TextBox();
            textBoxStudio = new TextBox();
            textBoxGenre = new TextBox();
            textBoxSize = new TextBox();
            textBoxLocation = new TextBox();
            textBoxScore = new TextBox();
            textBoxSummary = new TextBox();
            textBoxActors = new TextBox();
            textBoxYear = new TextBox();
            textBoxDirector = new TextBox();
            buttonBrowse = new Button();
            textBoxLenght = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 255);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 38);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(141, 255);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 38);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(261, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxStudio
            // 
            textBoxStudio.Location = new Point(12, 71);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(261, 23);
            textBoxStudio.TabIndex = 3;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(12, 116);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(261, 23);
            textBoxGenre.TabIndex = 4;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(336, 116);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(98, 23);
            textBoxSize.TabIndex = 19;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(336, 212);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(281, 23);
            textBoxLocation.TabIndex = 18;
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(336, 162);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(98, 23);
            textBoxScore.TabIndex = 17;
            // 
            // textBoxSummary
            // 
            textBoxSummary.Location = new Point(491, 33);
            textBoxSummary.Multiline = true;
            textBoxSummary.Name = "textBoxSummary";
            textBoxSummary.Size = new Size(209, 158);
            textBoxSummary.TabIndex = 16;
            // 
            // textBoxActors
            // 
            textBoxActors.Location = new Point(12, 162);
            textBoxActors.Name = "textBoxActors";
            textBoxActors.Size = new Size(261, 23);
            textBoxActors.TabIndex = 15;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(336, 27);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(98, 23);
            textBoxYear.TabIndex = 20;
            // 
            // textBoxDirector
            // 
            textBoxDirector.Location = new Point(12, 212);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(261, 23);
            textBoxDirector.TabIndex = 21;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(623, 211);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 22;
            buttonBrowse.Text = "Огляд";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBoxLenght
            // 
            textBoxLenght.Location = new Point(336, 71);
            textBoxLenght.Name = "textBoxLenght";
            textBoxLenght.Size = new Size(98, 23);
            textBoxLenght.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 27;
            label1.Text = "Назва";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 53);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 28;
            label2.Text = "Студія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 29;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 30;
            label4.Text = "Актори";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 9);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 31;
            label5.Text = "Рік виходу";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 144);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 32;
            label6.Text = "Оцінка";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 53);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 33;
            label7.Text = "Тривалість (у секундах)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 98);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 34;
            label8.Text = "Розмір";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 194);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 35;
            label9.Text = "Розташування";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(491, 9);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 36;
            label10.Text = "Опис сюжету";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 194);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 48;
            label11.Text = "Режисер";
            // 
            // AddMovie
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
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            MaximumSize = new Size(726, 364);
            MinimumSize = new Size(726, 364);
            Name = "AddMovie";
            Text = "Додавання фільму";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonCancel;
        private TextBox textBoxTitle;
        private TextBox textBoxStudio;
        private TextBox textBoxGenre;
        private TextBox textBoxSize;
        private TextBox textBoxLocation;
        private TextBox textBoxScore;
        private TextBox textBoxSummary;
        private TextBox textBoxActors;
        private TextBox textBoxYear;
        private TextBox textBoxDirector;
        private Button buttonBrowse;
        private TextBox textBoxLenght;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}