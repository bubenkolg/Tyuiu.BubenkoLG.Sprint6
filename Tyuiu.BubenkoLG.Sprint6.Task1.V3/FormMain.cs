using Tyuiu.BubenkoLG.Sprint6.Task1.V3.Lib;
namespace Tyuiu.BubenkoLG.Sprint6.Task1.V3
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

        DataService ds = new DataService();
        private void buttonDone_BLG_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_BLG.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_BLG.Text);

                string strLine;
                int x = 0;

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);


                textBoxOutput_BLG.Text = "";
                textBoxOutput_BLG.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutput_BLG.AppendText("|     X    |   F(x)   |" + Environment.NewLine);
                textBoxOutput_BLG.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1, 5:f2}  |", startValue, valueArray[i]);
                    textBoxOutput_BLG.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxOutput_BLG.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxStartValue_BLG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void textBoxStopValue_BLG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_BLG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-25-1 Бубенко Людмила Георгиевна", "Сообщение");
        }
    }
}
