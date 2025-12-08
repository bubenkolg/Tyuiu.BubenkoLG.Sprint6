using Tyuiu.BubenkoLG.Sprint6.Task2.V8.Lib;
namespace Tyuiu.BubenkoLG.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataService ds = new DataService();
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

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView_BLG.Rows.Add(Convert.ToString(startValue),Convert.ToString(valueArray[i]));
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
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-25-1 Бубенко Людмила Георгиевна", "Сообщение");
        }
    }
}
