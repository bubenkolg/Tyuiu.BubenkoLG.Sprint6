namespace Tyuiu.BubenkoLG.Sprint6.Task6.V18
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
            buttonInput_BLG = new Button();
            buttonOutput_BLG = new Button();
            buttonHelp_BLG = new Button();
            groupBoxTask_BLG = new GroupBox();
            textBoxTask_BLG = new TextBox();
            textBoxInputDate_BLG = new TextBox();
            textBoxResult_BLG = new TextBox();
            textBoxOutput_BLG = new TextBox();
            openFileDialogTask_BLG = new OpenFileDialog();
            groupBoxInput_BLG = new GroupBox();
            groupBoxTask_BLG.SuspendLayout();
            groupBoxInput_BLG.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInput_BLG
            // 
            buttonInput_BLG.Location = new Point(12, 12);
            buttonInput_BLG.Name = "buttonInput_BLG";
            buttonInput_BLG.Size = new Size(246, 89);
            buttonInput_BLG.TabIndex = 0;
            buttonInput_BLG.Text = "Получить данные";
            buttonInput_BLG.UseVisualStyleBackColor = true;
            buttonInput_BLG.Click += buttonInput_BLG_Click;
            // 
            // buttonOutput_BLG
            // 
            buttonOutput_BLG.Location = new Point(274, 12);
            buttonOutput_BLG.Name = "buttonOutput_BLG";
            buttonOutput_BLG.Size = new Size(246, 89);
            buttonOutput_BLG.TabIndex = 1;
            buttonOutput_BLG.Text = "Вывести данные";
            buttonOutput_BLG.UseVisualStyleBackColor = true;
            buttonOutput_BLG.Click += buttonOutput_BLG_Click;
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(537, 12);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(89, 89);
            buttonHelp_BLG.TabIndex = 2;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Location = new Point(12, 107);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(1049, 164);
            groupBoxTask_BLG.TabIndex = 3;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(6, 38);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.ReadOnly = true;
            textBoxTask_BLG.Size = new Size(1037, 111);
            textBoxTask_BLG.TabIndex = 4;
            textBoxTask_BLG.Text = resources.GetString("textBoxTask_BLG.Text");
            // 
            // textBoxInputDate_BLG
            // 
            textBoxInputDate_BLG.BackColor = SystemColors.ControlLightLight;
            textBoxInputDate_BLG.Location = new Point(6, 41);
            textBoxInputDate_BLG.Multiline = true;
            textBoxInputDate_BLG.Name = "textBoxInputDate_BLG";
            textBoxInputDate_BLG.ReadOnly = true;
            textBoxInputDate_BLG.ScrollBars = ScrollBars.Vertical;
            textBoxInputDate_BLG.Size = new Size(500, 552);
            textBoxInputDate_BLG.TabIndex = 5;
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.BackColor = SystemColors.ControlLightLight;
            textBoxResult_BLG.Location = new Point(537, 323);
            textBoxResult_BLG.Multiline = true;
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.ReadOnly = true;
            textBoxResult_BLG.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BLG.Size = new Size(518, 552);
            textBoxResult_BLG.TabIndex = 7;
            // 
            // textBoxOutput_BLG
            // 
            textBoxOutput_BLG.BackColor = SystemColors.Menu;
            textBoxOutput_BLG.BorderStyle = BorderStyle.None;
            textBoxOutput_BLG.Location = new Point(535, 277);
            textBoxOutput_BLG.Name = "textBoxOutput_BLG";
            textBoxOutput_BLG.ReadOnly = true;
            textBoxOutput_BLG.Size = new Size(152, 32);
            textBoxOutput_BLG.TabIndex = 6;
            textBoxOutput_BLG.Text = "Вывод";
            // 
            // openFileDialogTask_BLG
            // 
            openFileDialogTask_BLG.FileName = "InPutDataFileTask6V18.txt";
            // 
            // groupBoxInput_BLG
            // 
            groupBoxInput_BLG.Controls.Add(textBoxInputDate_BLG);
            groupBoxInput_BLG.Location = new Point(14, 282);
            groupBoxInput_BLG.Name = "groupBoxInput_BLG";
            groupBoxInput_BLG.Size = new Size(513, 595);
            groupBoxInput_BLG.TabIndex = 8;
            groupBoxInput_BLG.TabStop = false;
            groupBoxInput_BLG.Text = "Ввод";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 900);
            Controls.Add(groupBoxInput_BLG);
            Controls.Add(textBoxResult_BLG);
            Controls.Add(textBoxOutput_BLG);
            Controls.Add(groupBoxTask_BLG);
            Controls.Add(buttonHelp_BLG);
            Controls.Add(buttonOutput_BLG);
            Controls.Add(buttonInput_BLG);
            Name = "FormMain";
            Text = "Спринт 6 Таск 6 Вариант 18 Бубенко Л.Г.";
            Load += Form1_Load;
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            groupBoxInput_BLG.ResumeLayout(false);
            groupBoxInput_BLG.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInput_BLG;
        private Button buttonOutput_BLG;
        private Button buttonHelp_BLG;
        private GroupBox groupBoxTask_BLG;
        private TextBox textBoxTask_BLG;
        private TextBox textBoxInputDate_BLG;
        private TextBox textBoxResult_BLG;
        private TextBox textBoxOutput_BLG;
        private OpenFileDialog openFileDialogTask_BLG;
        private GroupBox groupBoxInput_BLG;
    }
}
