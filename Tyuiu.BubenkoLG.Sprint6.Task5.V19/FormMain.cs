using Tyuiu.BubenkoLG.Sprint6.Task5.V19.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\Tyuiu.BubenkoLG.Sprint6.Task5.V19\bin\Debug\net8.0-windows\InPutDataFileTask5V19.txt";
        private void buttonDone_BLG_Click(object sender, EventArgs e)
        {
            int len = ds.LoadFromDataFile(path).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.LoadFromDataFile(path);

            this.chartFunction_BLG.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BLG.ChartAreas[0].AxisY.Title = "Ось Y";

            textBoxResult_BLG.Text = "";
            chartFunction_BLG.Series[0].Points.Clear();

            for (int i = 0; i < len; i++)
            {
                this.chartFunction_BLG.Series[0].Points.AddXY(i, valueArray[i]);
                textBoxResult_BLG.AppendText(valueArray[i] + Environment.NewLine);
            }
        }
        private void buttonOpenFile_BLG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_BLG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-25-1 Бубенко Людмила Георгиевна", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
