using Tyuiu.BubenkoLG.Sprint6.Task4.V29.Lib;
using System;
using System.Linq.Expressions;
namespace Tyuiu.BubenkoLG.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonDone_BLG_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_BLG.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_BLG.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartGraphic_BLG.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraphic_BLG.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_BLG.Text = ""; 
                chartGraphic_BLG.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartGraphic_BLG.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult_BLG.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_BLG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-25-1 Бубенко Людмила Георгиевна", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private void buttonSave_BLG_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\Tyuiu.BubenkoLG.Sprint6.Task4.V29\bin\Debug\net8.0-windows\OutPutFileTask4V29.txt";
                //string path = $@"{Path.GetTempPath()}\OutPutFileTask4V29.txt";
                File.WriteAllText(path, textBoxResult_BLG.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
