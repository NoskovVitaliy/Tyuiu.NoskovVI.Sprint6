using Tyuiu.NoskovVI.Sprint6.Task6.V6.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonOutput_NVI_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V6.txt";
            textBoxOut_NVI.Text = ds.CollectTextFromFile(path);
        }

        private void buttonFormAbout_NVI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFindFile_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_NVI.ShowDialog();
                string openFilePath = openFileDialogTask_NVI.FileName;
                foreach (string line in File.ReadLines(openFilePath))
                {
                    textBoxIn_NVI.AppendText(line + Environment.NewLine);
                }
                groupBoxInfoEnter_NVI.Text += " " + openFilePath;
                buttonOutput_NVI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Не удалось получить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
