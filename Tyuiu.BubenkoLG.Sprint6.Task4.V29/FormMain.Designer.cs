namespace Tyuiu.BubenkoLG.Sprint6.Task4.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_BLG = new GroupBox();
            pictureBoxFormula_BLG = new PictureBox();
            textBoxTask_BLG = new TextBox();
            groupBoxInput_BLG = new GroupBox();
            textBoxStop_BLG = new TextBox();
            textBoxStartValue_BLG = new TextBox();
            textBoxStopValue_BLG = new TextBox();
            textBoxStart_BLG = new TextBox();
            buttonHelp_BLG = new Button();
            buttonDone_BLG = new Button();
            buttonSave_BLG = new Button();
            textBoxOutput_BLG = new TextBox();
            chartGraphic_BLG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult_BLG = new TextBox();
            groupBoxTask_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BLG).BeginInit();
            groupBoxInput_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphic_BLG).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(pictureBoxFormula_BLG);
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Location = new Point(15, 17);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(679, 296);
            groupBoxTask_BLG.TabIndex = 0;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // pictureBoxFormula_BLG
            // 
            pictureBoxFormula_BLG.Image = (Image)resources.GetObject("pictureBoxFormula_BLG.Image");
            pictureBoxFormula_BLG.Location = new Point(18, 192);
            pictureBoxFormula_BLG.Name = "pictureBoxFormula_BLG";
            pictureBoxFormula_BLG.Size = new Size(510, 86);
            pictureBoxFormula_BLG.TabIndex = 2;
            pictureBoxFormula_BLG.TabStop = false;
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BackColor = SystemColors.Menu;
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(6, 48);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.ReadOnly = true;
            textBoxTask_BLG.Size = new Size(605, 138);
            textBoxTask_BLG.TabIndex = 1;
            textBoxTask_BLG.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V29.txt по нажатию кнопки.";
            // 
            // groupBoxInput_BLG
            // 
            groupBoxInput_BLG.Controls.Add(textBoxStop_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStartValue_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStopValue_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStart_BLG);
            groupBoxInput_BLG.Location = new Point(711, 17);
            groupBoxInput_BLG.Name = "groupBoxInput_BLG";
            groupBoxInput_BLG.Size = new Size(446, 132);
            groupBoxInput_BLG.TabIndex = 1;
            groupBoxInput_BLG.TabStop = false;
            groupBoxInput_BLG.Text = "Ввод данных";
            // 
            // textBoxStop_BLG
            // 
            textBoxStop_BLG.BackColor = SystemColors.Menu;
            textBoxStop_BLG.BorderStyle = BorderStyle.None;
            textBoxStop_BLG.Location = new Point(234, 38);
            textBoxStop_BLG.Name = "textBoxStop_BLG";
            textBoxStop_BLG.ReadOnly = true;
            textBoxStop_BLG.Size = new Size(158, 32);
            textBoxStop_BLG.TabIndex = 3;
            textBoxStop_BLG.Text = "Конец шага";
            // 
            // textBoxStartValue_BLG
            // 
            textBoxStartValue_BLG.Location = new Point(16, 76);
            textBoxStartValue_BLG.Name = "textBoxStartValue_BLG";
            textBoxStartValue_BLG.Size = new Size(196, 39);
            textBoxStartValue_BLG.TabIndex = 2;
            // 
            // textBoxStopValue_BLG
            // 
            textBoxStopValue_BLG.Location = new Point(234, 76);
            textBoxStopValue_BLG.Name = "textBoxStopValue_BLG";
            textBoxStopValue_BLG.Size = new Size(196, 39);
            textBoxStopValue_BLG.TabIndex = 3;
            // 
            // textBoxStart_BLG
            // 
            textBoxStart_BLG.BackColor = SystemColors.Menu;
            textBoxStart_BLG.BorderStyle = BorderStyle.None;
            textBoxStart_BLG.Location = new Point(16, 38);
            textBoxStart_BLG.Name = "textBoxStart_BLG";
            textBoxStart_BLG.ReadOnly = true;
            textBoxStart_BLG.Size = new Size(158, 32);
            textBoxStart_BLG.TabIndex = 2;
            textBoxStart_BLG.Text = "Старт шага";
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(711, 167);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(75, 73);
            buttonHelp_BLG.TabIndex = 2;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // buttonDone_BLG
            // 
            buttonDone_BLG.Location = new Point(807, 167);
            buttonDone_BLG.Name = "buttonDone_BLG";
            buttonDone_BLG.Size = new Size(193, 73);
            buttonDone_BLG.TabIndex = 3;
            buttonDone_BLG.Text = "Выполнить";
            buttonDone_BLG.UseVisualStyleBackColor = true;
            buttonDone_BLG.Click += buttonDone_BLG_Click;
            // 
            // buttonSave_BLG
            // 
            buttonSave_BLG.Location = new Point(1020, 170);
            buttonSave_BLG.Name = "buttonSave_BLG";
            buttonSave_BLG.Size = new Size(209, 70);
            buttonSave_BLG.TabIndex = 4;
            buttonSave_BLG.Text = "Сохранить";
            buttonSave_BLG.UseVisualStyleBackColor = true;
            buttonSave_BLG.Click += buttonSave_BLG_Click;
            // 
            // textBoxOutput_BLG
            // 
            textBoxOutput_BLG.BackColor = SystemColors.Menu;
            textBoxOutput_BLG.BorderStyle = BorderStyle.None;
            textBoxOutput_BLG.Location = new Point(21, 319);
            textBoxOutput_BLG.Name = "textBoxOutput_BLG";
            textBoxOutput_BLG.Size = new Size(158, 32);
            textBoxOutput_BLG.TabIndex = 4;
            textBoxOutput_BLG.Text = "Вывод";
            // 
            // chartGraphic_BLG
            // 
            chartGraphic_BLG.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            chartArea2.Name = "ChartArea1";
            chartGraphic_BLG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGraphic_BLG.Legends.Add(legend2);
            chartGraphic_BLG.Location = new Point(248, 330);
            chartGraphic_BLG.Name = "chartGraphic_BLG";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGraphic_BLG.Series.Add(series2);
            chartGraphic_BLG.Size = new Size(981, 707);
            chartGraphic_BLG.TabIndex = 6;
            title2.Name = "График функции F(x)";
            title2.Text = "График функции F(x)";
            chartGraphic_BLG.Titles.Add(title2);
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.BackColor = SystemColors.ActiveBorder;
            textBoxResult_BLG.Location = new Point(15, 364);
            textBoxResult_BLG.Multiline = true;
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.ReadOnly = true;
            textBoxResult_BLG.Size = new Size(212, 673);
            textBoxResult_BLG.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 1049);
            Controls.Add(textBoxResult_BLG);
            Controls.Add(chartGraphic_BLG);
            Controls.Add(textBoxOutput_BLG);
            Controls.Add(buttonSave_BLG);
            Controls.Add(groupBoxInput_BLG);
            Controls.Add(groupBoxTask_BLG);
            Controls.Add(buttonDone_BLG);
            Controls.Add(buttonHelp_BLG);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 29 | Бубенко Л.Г.";
            Load += Form1_Load;
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BLG).EndInit();
            groupBoxInput_BLG.ResumeLayout(false);
            groupBoxInput_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphic_BLG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_BLG;
        private TextBox textBoxTask_BLG;
        private GroupBox groupBoxInput_BLG;
        private TextBox textBoxStartValue_BLG;
        private TextBox textBoxStart_BLG;
        private TextBox textBoxStopValue_BLG;
        private TextBox textBoxStop_BLG;
        private PictureBox pictureBoxFormula_BLG;
        private Button buttonSave_BLG;
        private Button buttonDone_BLG;
        private Button buttonHelp_BLG;
        private TextBox textBoxOutput_BLG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic_BLG;
        private TextBox textBoxResult_BLG;
    }
}
