using Tyuiu.NoskovVI.Sprint6.Task2.V27.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_NVI.Text);
                int end = Convert.ToInt32(textBoxEnd_NVI.Text);

                double[] valueArray = ds.GetMassFunction(start, end);
                this.dataGridViewFunction_NVI.Rows.Clear();
                this.chartFunction_NVI.Series[0].Points.Clear();
                this.chartFunction_NVI.Titles.Clear();
                this.chartFunction_NVI.Titles.Add("График предлагаемой функции");

                this.chartFunction_NVI.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_NVI.ChartAreas[0].AxisY.Title = "Ось У";
                

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.dataGridViewFunction_NVI.Rows.Add(start.ToString(), Convert.ToString(valueArray[i]));

                    this.chartFunction_NVI.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_NVI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_NVI.BackColor = Color.Red;
        }

        private void buttonDone_NVI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_NVI.BackColor = Color.Green;
        }

        private void buttonDone_NVI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_NVI.BackColor = Color.DarkBlue;
        }

        private void buttonDone_NVI_MouseUp(object sender, MouseEventArgs e)
        {
            buttonDone_NVI.BackColor = Color.Red;
        }

        private void buttonHelp_NVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-24-1 Носков Виталий Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
