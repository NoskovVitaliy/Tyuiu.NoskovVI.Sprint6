using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.NoskovVI.Sprint6.Task2.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxData_NVI = new GroupBox();
            textBoxEnd_NVI = new TextBox();
            textBoxStart_NVI = new TextBox();
            labelForEnd_NVI = new Label();
            labelForStart_NVI = new Label();
            buttonHelp_NVI = new Button();
            groupBoxTask_NVi = new GroupBox();
            textBox1 = new TextBox();
            groupBoxResult_NVI = new GroupBox();
            dataGridViewFunction_NVI = new DataGridView();
            labelResult_NVI = new Label();
            buttonDone_NVI = new Button();
            chartFunction_NVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            formMainBindingSource = new BindingSource(components);
            ColumnForX_NVI = new DataGridViewTextBoxColumn();
            ColumnForFunction_NVI = new DataGridViewTextBoxColumn();
            groupBoxData_NVI.SuspendLayout();
            groupBoxTask_NVi.SuspendLayout();
            groupBoxResult_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_NVI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formMainBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBoxData_NVI
            // 
            groupBoxData_NVI.Controls.Add(textBoxEnd_NVI);
            groupBoxData_NVI.Controls.Add(textBoxStart_NVI);
            groupBoxData_NVI.Controls.Add(labelForEnd_NVI);
            groupBoxData_NVI.Controls.Add(labelForStart_NVI);
            groupBoxData_NVI.Font = new Font("Segoe UI", 9F);
            groupBoxData_NVI.Location = new Point(12, 348);
            groupBoxData_NVI.Name = "groupBoxData_NVI";
            groupBoxData_NVI.Size = new Size(336, 98);
            groupBoxData_NVI.TabIndex = 0;
            groupBoxData_NVI.TabStop = false;
            groupBoxData_NVI.Text = "Ввод данных";
            // 
            // textBoxEnd_NVI
            // 
            textBoxEnd_NVI.Location = new Point(162, 63);
            textBoxEnd_NVI.Name = "textBoxEnd_NVI";
            textBoxEnd_NVI.Size = new Size(125, 27);
            textBoxEnd_NVI.TabIndex = 3;
            textBoxEnd_NVI.Text = "5";
            // 
            // textBoxStart_NVI
            // 
            textBoxStart_NVI.Location = new Point(21, 63);
            textBoxStart_NVI.Name = "textBoxStart_NVI";
            textBoxStart_NVI.Size = new Size(125, 27);
            textBoxStart_NVI.TabIndex = 2;
            textBoxStart_NVI.Text = "-5";
            // 
            // labelForEnd_NVI
            // 
            labelForEnd_NVI.AutoSize = true;
            labelForEnd_NVI.Font = new Font("Segoe UI", 9F);
            labelForEnd_NVI.Location = new Point(162, 36);
            labelForEnd_NVI.Name = "labelForEnd_NVI";
            labelForEnd_NVI.Size = new Size(91, 20);
            labelForEnd_NVI.TabIndex = 1;
            labelForEnd_NVI.Text = "Конец шага";
            // 
            // labelForStart_NVI
            // 
            labelForStart_NVI.AutoSize = true;
            labelForStart_NVI.Font = new Font("Segoe UI", 9F);
            labelForStart_NVI.Location = new Point(21, 36);
            labelForStart_NVI.Name = "labelForStart_NVI";
            labelForStart_NVI.Size = new Size(85, 20);
            labelForStart_NVI.TabIndex = 0;
            labelForStart_NVI.Text = "Старт шага";
            // 
            // buttonHelp_NVI
            // 
            buttonHelp_NVI.BackColor = SystemColors.Highlight;
            buttonHelp_NVI.FlatAppearance.BorderColor = Color.Red;
            buttonHelp_NVI.FlatAppearance.BorderSize = 2;
            buttonHelp_NVI.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVI.Font = new Font("Segoe UI", 9F);
            buttonHelp_NVI.Location = new Point(354, 358);
            buttonHelp_NVI.Name = "buttonHelp_NVI";
            buttonHelp_NVI.Size = new Size(96, 88);
            buttonHelp_NVI.TabIndex = 1;
            buttonHelp_NVI.Text = "Справка";
            buttonHelp_NVI.UseVisualStyleBackColor = false;
            buttonHelp_NVI.Click += buttonHelp_NVI_Click;
            // 
            // groupBoxTask_NVi
            // 
            groupBoxTask_NVi.Controls.Add(textBox1);
            groupBoxTask_NVi.Font = new Font("Segoe UI", 9F);
            groupBoxTask_NVi.Location = new Point(12, 12);
            groupBoxTask_NVi.Name = "groupBoxTask_NVi";
            groupBoxTask_NVi.Size = new Size(567, 340);
            groupBoxTask_NVi.TabIndex = 2;
            groupBoxTask_NVi.TabStop = false;
            groupBoxTask_NVi.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(21, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(540, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в виде таблицы";
            // 
            // groupBoxResult_NVI
            // 
            groupBoxResult_NVI.Controls.Add(dataGridViewFunction_NVI);
            groupBoxResult_NVI.Controls.Add(labelResult_NVI);
            groupBoxResult_NVI.Font = new Font("Segoe UI", 9F);
            groupBoxResult_NVI.Location = new Point(585, 12);
            groupBoxResult_NVI.Name = "groupBoxResult_NVI";
            groupBoxResult_NVI.Size = new Size(645, 434);
            groupBoxResult_NVI.TabIndex = 3;
            groupBoxResult_NVI.TabStop = false;
            groupBoxResult_NVI.Text = "Вывод данных";
            // 
            // dataGridViewFunction_NVI
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFunction_NVI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFunction_NVI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_NVI.Columns.AddRange(new DataGridViewColumn[] { ColumnForX_NVI, ColumnForFunction_NVI });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewFunction_NVI.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFunction_NVI.Location = new Point(6, 46);
            dataGridViewFunction_NVI.Name = "dataGridViewFunction_NVI";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewFunction_NVI.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFunction_NVI.RowHeadersVisible = false;
            dataGridViewFunction_NVI.RowHeadersWidth = 51;
            dataGridViewFunction_NVI.ScrollBars = ScrollBars.Vertical;
            dataGridViewFunction_NVI.Size = new Size(188, 380);
            dataGridViewFunction_NVI.TabIndex = 2;
            // 
            // labelResult_NVI
            // 
            labelResult_NVI.AutoSize = true;
            labelResult_NVI.Font = new Font("Segoe UI", 9F);
            labelResult_NVI.Location = new Point(6, 23);
            labelResult_NVI.Name = "labelResult_NVI";
            labelResult_NVI.Size = new Size(75, 20);
            labelResult_NVI.TabIndex = 1;
            labelResult_NVI.Text = "Результат";
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.BackColor = Color.Green;
            buttonDone_NVI.Cursor = Cursors.Hand;
            buttonDone_NVI.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            buttonDone_NVI.FlatAppearance.BorderSize = 2;
            buttonDone_NVI.FlatStyle = FlatStyle.Flat;
            buttonDone_NVI.Font = new Font("Segoe UI", 9F);
            buttonDone_NVI.Location = new Point(456, 358);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(114, 88);
            buttonDone_NVI.TabIndex = 4;
            buttonDone_NVI.Text = "Выполнить";
            buttonDone_NVI.UseVisualStyleBackColor = false;
            buttonDone_NVI.Click += buttonDone_NVI_Click;
            buttonDone_NVI.MouseDown += buttonDone_NVI_MouseDown;
            buttonDone_NVI.MouseEnter += buttonDone_NVI_MouseEnter;
            buttonDone_NVI.MouseLeave += buttonDone_NVI_MouseLeave;
            buttonDone_NVI.MouseUp += buttonDone_NVI_MouseUp;
            // 
            // chartFunction_NVI
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NVI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_NVI.Legends.Add(legend1);
            chartFunction_NVI.Location = new Point(785, 35);
            chartFunction_NVI.Name = "chartFunction_NVI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NVI.Series.Add(series1);
            chartFunction_NVI.Size = new Size(439, 403);
            chartFunction_NVI.TabIndex = 5;
            chartFunction_NVI.Text = "Функция";
            // 
            // formMainBindingSource
            // 
            formMainBindingSource.DataSource = typeof(FormMain);
            // 
            // ColumnForX_NVI
            // 
            ColumnForX_NVI.HeaderText = "X";
            ColumnForX_NVI.MinimumWidth = 6;
            ColumnForX_NVI.Name = "ColumnForX_NVI";
            ColumnForX_NVI.ReadOnly = true;
            ColumnForX_NVI.Width = 50;
            // 
            // ColumnForFunction_NVI
            // 
            ColumnForFunction_NVI.HeaderText = "f(x)";
            ColumnForFunction_NVI.MinimumWidth = 6;
            ColumnForFunction_NVI.Name = "ColumnForFunction_NVI";
            ColumnForFunction_NVI.ReadOnly = true;
            ColumnForFunction_NVI.Width = 115;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 450);
            Controls.Add(chartFunction_NVI);
            Controls.Add(buttonDone_NVI);
            Controls.Add(groupBoxResult_NVI);
            Controls.Add(groupBoxTask_NVi);
            Controls.Add(buttonHelp_NVI);
            Controls.Add(groupBoxData_NVI);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Носков В. И.";
            groupBoxData_NVI.ResumeLayout(false);
            groupBoxData_NVI.PerformLayout();
            groupBoxTask_NVi.ResumeLayout(false);
            groupBoxTask_NVi.PerformLayout();
            groupBoxResult_NVI.ResumeLayout(false);
            groupBoxResult_NVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_NVI).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).EndInit();
            ((System.ComponentModel.ISupportInitialize)formMainBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_NVI;
        private Label labelForEnd_NVI;
        private Label labelForStart_NVI;
        private TextBox textBoxEnd_NVI;
        private TextBox textBoxStart_NVI;
        private Button buttonHelp_NVI;
        private GroupBox groupBoxTask_NVi;
        private TextBox textBox1;
        private GroupBox groupBoxResult_NVI;
        private Label labelResult_NVI;
        private Button buttonDone_NVI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVI;
        private DataGridView dataGridViewFunction_NVI;
        private BindingSource formMainBindingSource;
        private DataGridViewTextBoxColumn ColumnForX_NVI;
        private DataGridViewTextBoxColumn ColumnForFunction_NVI;
    }
}
