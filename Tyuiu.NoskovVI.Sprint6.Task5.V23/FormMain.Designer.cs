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
            groupBoxData_NVI = new GroupBox();
            dataGridNums_NVI = new DataGridView();
            chartFunction_NVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitContainerFuncGrid_NVI = new SplitContainer();
            panelTop_NVI.SuspendLayout();
            groupBoxTask_NVI.SuspendLayout();
            groupBoxData_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNums_NVI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerFuncGrid_NVI).BeginInit();
            splitContainerFuncGrid_NVI.Panel1.SuspendLayout();
            splitContainerFuncGrid_NVI.Panel2.SuspendLayout();
            splitContainerFuncGrid_NVI.SuspendLayout();
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
            panelTop_NVI.Margin = new Padding(3, 2, 3, 2);
            panelTop_NVI.Name = "panelTop_NVI";
            panelTop_NVI.Padding = new Padding(3, 2, 3, 2);
            panelTop_NVI.Size = new Size(789, 85);
            panelTop_NVI.TabIndex = 0;
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_NVI.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_NVI.FlatStyle = FlatStyle.Flat;
            buttonDone_NVI.Location = new Point(514, 32);
            buttonDone_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(89, 46);
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
            buttonFileOpen_NVI.Location = new Point(608, 32);
            buttonFileOpen_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonFileOpen_NVI.Name = "buttonFileOpen_NVI";
            buttonFileOpen_NVI.Size = new Size(82, 46);
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
            buttonHelp_NVI.Location = new Point(696, 32);
            buttonHelp_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonHelp_NVI.Name = "buttonHelp_NVI";
            buttonHelp_NVI.Size = new Size(82, 46);
            buttonHelp_NVI.TabIndex = 1;
            buttonHelp_NVI.Text = "Справка";
            buttonHelp_NVI.UseVisualStyleBackColor = false;
            buttonHelp_NVI.Click += buttonHelp_NVI_Click;
            // 
            // groupBoxTask_NVI
            // 
            groupBoxTask_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTask_NVI.Location = new Point(3, 0);
            groupBoxTask_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask_NVI.Name = "groupBoxTask_NVI";
            groupBoxTask_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask_NVI.Size = new Size(487, 80);
            groupBoxTask_NVI.TabIndex = 0;
            groupBoxTask_NVI.TabStop = false;
            groupBoxTask_NVI.Text = "Условие";
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BackColor = Color.FromArgb(192, 192, 255);
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Dock = DockStyle.Fill;
            textBoxTask_NVI.Location = new Point(3, 18);
            textBoxTask_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxTask_NVI.Multiline = true;
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(481, 60);
            textBoxTask_NVI.TabIndex = 0;
            textBoxTask_NVI.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView\r\nотрицательные значения и построить диаграмму по этим значениям";
            // 
            // groupBoxData_NVI
            // 
            groupBoxData_NVI.Controls.Add(dataGridNums_NVI);
            groupBoxData_NVI.Dock = DockStyle.Fill;
            groupBoxData_NVI.Location = new Point(3, 3);
            groupBoxData_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxData_NVI.Name = "groupBoxData_NVI";
            groupBoxData_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxData_NVI.Size = new Size(257, 292);
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
            dataGridNums_NVI.Location = new Point(3, 18);
            dataGridNums_NVI.Margin = new Padding(3, 2, 3, 2);
            dataGridNums_NVI.Name = "dataGridNums_NVI";
            dataGridNums_NVI.RowHeadersVisible = false;
            dataGridNums_NVI.RowHeadersWidth = 51;
            dataGridNums_NVI.ScrollBars = ScrollBars.Vertical;
            dataGridNums_NVI.Size = new Size(251, 272);
            dataGridNums_NVI.TabIndex = 0;
            // 
            // chartFunction_NVI
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_NVI.ChartAreas.Add(chartArea1);
            chartFunction_NVI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_NVI.Legends.Add(legend1);
            chartFunction_NVI.Location = new Point(0, 0);
            chartFunction_NVI.Margin = new Padding(3, 2, 3, 2);
            chartFunction_NVI.Name = "chartFunction_NVI";
            chartFunction_NVI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NVI.Series.Add(series1);
            chartFunction_NVI.Size = new Size(522, 298);
            chartFunction_NVI.TabIndex = 0;
            chartFunction_NVI.Text = "TextChart_NVI";
            // 
            // splitContainerFuncGrid_NVI
            // 
            splitContainerFuncGrid_NVI.Dock = DockStyle.Fill;
            splitContainerFuncGrid_NVI.Location = new Point(0, 85);
            splitContainerFuncGrid_NVI.Name = "splitContainerFuncGrid_NVI";
            // 
            // splitContainerFuncGrid_NVI.Panel1
            // 
            splitContainerFuncGrid_NVI.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainerFuncGrid_NVI.Panel1.Controls.Add(groupBoxData_NVI);
            splitContainerFuncGrid_NVI.Panel1.Padding = new Padding(3);
            // 
            // splitContainerFuncGrid_NVI.Panel2
            // 
            splitContainerFuncGrid_NVI.Panel2.Controls.Add(chartFunction_NVI);
            splitContainerFuncGrid_NVI.Size = new Size(789, 298);
            splitContainerFuncGrid_NVI.SplitterDistance = 263;
            splitContainerFuncGrid_NVI.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 383);
            Controls.Add(splitContainerFuncGrid_NVI);
            Controls.Add(panelTop_NVI);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(805, 422);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 23 | Носков В. И.";
            panelTop_NVI.ResumeLayout(false);
            groupBoxTask_NVI.ResumeLayout(false);
            groupBoxTask_NVI.PerformLayout();
            groupBoxData_NVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridNums_NVI).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).EndInit();
            splitContainerFuncGrid_NVI.Panel1.ResumeLayout(false);
            splitContainerFuncGrid_NVI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerFuncGrid_NVI).EndInit();
            splitContainerFuncGrid_NVI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_NVI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVI;
        private GroupBox groupBoxData_NVI;
        private DataGridView dataGridNums_NVI;
        private GroupBox groupBoxTask_NVI;
        private TextBox textBoxTask_NVI;
        private Button buttonHelp_NVI;
        private Button buttonDone_NVI;
        private Button buttonFileOpen_NVI;
        private SplitContainer splitContainerFuncGrid_NVI;
    }
}
