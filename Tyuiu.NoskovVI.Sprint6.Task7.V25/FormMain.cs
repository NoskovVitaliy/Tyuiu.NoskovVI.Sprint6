using Tyuiu.NoskovVI.Sprint6.Task7.V25.Lib;
namespace Tyuiu.NoskovVI.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_NVI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogOutput_NVI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        private static int[,] MatrixChange(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 6] % 5 == 0 && matrix[i, 6] >= 5) matrix[i, 6] = 2;
            }
            return matrix;
        }
        private void buttonOutput_NVI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = MatrixChange(ds.GetMatrix(openFileDialogTask_NVI.FileName));
            for (int i = 0; i < arrayValues.GetLength(0); i++)
            {
                for (int j = 0; j < arrayValues.GetLength(1); j++)
                {
                    this.dataGridViewOut_NVI.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSaveFile_NVI.Enabled = true;
        }

        private void buttonFormAbout_NVI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFindFile_NVI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NVI.ShowDialog();
            string openFileName = openFileDialogTask_NVI.FileName;

            int[,] arrayValues = ds.GetMatrix(openFileName);

            dataGridViewIn_NVI.Rows.Clear();
            dataGridViewOut_NVI.Rows.Clear();

            this.dataGridViewIn_NVI.RowCount = arrayValues.GetLength(0);
            this.dataGridViewOut_NVI.RowCount = arrayValues.GetLength(0);
            this.dataGridViewIn_NVI.ColumnCount = arrayValues.GetLength(1);
            this.dataGridViewOut_NVI.ColumnCount = arrayValues.GetLength(1);

            for (int i = 0; i < arrayValues.GetLength(1); i++)
            {
                this.dataGridViewIn_NVI.Columns[i].Width = 40;
                this.dataGridViewOut_NVI.Columns[i].Width = 40;
            }

            for (int i = 0; i < arrayValues.GetLength(0); i++)
            {
                for (int j = 0; j < arrayValues.GetLength(1); j++)
                {
                    this.dataGridViewIn_NVI.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonOutput_NVI.Enabled = true;

        }

        private void buttonFormAbout_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_NVI.ToolTipTitle = "Справка";
        }

        private void buttonOutput_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_NVI.ToolTipTitle = "Выполнить";
        }

        private void buttonFindFile_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_NVI.ToolTipTitle = "Загрузить файл";
        }

        private void buttonSaveFile_NVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_NVI.ToolTipTitle = "Сохранить файл";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.dataGridViewIn_NVI.RowCount = 40;
            this.dataGridViewOut_NVI.RowCount = 40;
            this.dataGridViewIn_NVI.ColumnCount = 40;
            this.dataGridViewOut_NVI.ColumnCount = 40;
            for (int i = 0; i < 40; i++)
            {
                this.dataGridViewIn_NVI.Columns[i].Width = 40;
                this.dataGridViewOut_NVI.Columns[i].Width = 40;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonSaveFile_NVI_Click(object sender, EventArgs e)
        {
            saveFileDialogOutput_NVI.FileName = "OutPutFileTask7V25.csv";
            saveFileDialogOutput_NVI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogOutput_NVI.ShowDialog();

            string path = saveFileDialogOutput_NVI.FileName;

            if (File.Exists(path)) {File.Delete(path);}
            int rows = dataGridViewOut_NVI.RowCount;
            int columns = dataGridViewOut_NVI.ColumnCount;

            string str = "";
            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j < columns;j++)
                {
                    if (j == columns -1)
                    {
                        str += dataGridViewOut_NVI.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        str += dataGridViewOut_NVI.Rows[i].Cells[j].Value + ";";
                    }
                    
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
