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
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 ������ ������� ��������", "���������");
        }

        private void buttonSave_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V19.txt" });
                File.WriteAllText(path, textBoxResult_NVI.Text);

                DialogResult dialogResult = MessageBox.Show("���� OutPutFileTask4V19.txt ������� �������!\n������� ��� � ��������?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("��������� ���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVarStart_NVI.Text);
                int end = Convert.ToInt32((textBoxVarEnd_NVI.Text));


                double[] valueArray = ds.GetMassFunction(start, end);

                this.chartFunction_NVI.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_NVI.ChartAreas[0].AxisY.Title = "��� Y";

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
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
