using System.Windows.Forms;
using Tyuiu.BubenkoLG.Sprint6.Task7.V6.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task7.V6
{
    public partial class FormMain_BLG : Form
    {
        public FormMain_BLG()
        {
            InitializeComponent();
            openFileDialogTask_BLG.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BLG.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormAbout_BLG formAbout_BLG = new FormAbout_BLG();
            formAbout_BLG.ShowDialog();
        }

        private void buttomSaveFile_BLG_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BLG.FileName = "OutPutFileTask7V6.csv";
            saveFileDialogMatrix_BLG.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BLG.ShowDialog();
            string path = saveFileDialogMatrix_BLG.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutputData_BLG.RowCount;
            int columns = dataGridViewOutputData_BLG.ColumnCount;
            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (c != columns - 1)
                    {
                        str = str + dataGridViewOutputData_BLG.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutputData_BLG.Rows[r].Cells[c].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
        private void buttonComplete_BLG_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutputData_BLG.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_BLG.Enabled = true;
        }

        private void buttonOpenFile_BLG_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BLG.ShowDialog();
            openFilePath = openFileDialogTask_BLG.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInputData_BLG.ColumnCount = colums;
            dataGridViewInputData_BLG.RowCount = rows;
            dataGridViewOutputData_BLG.ColumnCount = colums;
            dataGridViewOutputData_BLG.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInputData_BLG.Columns[i].Width = 55;
                dataGridViewOutputData_BLG.Columns[i].Width = 55;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewInputData_BLG.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonComplete_BLG.Enabled = true;
        }
        private void buttonOpenFile_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonOpenFile_BLG.ToolTipTitle = "Открыть файл";
        }
        private void buttonSaveFile_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonSaveFile_BLG.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonComplete_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonComplete_BLG.ToolTipTitle = "Выполнить";
        }

        private void buttonHelp_BLG_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtonHelp_BLG.ToolTipTitle = "Справка";
        }
    }
}
