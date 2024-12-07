namespace Tyuiu.NoskovVI.Sprint6.Task5.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_NVI = new Panel();
            buttonDone_NVI = new Button();
            buttonFileOpen_NVI = new Button();
            buttonHelp_NVI = new Button();
            groupBoxTask_NVI = new GroupBox();
            textBoxTask_NVI = new TextBox();
            panelLeft_NVI = new Panel();
            groupBoxData_NVI = new GroupBox();
            dataGridNums_NVI = new DataGridView();
            panelFill_NVI = new Panel();
            chartFunction_NVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_NVI.SuspendLayout();
            groupBoxTask_NVI.SuspendLayout();
            panelLeft_NVI.SuspendLayout();
            groupBoxData_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNums_NVI).BeginInit();
            panelFill_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).BeginInit();
            SuspendLayout();
            // 
            // panelTop_NVI
            // 
            panelTop_NVI.BackColor = Color.FromArgb(192, 192, 255);
            panelTop_NVI.Controls.Add(buttonDone_NVI);
            panelTop_NVI.Controls.Add(buttonFileOpen_NVI);
            panelTop_NVI.Controls.Add(buttonHelp_NVI);
            panelTop_NVI.Controls.Add(groupBoxTask_NVI);
            panelTop_NVI.Dock = DockStyle.Top;
            panelTop_NVI.Location = new Point(0, 0);
            panelTop_NVI.Name = "panelTop_NVI";
            panelTop_NVI.Padding = new Padding(3);
            panelTop_NVI.Size = new Size(900, 113);
            panelTop_NVI.TabIndex = 0;
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_NVI.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_NVI.FlatStyle = FlatStyle.Flat;
            buttonDone_NVI.Location = new Point(586, 42);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(102, 62);
            buttonDone_NVI.TabIndex = 1;
            buttonDone_NVI.Text = "Выполнить";
            buttonDone_NVI.UseVisualStyleBackColor = false;
            buttonDone_NVI.Click += buttonDone_NVI_Click;
            // 
            // buttonFileOpen_NVI
            // 
            buttonFileOpen_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFileOpen_NVI.BackColor = Color.DarkTurquoise;
            buttonFileOpen_NVI.FlatStyle = FlatStyle.Flat;
            buttonFileOpen_NVI.Location = new Point(694, 42);
            buttonFileOpen_NVI.Name = "buttonFileOpen_NVI";
            buttonFileOpen_NVI.Size = new Size(94, 62);
            buttonFileOpen_NVI.TabIndex = 1;
            buttonFileOpen_NVI.Text = "Открыть файл";
            buttonFileOpen_NVI.UseVisualStyleBackColor = false;
            buttonFileOpen_NVI.Click += buttonFileOpen_NVI_Click;
            // 
            // buttonHelp_NVI
            // 
            buttonHelp_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NVI.BackColor = Color.DodgerBlue;
            buttonHelp_NVI.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVI.Location = new Point(794, 42);
            buttonHelp_NVI.Name = "buttonHelp_NVI";
            buttonHelp_NVI.Size = new Size(94, 62);
            buttonHelp_NVI.TabIndex = 1;
            buttonHelp_NVI.Text = "Справка";
            buttonHelp_NVI.UseVisualStyleBackColor = false;
            buttonHelp_NVI.Click += buttonHelp_NVI_Click;
            // 
            // groupBoxTask_NVI
            // 
            groupBoxTask_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTask_NVI.Location = new Point(3, 0);
            groupBoxTask_NVI.Name = "groupBoxTask_NVI";
            groupBoxTask_NVI.Size = new Size(557, 107);
            groupBoxTask_NVI.TabIndex = 0;
            groupBoxTask_NVI.TabStop = false;
            groupBoxTask_NVI.Text = "Условие";
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BackColor = Color.FromArgb(192, 192, 255);
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Dock = DockStyle.Fill;
            textBoxTask_NVI.Location = new Point(3, 23);
            textBoxTask_NVI.Multiline = true;
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(551, 81);
            textBoxTask_NVI.TabIndex = 0;
            textBoxTask_NVI.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView\r\nотрицательные значения и построить диаграмму по этим значениям";
            // 
            // panelLeft_NVI
            // 
            panelLeft_NVI.BackColor = SystemColors.GradientActiveCaption;
            panelLeft_NVI.Controls.Add(groupBoxData_NVI);
            panelLeft_NVI.Dock = DockStyle.Left;
            panelLeft_NVI.Location = new Point(0, 113);
            panelLeft_NVI.Name = "panelLeft_NVI";
            panelLeft_NVI.Padding = new Padding(3);
            panelLeft_NVI.Size = new Size(188, 390);
            panelLeft_NVI.TabIndex = 1;
            // 
            // groupBoxData_NVI
            // 
            groupBoxData_NVI.Controls.Add(dataGridNums_NVI);
            groupBoxData_NVI.Dock = DockStyle.Fill;
            groupBoxData_NVI.Location = new Point(3, 3);
            groupBoxData_NVI.Name = "groupBoxData_NVI";
            groupBoxData_NVI.Size = new Size(182, 384);
            groupBoxData_NVI.TabIndex = 0;
            groupBoxData_NVI.TabStop = false;
            groupBoxData_NVI.Text = "Вывод данных";
            // 
            // dataGridNums_NVI
            // 
            dataGridNums_NVI.AllowUserToResizeColumns = false;
            dataGridNums_NVI.AllowUserToResizeRows = false;
            dataGridNums_NVI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNums_NVI.Dock = DockStyle.Fill;
            dataGridNums_NVI.Location = new Point(3, 23);
            dataGridNums_NVI.Name = "dataGridNums_NVI";
            dataGridNums_NVI.RowHeadersVisible = false;
            dataGridNums_NVI.RowHeadersWidth = 51;
            dataGridNums_NVI.ScrollBars = ScrollBars.Vertical;
            dataGridNums_NVI.Size = new Size(176, 358);
            dataGridNums_NVI.TabIndex = 0;
            // 
            // panelFill_NVI
            // 
            panelFill_NVI.Controls.Add(chartFunction_NVI);
            panelFill_NVI.Dock = DockStyle.Fill;
            panelFill_NVI.Location = new Point(188, 113);
            panelFill_NVI.Name = "panelFill_NVI";
            panelFill_NVI.Size = new Size(712, 390);
            panelFill_NVI.TabIndex = 2;
            // 
            // chartFunction_NVI
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NVI.ChartAreas.Add(chartArea1);
            chartFunction_NVI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_NVI.Legends.Add(legend1);
            chartFunction_NVI.Location = new Point(0, 0);
            chartFunction_NVI.Name = "chartFunction_NVI";
            chartFunction_NVI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NVI.Series.Add(series1);
            chartFunction_NVI.Size = new Size(712, 390);
            chartFunction_NVI.TabIndex = 0;
            chartFunction_NVI.Text = "TextChart_NVI";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 503);
            Controls.Add(panelFill_NVI);
            Controls.Add(panelLeft_NVI);
            Controls.Add(panelTop_NVI);
            MinimumSize = new Size(918, 550);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 23 | Носков В. И.";
            panelTop_NVI.ResumeLayout(false);
            groupBoxTask_NVI.ResumeLayout(false);
            groupBoxTask_NVI.PerformLayout();
            panelLeft_NVI.ResumeLayout(false);
            groupBoxData_NVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridNums_NVI).EndInit();
            panelFill_NVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_NVI;
        private Panel panelLeft_NVI;
        private Panel panelFill_NVI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVI;
        private GroupBox groupBoxData_NVI;
        private DataGridView dataGridNums_NVI;
        private GroupBox groupBoxTask_NVI;
        private TextBox textBoxTask_NVI;
        private Button buttonHelp_NVI;
        private Button buttonDone_NVI;
        private Button buttonFileOpen_NVI;
    }
}
