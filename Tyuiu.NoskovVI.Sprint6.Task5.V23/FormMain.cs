using Tyuiu.NoskovVI.Sprint6.Task5.V23.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V23.txt";

        private void buttonHelp_NVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Носков Виталий Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonFileOpen_NVI_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start(); 
        }

        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            this.dataGridNums_NVI.ColumnCount = 2;
            this.dataGridNums_NVI.Columns[0].Width = 30;
            this.dataGridNums_NVI.Columns[1].Width = 70;

            this.chartFunction_NVI.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_NVI.ChartAreas[0].AxisY.Title = "Ось Y";

            this.chartFunction_NVI.Series[0].Points.Clear();
            this.dataGridNums_NVI.Refresh();

            double[] nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; i++)
            {
                this.dataGridNums_NVI.Rows.Add(i.ToString(),  nums[i]);
                this.chartFunction_NVI.Series[0].Points.AddXY(i, nums[i]);
            }

        }
    }
}
