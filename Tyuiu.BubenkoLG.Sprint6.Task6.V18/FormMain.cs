using Tyuiu.BubenkoLG.Sprint6.Task6.V18.Lib;
namespace Tyuiu.BubenkoLG.Sprint6.Task6.V18
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
        string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\InPutDataFileTask6V18.txt";
        private void buttonOutput_BLG_Click(object sender, EventArgs e)
        {
            textBoxResult_BLG.Text = ds.CollectTextFromFile(path);
        }
        private void buttonHelp_BLG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-25-1 Бубенко Людмила Георгиевна", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private void buttonInput_BLG_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BLG.ShowDialog();
            path = openFileDialogTask_BLG.FileName;
            textBoxInputDate_BLG.Text = File.ReadAllText(path);
            groupBoxInput_BLG.Text = groupBoxInput_BLG.Text + " " + openFileDialogTask_BLG.FileName;
            buttonOutput_BLG.Enabled = true;
        }
    }
}
