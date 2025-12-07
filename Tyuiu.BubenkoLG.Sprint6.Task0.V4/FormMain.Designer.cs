namespace Tyuiu.BubenkoLG.Sprint6.Task0.V4
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
            pictureBoxFormula_BLG = new PictureBox();
            textBoxTask_BLG = new TextBox();
            groupBoxInput_BLG = new GroupBox();
            textBoxX = new TextBox();
            textBoxVarX_BLG = new TextBox();
            groupBoxOutput_BLG = new GroupBox();
            TextBoxResult = new TextBox();
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
            groupBoxTask_BLG.Controls.Add(pictureBoxFormula_BLG);
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Location = new Point(16, 20);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(767, 269);
            groupBoxTask_BLG.TabIndex = 0;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // pictureBoxFormula_BLG
            // 
            pictureBoxFormula_BLG.BackColor = SystemColors.ButtonFace;
            pictureBoxFormula_BLG.Image = (Image)resources.GetObject("pictureBoxFormula_BLG.Image");
            pictureBoxFormula_BLG.Location = new Point(24, 85);
            pictureBoxFormula_BLG.Name = "pictureBoxFormula_BLG";
            pictureBoxFormula_BLG.Size = new Size(667, 63);
            pictureBoxFormula_BLG.TabIndex = 1;
            pictureBoxFormula_BLG.TabStop = false;
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.BackColor = SystemColors.Menu;
            textBoxTask_BLG.BorderStyle = BorderStyle.None;
            textBoxTask_BLG.Location = new Point(24, 38);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.Size = new Size(718, 134);
            textBoxTask_BLG.TabIndex = 0;
            textBoxTask_BLG.Text = "Вычислить значение выражения по формуле";
            textBoxTask_BLG.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxInput_BLG
            // 
            groupBoxInput_BLG.Controls.Add(textBoxX);
            groupBoxInput_BLG.Controls.Add(textBoxVarX_BLG);
            groupBoxInput_BLG.Location = new Point(23, 295);
            groupBoxInput_BLG.Name = "groupBoxInput_BLG";
            groupBoxInput_BLG.Size = new Size(402, 150);
            groupBoxInput_BLG.TabIndex = 1;
            groupBoxInput_BLG.TabStop = false;
            groupBoxInput_BLG.Text = "Ввод данных";
            // 
            // textBoxX
            // 
            textBoxX.BackColor = SystemColors.Menu;
            textBoxX.BorderStyle = BorderStyle.None;
            textBoxX.Location = new Point(19, 54);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(261, 32);
            textBoxX.TabIndex = 1;
            textBoxX.Text = "Переменная X";
            // 
            // textBoxVarX_BLG
            // 
            textBoxVarX_BLG.Location = new Point(17, 95);
            textBoxVarX_BLG.Name = "textBoxVarX_BLG";
            textBoxVarX_BLG.Size = new Size(365, 39);
            textBoxVarX_BLG.TabIndex = 0;
            textBoxVarX_BLG.TextChanged += textBoxVarX_BLG_TextChanged;
            textBoxVarX_BLG.KeyPress += textBoxVarX_BLG_KeyPress;
            // 
            // groupBoxOutput_BLG
            // 
            groupBoxOutput_BLG.Controls.Add(TextBoxResult);
            groupBoxOutput_BLG.Controls.Add(textBoxResult_BLG);
            groupBoxOutput_BLG.Location = new Point(448, 295);
            groupBoxOutput_BLG.Name = "groupBoxOutput_BLG";
            groupBoxOutput_BLG.Size = new Size(335, 150);
            groupBoxOutput_BLG.TabIndex = 2;
            groupBoxOutput_BLG.TabStop = false;
            groupBoxOutput_BLG.Text = "Вывод данных";
            // 
            // TextBoxResult
            // 
            TextBoxResult.BackColor = SystemColors.Menu;
            TextBoxResult.BorderStyle = BorderStyle.None;
            TextBoxResult.Location = new Point(30, 54);
            TextBoxResult.Name = "TextBoxResult";
            TextBoxResult.Size = new Size(156, 32);
            TextBoxResult.TabIndex = 1;
            TextBoxResult.Text = "Результат";
            // 
            // textBoxResult_BLG
            // 
            textBoxResult_BLG.Location = new Point(25, 95);
            textBoxResult_BLG.Name = "textBoxResult_BLG";
            textBoxResult_BLG.ReadOnly = true;
            textBoxResult_BLG.Size = new Size(304, 39);
            textBoxResult_BLG.TabIndex = 0;
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.FlatStyle = FlatStyle.Flat;
            buttonHelp_BLG.Location = new Point(478, 465);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(68, 63);
            buttonHelp_BLG.TabIndex = 3;
            buttonHelp_BLG.Text = "?";
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += buttonHelp_BLG_Click;
            // 
            // buttonDone_BLG
            // 
            buttonDone_BLG.Location = new Point(561, 465);
            buttonDone_BLG.Name = "buttonDone_BLG";
            buttonDone_BLG.Size = new Size(221, 63);
            buttonDone_BLG.TabIndex = 4;
            buttonDone_BLG.Text = "Выполнить";
            buttonDone_BLG.UseVisualStyleBackColor = true;
            buttonDone_BLG.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(buttonDone_BLG);
            Controls.Add(buttonHelp_BLG);
            Controls.Add(groupBoxOutput_BLG);
            Controls.Add(groupBoxInput_BLG);
            Controls.Add(groupBoxTask_BLG);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Бубенко Л.Г.";
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
        private TextBox textBoxTask_BLG;
        private PictureBox pictureBoxFormula_BLG;
        private TextBox textBoxVarX_BLG;
        private TextBox textBoxResult_BLG;
        private TextBox textBoxX;
        private TextBox TextBoxResult;
    }
}
