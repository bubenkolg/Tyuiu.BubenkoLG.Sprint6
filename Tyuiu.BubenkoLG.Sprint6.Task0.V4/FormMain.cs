using System;
using System.Windows.Forms;
using Tyuiu.BubenkoLG.Sprint6.Task0.V4.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task0.V4
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
        private void buttonDone_BLG_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BLG.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_BLG.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_BLG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_BLG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-25-1 Бубенко Людмила Георгиевна", "Сообщение");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BLG.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_BLG.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxVarX_BLG_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
