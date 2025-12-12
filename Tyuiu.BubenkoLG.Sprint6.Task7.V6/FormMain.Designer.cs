namespace Tyuiu.BubenkoLG.Sprint6.Task7.V6
{
    partial class FormMain_BLG
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BLG));
            panelButton_BLG = new Panel();
            buttonSaveFile_BLG = new Button();
            buttonComplete_BLG = new Button();
            buttonOpenFile_BLG = new Button();
            splitterButtonTask_BLG = new Splitter();
            buttonHelp_BLG = new Button();
            panelTask_BLG = new Panel();
            groupBoxTask_BLG = new GroupBox();
            textBoxTask_BLG = new TextBox();
            splitterIOputTask_BLG = new Splitter();
            panelInput_BLG = new Panel();
            groupBoxInput_BLG = new GroupBox();
            dataGridViewInputData_BLG = new DataGridView();
            panelOutput_BLG = new Panel();
            splitterInputOutput_BLG = new Splitter();
            groupBoxOutput_BLG = new GroupBox();
            dataGridViewOutputData_BLG = new DataGridView();
            toolTipButtonOpenFile_BLG = new ToolTip(components);
            toolTipButtonComplete_BLG = new ToolTip(components);
            toolTipButtonSaveFile_BLG = new ToolTip(components);
            toolTipButtonHelp_BLG = new ToolTip(components);
            openFileDialogTask_BLG = new OpenFileDialog();
            saveFileDialogMatrix_BLG = new SaveFileDialog();
            panelButton_BLG.SuspendLayout();
            panelTask_BLG.SuspendLayout();
            groupBoxTask_BLG.SuspendLayout();
            panelInput_BLG.SuspendLayout();
            groupBoxInput_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputData_BLG).BeginInit();
            panelOutput_BLG.SuspendLayout();
            groupBoxOutput_BLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData_BLG).BeginInit();
            SuspendLayout();
            // 
            // panelButton_BLG
            // 
            panelButton_BLG.Controls.Add(buttonSaveFile_BLG);
            panelButton_BLG.Controls.Add(buttonComplete_BLG);
            panelButton_BLG.Controls.Add(buttonOpenFile_BLG);
            panelButton_BLG.Controls.Add(splitterButtonTask_BLG);
            panelButton_BLG.Controls.Add(buttonHelp_BLG);
            panelButton_BLG.Dock = DockStyle.Top;
            panelButton_BLG.Location = new Point(0, 0);
            panelButton_BLG.Name = "panelButton_BLG";
            panelButton_BLG.Size = new Size(1358, 161);
            panelButton_BLG.TabIndex = 1;
            // 
            // buttonSaveFile_BLG
            // 
            buttonSaveFile_BLG.Image = (Image)resources.GetObject("buttonSaveFile_BLG.Image");
            buttonSaveFile_BLG.Location = new Point(400, 12);
            buttonSaveFile_BLG.Name = "buttonSaveFile_BLG";
            buttonSaveFile_BLG.RightToLeft = RightToLeft.No;
            buttonSaveFile_BLG.Size = new Size(177, 132);
            buttonSaveFile_BLG.TabIndex = 4;
            toolTipButtonSaveFile_BLG.SetToolTip(buttonSaveFile_BLG, "Сохранить обработанные данные в новый файл");
            buttonSaveFile_BLG.UseVisualStyleBackColor = true;
            buttonSaveFile_BLG.Click += buttomSaveFile_BLG_Click;
            buttonSaveFile_BLG.MouseEnter += buttonSaveFile_BLG_MouseEnter;
            // 
            // buttonComplete_BLG
            // 
            buttonComplete_BLG.Image = (Image)resources.GetObject("buttonComplete_BLG.Image");
            buttonComplete_BLG.Location = new Point(206, 12);
            buttonComplete_BLG.Name = "buttonComplete_BLG";
            buttonComplete_BLG.RightToLeft = RightToLeft.No;
            buttonComplete_BLG.Size = new Size(177, 132);
            buttonComplete_BLG.TabIndex = 3;
            toolTipButtonComplete_BLG.SetToolTip(buttonComplete_BLG, "Кнопка активирующая обработку файла");
            buttonComplete_BLG.UseVisualStyleBackColor = true;
            buttonComplete_BLG.Click += buttonComplete_BLG_Click;
            buttonComplete_BLG.MouseEnter += buttonComplete_BLG_MouseEnter;
            // 
            // buttonOpenFile_BLG
            // 
            buttonOpenFile_BLG.Image = (Image)resources.GetObject("buttonOpenFile_BLG.Image");
            buttonOpenFile_BLG.Location = new Point(12, 12);
            buttonOpenFile_BLG.Name = "buttonOpenFile_BLG";
            buttonOpenFile_BLG.RightToLeft = RightToLeft.No;
            buttonOpenFile_BLG.Size = new Size(177, 132);
            buttonOpenFile_BLG.TabIndex = 2;
            toolTipButtonOpenFile_BLG.SetToolTip(buttonOpenFile_BLG, "Выберите файл для обработки");
            buttonOpenFile_BLG.UseVisualStyleBackColor = true;
            buttonOpenFile_BLG.Click += buttonOpenFile_BLG_Click;
            buttonOpenFile_BLG.MouseEnter += buttonOpenFile_BLG_MouseEnter;
            // 
            // splitterButtonTask_BLG
            // 
            splitterButtonTask_BLG.Dock = DockStyle.Bottom;
            splitterButtonTask_BLG.Location = new Point(0, 155);
            splitterButtonTask_BLG.Name = "splitterButtonTask_BLG";
            splitterButtonTask_BLG.Size = new Size(1358, 6);
            splitterButtonTask_BLG.TabIndex = 1;
            splitterButtonTask_BLG.TabStop = false;
            // 
            // buttonHelp_BLG
            // 
            buttonHelp_BLG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BLG.Image = (Image)resources.GetObject("buttonHelp_BLG.Image");
            buttonHelp_BLG.Location = new Point(1164, 12);
            buttonHelp_BLG.Name = "buttonHelp_BLG";
            buttonHelp_BLG.Size = new Size(177, 132);
            buttonHelp_BLG.TabIndex = 0;
            toolTipButtonHelp_BLG.SetToolTip(buttonHelp_BLG, "Информация о разработчике и т.д.");
            buttonHelp_BLG.UseVisualStyleBackColor = true;
            buttonHelp_BLG.Click += ButtonHelp_Click;
            buttonHelp_BLG.MouseEnter += buttonHelp_BLG_MouseEnter;
            // 
            // panelTask_BLG
            // 
            panelTask_BLG.Controls.Add(groupBoxTask_BLG);
            panelTask_BLG.Controls.Add(splitterIOputTask_BLG);
            panelTask_BLG.Dock = DockStyle.Top;
            panelTask_BLG.Location = new Point(0, 161);
            panelTask_BLG.Name = "panelTask_BLG";
            panelTask_BLG.Padding = new Padding(10, 10, 10, 0);
            panelTask_BLG.Size = new Size(1358, 187);
            panelTask_BLG.TabIndex = 2;
            // 
            // groupBoxTask_BLG
            // 
            groupBoxTask_BLG.Controls.Add(textBoxTask_BLG);
            groupBoxTask_BLG.Dock = DockStyle.Fill;
            groupBoxTask_BLG.Location = new Point(10, 10);
            groupBoxTask_BLG.Name = "groupBoxTask_BLG";
            groupBoxTask_BLG.Size = new Size(1338, 171);
            groupBoxTask_BLG.TabIndex = 1;
            groupBoxTask_BLG.TabStop = false;
            groupBoxTask_BLG.Text = "Условие";
            // 
            // textBoxTask_BLG
            // 
            textBoxTask_BLG.Dock = DockStyle.Fill;
            textBoxTask_BLG.Location = new Point(3, 35);
            textBoxTask_BLG.Multiline = true;
            textBoxTask_BLG.Name = "textBoxTask_BLG";
            textBoxTask_BLG.ReadOnly = true;
            textBoxTask_BLG.Size = new Size(1332, 133);
            textBoxTask_BLG.TabIndex = 0;
            textBoxTask_BLG.Text = resources.GetString("textBoxTask_BLG.Text");
            // 
            // splitterIOputTask_BLG
            // 
            splitterIOputTask_BLG.Dock = DockStyle.Bottom;
            splitterIOputTask_BLG.Location = new Point(10, 181);
            splitterIOputTask_BLG.Name = "splitterIOputTask_BLG";
            splitterIOputTask_BLG.Size = new Size(1338, 6);
            splitterIOputTask_BLG.TabIndex = 0;
            splitterIOputTask_BLG.TabStop = false;
            // 
            // panelInput_BLG
            // 
            panelInput_BLG.Controls.Add(groupBoxInput_BLG);
            panelInput_BLG.Dock = DockStyle.Left;
            panelInput_BLG.Location = new Point(0, 348);
            panelInput_BLG.Name = "panelInput_BLG";
            panelInput_BLG.Padding = new Padding(10);
            panelInput_BLG.Size = new Size(577, 634);
            panelInput_BLG.TabIndex = 3;
            // 
            // groupBoxInput_BLG
            // 
            groupBoxInput_BLG.Controls.Add(dataGridViewInputData_BLG);
            groupBoxInput_BLG.Dock = DockStyle.Fill;
            groupBoxInput_BLG.Location = new Point(10, 10);
            groupBoxInput_BLG.Name = "groupBoxInput_BLG";
            groupBoxInput_BLG.Padding = new Padding(10);
            groupBoxInput_BLG.Size = new Size(557, 614);
            groupBoxInput_BLG.TabIndex = 0;
            groupBoxInput_BLG.TabStop = false;
            groupBoxInput_BLG.Text = "Ввод";
            // 
            // dataGridViewInputData_BLG
            // 
            dataGridViewInputData_BLG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInputData_BLG.Dock = DockStyle.Fill;
            dataGridViewInputData_BLG.Location = new Point(10, 42);
            dataGridViewInputData_BLG.Margin = new Padding(10);
            dataGridViewInputData_BLG.Name = "dataGridViewInputData_BLG";
            dataGridViewInputData_BLG.ReadOnly = true;
            dataGridViewInputData_BLG.RowHeadersVisible = false;
            dataGridViewInputData_BLG.RowHeadersWidth = 82;
            dataGridViewInputData_BLG.ScrollBars = ScrollBars.Vertical;
            dataGridViewInputData_BLG.Size = new Size(537, 562);
            dataGridViewInputData_BLG.TabIndex = 0;
            // 
            // panelOutput_BLG
            // 
            panelOutput_BLG.Controls.Add(splitterInputOutput_BLG);
            panelOutput_BLG.Controls.Add(groupBoxOutput_BLG);
            panelOutput_BLG.Dock = DockStyle.Fill;
            panelOutput_BLG.Location = new Point(577, 348);
            panelOutput_BLG.Name = "panelOutput_BLG";
            panelOutput_BLG.Padding = new Padding(0, 10, 10, 10);
            panelOutput_BLG.Size = new Size(781, 634);
            panelOutput_BLG.TabIndex = 4;
            // 
            // splitterInputOutput_BLG
            // 
            splitterInputOutput_BLG.Location = new Point(0, 10);
            splitterInputOutput_BLG.Margin = new Padding(10);
            splitterInputOutput_BLG.Name = "splitterInputOutput_BLG";
            splitterInputOutput_BLG.Size = new Size(6, 614);
            splitterInputOutput_BLG.TabIndex = 2;
            splitterInputOutput_BLG.TabStop = false;
            // 
            // groupBoxOutput_BLG
            // 
            groupBoxOutput_BLG.Controls.Add(dataGridViewOutputData_BLG);
            groupBoxOutput_BLG.Dock = DockStyle.Fill;
            groupBoxOutput_BLG.Location = new Point(0, 10);
            groupBoxOutput_BLG.Margin = new Padding(10);
            groupBoxOutput_BLG.Name = "groupBoxOutput_BLG";
            groupBoxOutput_BLG.Padding = new Padding(10);
            groupBoxOutput_BLG.Size = new Size(771, 614);
            groupBoxOutput_BLG.TabIndex = 1;
            groupBoxOutput_BLG.TabStop = false;
            groupBoxOutput_BLG.Text = "Вывод";
            // 
            // dataGridViewOutputData_BLG
            // 
            dataGridViewOutputData_BLG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutputData_BLG.Dock = DockStyle.Fill;
            dataGridViewOutputData_BLG.Location = new Point(10, 42);
            dataGridViewOutputData_BLG.Name = "dataGridViewOutputData_BLG";
            dataGridViewOutputData_BLG.ReadOnly = true;
            dataGridViewOutputData_BLG.RowHeadersVisible = false;
            dataGridViewOutputData_BLG.RowHeadersWidth = 82;
            dataGridViewOutputData_BLG.ScrollBars = ScrollBars.Vertical;
            dataGridViewOutputData_BLG.Size = new Size(751, 562);
            dataGridViewOutputData_BLG.TabIndex = 0;
            // 
            // toolTipButtonOpenFile_BLG
            // 
            toolTipButtonOpenFile_BLG.IsBalloon = true;
            // 
            // toolTipButtonComplete_BLG
            // 
            toolTipButtonComplete_BLG.IsBalloon = true;
            // 
            // toolTipButtonSaveFile_BLG
            // 
            toolTipButtonSaveFile_BLG.IsBalloon = true;
            // 
            // toolTipButtonHelp_BLG
            // 
            toolTipButtonHelp_BLG.IsBalloon = true;
            // 
            // openFileDialogTask_BLG
            // 
            openFileDialogTask_BLG.FileName = "InPutDataFileTask7V6.csv";
            // 
            // saveFileDialogMatrix_BLG
            // 
            saveFileDialogMatrix_BLG.FileName = "OutPutFileTask7V6.csv";
            // 
            // FormMain_BLG
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 982);
            Controls.Add(panelOutput_BLG);
            Controls.Add(panelInput_BLG);
            Controls.Add(panelTask_BLG);
            Controls.Add(panelButton_BLG);
            MinimumSize = new Size(1000, 800);
            Name = "FormMain_BLG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 6 | Бубенко Л.Г.";
            panelButton_BLG.ResumeLayout(false);
            panelTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.ResumeLayout(false);
            groupBoxTask_BLG.PerformLayout();
            panelInput_BLG.ResumeLayout(false);
            groupBoxInput_BLG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputData_BLG).EndInit();
            panelOutput_BLG.ResumeLayout(false);
            groupBoxOutput_BLG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData_BLG).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelButton_BLG;
        private Button buttonHelp_BLG;
        private Splitter splitterButtonTask_BLG;
        private Button buttonOpenFile_BLG;
        private Button buttonSaveFile_BLG;
        private Button buttonComplete_BLG;
        private Panel panelTask_BLG;
        private Panel panelInput_BLG;
        private Panel panelOutput_BLG;
        private Splitter splitterIOputTask_BLG;
        private GroupBox groupBoxInput_BLG;
        private GroupBox groupBoxOutput_BLG;
        private GroupBox groupBoxTask_BLG;
        private Splitter splitterInputOutput_BLG;
        private DataGridView dataGridViewInputData_BLG;
        private DataGridView dataGridViewOutputData_BLG;
        private TextBox textBoxTask_BLG;
        private ToolTip toolTipButtonOpenFile_BLG;
        private ToolTip toolTipButtonComplete_BLG;
        private ToolTip toolTipButtonSaveFile_BLG;
        private ToolTip toolTipButtonHelp_BLG;
        private OpenFileDialog openFileDialogTask_BLG;
        private SaveFileDialog saveFileDialogMatrix_BLG;
    }
}
