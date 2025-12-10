namespace Tyuiu.BubenkoLG.Sprint6.Task5.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_BLG = new GroupBox();
            textBoxTask_BLG = new TextBox();
            textBoxOutPut_BLG = new TextBox();
            textBoxResult_BLG = new TextBox();
            buttonHelp_BLG = new Button();
            buttonOpenFile_BLG = new Button();
            buttonDone_BLG = new Button();
            chartFunction_BLG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BLG).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Location = new Point(21, 21);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(791, 186);
            groupBoxTask_BLG.TabIndex = 0;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(11, 38);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.ReadOnly = true;
            textBoxTask_BLG.Size = new Size(774, 142);
            textBoxTask_BLG.TabIndex = 1;
            textBoxTask_BLG.Text = resources.GetString("textBoxTask_BLG.Text");
            // 
            // textBoxOutPut_BLG
            // 
            textBoxOutPut_BLG.BackColor = SystemColors.Menu;
            textBoxOutPut_BLG.BorderStyle = BorderStyle.None;
            textBoxOutPut_BLG.Location = new Point(32, 213);
            textBoxOutPut_BLG.Name = "textBoxOutPut_BLG";
            textBoxOutPut_BLG.Size = new Size(168, 32);
            textBoxOutPut_BLG.TabIndex = 1;
            textBoxOutPut_BLG.Text = "Вывод данных";
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.BackColor = SystemColors.ActiveBorder;
            textBoxResult_BLG.Location = new Point(25, 257);
            textBoxResult_BLG.Multiline = true;
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.ReadOnly = true;
            textBoxResult_BLG.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BLG.Size = new Size(193, 531);
            textBoxResult_BLG.TabIndex = 2;
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(827, 125);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(84, 82);
            buttonHelp_BLG.TabIndex = 3;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // buttonOpenFile_BLG
            // 
            buttonOpenFile_BLG.Location = new Point(926, 125);
            buttonOpenFile_BLG.Name = "buttonOpenFile_BLG";
            buttonOpenFile_BLG.Size = new Size(209, 82);
            buttonOpenFile_BLG.TabIndex = 4;
            buttonOpenFile_BLG.Text = "Открыть файл";
            buttonOpenFile_BLG.UseVisualStyleBackColor = true;
            buttonOpenFile_BLG.Click += buttonOpenFile_BLG_Click;
            // 
            // buttonDone_BLG
            // 
            buttonDone_BLG.Location = new Point(1152, 125);
            buttonDone_BLG.Name = "buttonDone_BLG";
            buttonDone_BLG.Size = new Size(179, 82);
            buttonDone_BLG.TabIndex = 5;
            buttonDone_BLG.Text = "Выполнить";
            buttonDone_BLG.UseVisualStyleBackColor = true;
            buttonDone_BLG.Click += buttonDone_BLG_Click;
            // 
            // chartFunction_BLG
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BLG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BLG.Legends.Add(legend1);
            chartFunction_BLG.Location = new Point(240, 224);
            chartFunction_BLG.Name = "chartFunction_BLG";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BLG.Series.Add(series1);
            chartFunction_BLG.Size = new Size(1091, 564);
            chartFunction_BLG.TabIndex = 6;
            chartFunction_BLG.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 808);
            Controls.Add(chartFunction_BLG);
            Controls.Add(buttonDone_BLG);
            Controls.Add(buttonOpenFile_BLG);
            Controls.Add(buttonHelp_BLG);
            Controls.Add(textBoxResult_BLG);
            Controls.Add(textBoxOutPut_BLG);
            Controls.Add(groupBoxTask_BLG);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Бубенко Л.Г.";
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BLG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_BLG;
        private TextBox textBoxTask_BLG;
        private TextBox textBoxOutPut_BLG;
        private TextBox textBoxResult_BLG;
        private Button buttonHelp_BLG;
        private Button buttonOpenFile_BLG;
        private Button buttonDone_BLG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BLG;
    }
}
