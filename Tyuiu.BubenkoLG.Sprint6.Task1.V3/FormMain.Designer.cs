namespace Tyuiu.BubenkoLG.Sprint6.Task1.V3
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
            groupBoxTask_BLG = new GroupBox();
            textBoxTask_BLG = new TextBox();
            pictureBoxFormula_BLG = new PictureBox();
            groupBoxInput_BLG = new GroupBox();
            textBoxStart_BLG = new TextBox();
            textBoxStartValue_BLG = new TextBox();
            textBoxStop_BLG = new TextBox();
            textBoxStopValue_BLG = new TextBox();
            groupBoxOutput_BLG = new GroupBox();
            textBoxOutput_BLG = new TextBox();
            textBoxResult_BLG = new TextBox();
            buttonHelp_BLG = new Button();
            buttonDone_BLG = new Button();
            groupBoxTask_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BLG).BeginInit();
            groupBoxInput_BLG.SuspendLayout();
            groupBoxOutput_BLG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Controls.Add(pictureBoxFormula_BLG);
            groupBoxTask_BLG.Location = new Point(26, 30);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(912, 329);
            groupBoxTask_BLG.TabIndex = 0;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BackColor = SystemColors.Menu;
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(22, 51);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.Size = new Size(619, 89);
            textBoxTask_BLG.TabIndex = 12;
            textBoxTask_BLG.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // pictureBoxFormula_BLG
            // 
            pictureBoxFormula_BLG.Image = (Image)resources.GetObject("pictureBoxFormula_BLG.Image");
            pictureBoxFormula_BLG.Location = new Point(22, 132);
            pictureBoxFormula_BLG.Name = "pictureBoxFormula_BLG";
            pictureBoxFormula_BLG.Size = new Size(484, 91);
            pictureBoxFormula_BLG.TabIndex = 5;
            pictureBoxFormula_BLG.TabStop = false;
            // 
            // groupBoxInput_BLG
            // 
            groupBoxInput_BLG.Controls.Add(textBoxStart_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStartValue_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStop_BLG);
            groupBoxInput_BLG.Controls.Add(textBoxStopValue_BLG);
            groupBoxInput_BLG.Location = new Point(26, 377);
            groupBoxInput_BLG.Name = "groupBoxInput_BLG";
            groupBoxInput_BLG.Size = new Size(530, 140);
            groupBoxInput_BLG.TabIndex = 1;
            groupBoxInput_BLG.TabStop = false;
            groupBoxInput_BLG.Text = "Ввод данных";
            // 
            // textBoxStart_BLG
            // 
            textBoxStart_BLG.BackColor = SystemColors.Menu;
            textBoxStart_BLG.BorderStyle = BorderStyle.None;
            textBoxStart_BLG.Location = new Point(6, 35);
            textBoxStart_BLG.Name = "textBoxStart_BLG";
            textBoxStart_BLG.Size = new Size(233, 32);
            textBoxStart_BLG.TabIndex = 8;
            textBoxStart_BLG.Text = "Старт шага";
            // 
            // textBoxStartValue_BLG
            // 
            textBoxStartValue_BLG.Location = new Point(6, 73);
            textBoxStartValue_BLG.Name = "textBoxStartValue_BLG";
            textBoxStartValue_BLG.Size = new Size(233, 39);
            textBoxStartValue_BLG.TabIndex = 6;
            textBoxStartValue_BLG.KeyPress += textBoxStartValue_BLG_KeyPress;
            // 
            // textBoxStop_BLG
            // 
            textBoxStop_BLG.BackColor = SystemColors.Menu;
            textBoxStop_BLG.BorderStyle = BorderStyle.None;
            textBoxStop_BLG.Location = new Point(260, 35);
            textBoxStop_BLG.Name = "textBoxStop_BLG";
            textBoxStop_BLG.Size = new Size(246, 32);
            textBoxStop_BLG.TabIndex = 9;
            textBoxStop_BLG.Text = "Конец шага";
            // 
            // textBoxStopValue_BLG
            // 
            textBoxStopValue_BLG.Location = new Point(256, 73);
            textBoxStopValue_BLG.Name = "textBoxStopValue_BLG";
            textBoxStopValue_BLG.Size = new Size(250, 39);
            textBoxStopValue_BLG.TabIndex = 7;
            textBoxStopValue_BLG.KeyPress += textBoxStartValue_BLG_KeyPress;
            // 
            // groupBoxOutput_BLG
            // 
            groupBoxOutput_BLG.Controls.Add(textBoxOutput_BLG);
            groupBoxOutput_BLG.Controls.Add(textBoxResult_BLG);
            groupBoxOutput_BLG.Location = new Point(961, 48);
            groupBoxOutput_BLG.Name = "groupBoxOutput_BLG";
            groupBoxOutput_BLG.Size = new Size(523, 469);
            groupBoxOutput_BLG.TabIndex = 2;
            groupBoxOutput_BLG.TabStop = false;
            groupBoxOutput_BLG.Text = "Вывод данных";
            // 
            // textBoxOutput_BLG
            // 
            textBoxOutput_BLG.BackColor = SystemColors.ControlLightLight;
            textBoxOutput_BLG.Location = new Point(19, 88);
            textBoxOutput_BLG.Multiline = true;
            textBoxOutput_BLG.Name = "textBoxOutput_BLG";
            textBoxOutput_BLG.ReadOnly = true;
            textBoxOutput_BLG.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_BLG.Size = new Size(493, 368);
            textBoxOutput_BLG.TabIndex = 11;
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.BackColor = SystemColors.Menu;
            textBoxResult_BLG.BorderStyle = BorderStyle.None;
            textBoxResult_BLG.Location = new Point(22, 38);
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.Size = new Size(257, 32);
            textBoxResult_BLG.TabIndex = 10;
            textBoxResult_BLG.Text = "Результат";
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(575, 395);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(122, 122);
            buttonHelp_BLG.TabIndex = 3;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // buttonDone_BLG
            // 
            buttonDone_BLG.Location = new Point(723, 395);
            buttonDone_BLG.Name = "buttonDone_BLG";
            buttonDone_BLG.Size = new Size(215, 119);
            buttonDone_BLG.TabIndex = 4;
            buttonDone_BLG.Text = "Выполнить";
            buttonDone_BLG.UseVisualStyleBackColor = true;
            buttonDone_BLG.Click += buttonDone_BLG_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1508, 544);
            Controls.Add(buttonDone_BLG);
            Controls.Add(buttonHelp_BLG);
            Controls.Add(groupBoxOutput_BLG);
            Controls.Add(groupBoxInput_BLG);
            Controls.Add(groupBoxTask_BLG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 3 | Бубенко Л.Г.";
            Load += Form1_Load;
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BLG).EndInit();
            groupBoxInput_BLG.ResumeLayout(false);
            groupBoxInput_BLG.PerformLayout();
            groupBoxOutput_BLG.ResumeLayout(false);
            groupBoxOutput_BLG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BLG;
        private GroupBox groupBoxInput_BLG;
        private GroupBox groupBoxOutput_BLG;
        private Button buttonHelp_BLG;
        private Button buttonDone_BLG;
        private PictureBox pictureBoxFormula_BLG;
        private TextBox textBoxStartValue_BLG;
        private TextBox textBoxStopValue_BLG;
        private TextBox textBoxStart_BLG;
        private TextBox textBoxStop_BLG;
        private TextBox textBoxResult_BLG;
        private TextBox textBoxTask_BLG;
        private TextBox textBoxOutput_BLG;
    }
}
