using Tyuiu.NoskovVI.Sprint6.Task4.V19.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_NVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-24-1 Носков Виталий Игоревич", "Сообщение");
        }

        private void buttonSave_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V19.txt" });
                File.WriteAllText(path, textBoxResult_NVI.Text);

                DialogResult dialogResult = MessageBox.Show("Файл OutPutFileTask4V19.txt сохранён успешно!\nОткрыть его в блокноте?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("Произошел сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVarStart_NVI.Text);
                int end = Convert.ToInt32((textBoxVarEnd_NVI.Text));


                double[] valueArray = ds.GetMassFunction(start, end);

                this.chartFunction_NVI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_NVI.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_NVI.Text = string.Empty;

                this.chartFunction_NVI.Series[0].Points.Clear();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.chartFunction_NVI.Series[0].Points.AddXY(start, valueArray[i]);
                    this.textBoxResult_NVI.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
