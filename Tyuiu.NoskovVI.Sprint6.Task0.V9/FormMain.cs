using Tyuiu.NoskovVI.Sprint6.Task0.V9.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxForX_NVI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_NVI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxDone_NVI.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxForX_NVI.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ����-24-1 ������ ������� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
