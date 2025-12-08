namespace Tyuiu.BubenkoLG.Sprint6.Task2.V8
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridView_BLG = new DataGridView();
            buttonHelp_BLG = new Button();
            buttonDone_BLG = new Button();
            groupBoxTask_BLG = new GroupBox();
            textBoxTask_BLG = new TextBox();
            pictureBoxFormula_BLG = new PictureBox();
            groupBoxOutput_BLG = new GroupBox();
            textBoxResult_BLG = new TextBox();
            groupBoxInput_BLG = new GroupBox();
            textBoxStopValue_BLG = new TextBox();
            textBoxStart_BLG = new TextBox();
            textBoxStop_BLG = new TextBox();
            textBoxStartValue_BLG = new TextBox();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BLG).BeginInit();
            groupBoxTask_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BLG).BeginInit();
            groupBoxOutput_BLG.SuspendLayout();
            groupBoxInput_BLG.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_BLG
            // 
            dataGridView_BLG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BLG.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridView_BLG.Location = new Point(18, 76);
            dataGridView_BLG.Name = "dataGridView_BLG";
            dataGridView_BLG.ReadOnly = true;
            dataGridView_BLG.RowHeadersVisible = false;
            dataGridView_BLG.RowHeadersWidth = 82;
            dataGridView_BLG.Size = new Size(204, 485);
            dataGridView_BLG.TabIndex = 0;
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(566, 497);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(116, 112);
            buttonHelp_BLG.TabIndex = 1;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // buttonDone_BLG
            // 
            buttonDone_BLG.Location = new Point(688, 497);
            buttonDone_BLG.Name = "buttonDone_BLG";
            buttonDone_BLG.Size = new Size(237, 112);
            buttonDone_BLG.TabIndex = 2;
            buttonDone_BLG.Text = "Выполнить";
            buttonDone_BLG.UseVisualStyleBackColor = true;
            buttonDone_BLG.Click += buttonDone_BLG_Click;
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Controls.Add(pictureBoxFormula_BLG);
            groupBoxTask_BLG.Location = new Point(34, 34);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(891, 431);
            groupBoxTask_BLG.TabIndex = 3;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BackColor = SystemColors.Menu;
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(18, 38);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.Size = new Size(748, 93);
            textBoxTask_BLG.TabIndex = 12;
            textBoxTask_BLG.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // pictureBoxFormula_BLG
            // 
            pictureBoxFormula_BLG.Image = (Image)resources.GetObject("pictureBoxFormula_BLG.Image");
            pictureBoxFormula_BLG.Location = new Point(29, 117);
            pictureBoxFormula_BLG.Name = "pictureBoxFormula_BLG";
            pictureBoxFormula_BLG.Size = new Size(555, 92);
            pictureBoxFormula_BLG.TabIndex = 6;
            pictureBoxFormula_BLG.TabStop = false;
            // 
            // groupBoxOutput_BLG
            // 
            groupBoxOutput_BLG.Controls.Add(textBoxResult_BLG);
            groupBoxOutput_BLG.Controls.Add(dataGridView_BLG);
            groupBoxOutput_BLG.Location = new Point(945, 34);
            groupBoxOutput_BLG.Name = "groupBoxOutput_BLG";
            groupBoxOutput_BLG.Size = new Size(786, 575);
            groupBoxOutput_BLG.TabIndex = 4;
            groupBoxOutput_BLG.TabStop = false;
            groupBoxOutput_BLG.Text = "Вывод данных";
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.BackColor = SystemColors.Menu;
            textBoxResult_BLG.BorderStyle = BorderStyle.None;
            textBoxResult_BLG.Location = new Point(18, 38);
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.Size = new Size(288, 32);
            textBoxResult_BLG.TabIndex = 7;
            textBoxResult_BLG.Text = "Результат";
            // 
            // groupBoxInput_BLG
            // 
            groupBoxInput_BLG.Controls.Add(textBoxStopValue_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStart_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStop_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStartValue_BLG);
            groupBoxInput_BLG.Location = new Point(34, 480);
            groupBoxInput_BLG.Name = "groupBoxInput_BLG";
            groupBoxInput_BLG.Size = new Size(526, 129);
            groupBoxInput_BLG.TabIndex = 5;
            groupBoxInput_BLG.TabStop = false;
            groupBoxInput_BLG.Text = "Ввод данных";
            // 
            // textBoxStopValue_BLG
            // 
            textBoxStopValue_BLG.Location = new Point(276, 76);
            textBoxStopValue_BLG.Name = "textBoxStopValue_BLG";
            textBoxStopValue_BLG.Size = new Size(228, 39);
            textBoxStopValue_BLG.TabIndex = 11;
            // 
            // textBoxStart_BLG
            // 
            textBoxStart_BLG.BackColor = SystemColors.Menu;
            textBoxStart_BLG.BorderStyle = BorderStyle.None;
            textBoxStart_BLG.Location = new Point(18, 38);
            textBoxStart_BLG.Name = "textBoxStart_BLG";
            textBoxStart_BLG.Size = new Size(243, 32);
            textBoxStart_BLG.TabIndex = 8;
            textBoxStart_BLG.Text = "Старт шага";
            // 
            // textBoxStop_BLG
            // 
            textBoxStop_BLG.BackColor = SystemColors.Menu;
            textBoxStop_BLG.BorderStyle = BorderStyle.None;
            textBoxStop_BLG.Location = new Point(278, 38);
            textBoxStop_BLG.Name = "textBoxStop_BLG";
            textBoxStop_BLG.Size = new Size(269, 32);
            textBoxStop_BLG.TabIndex = 9;
            textBoxStop_BLG.Text = "Конец шага";
            // 
            // textBoxStartValue_BLG
            // 
            textBoxStartValue_BLG.Location = new Point(18, 76);
            textBoxStartValue_BLG.Name = "textBoxStartValue_BLG";
            textBoxStartValue_BLG.Size = new Size(243, 39);
            textBoxStartValue_BLG.TabIndex = 10;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 10;
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // Y
            // 
            Y.HeaderText = "F(x)";
            Y.MinimumWidth = 10;
            Y.Name = "Y";
            Y.ReadOnly = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1752, 629);
            Controls.Add(groupBoxInput_BLG);
            Controls.Add(groupBoxOutput_BLG);
            Controls.Add(groupBoxTask_BLG);
            Controls.Add(buttonDone_BLG);
            Controls.Add(buttonHelp_BLG);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 8 | Бубенко Л.Г.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_BLG).EndInit();
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BLG).EndInit();
            groupBoxOutput_BLG.ResumeLayout(false);
            groupBoxOutput_BLG.PerformLayout();
            groupBoxInput_BLG.ResumeLayout(false);
            groupBoxInput_BLG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_BLG;
        private Button buttonHelp_BLG;
        private Button buttonDone_BLG;
        private GroupBox groupBoxTask_BLG;
        private GroupBox groupBoxOutput_BLG;
        private GroupBox groupBoxInput_BLG;
        private PictureBox pictureBoxFormula_BLG;
        private TextBox textBoxResult_BLG;
        private TextBox textBoxStart_BLG;
        private TextBox textBoxStop_BLG;
        private TextBox textBoxStartValue_BLG;
        private TextBox textBoxStopValue_BLG;
        private TextBox textBoxTask_BLG;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
