namespace Tyuiu.NoskovVI.Sprint6.Task4.V19
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            taskPanel_NVI = new Panel();
            buttonDone_NVI = new Button();
            buttonSave_NVI = new Button();
            buttonHelp_NVI = new Button();
            groupBoxData_NVI = new GroupBox();
            textBoxVarEnd_NVI = new TextBox();
            textBoxVarStart_NVI = new TextBox();
            labelVarStart_NVI = new Label();
            labelVarEnd_NVI = new Label();
            groupBoxTop_NVI = new GroupBox();
            textBoxTask_NVI = new TextBox();
            groupBoxResult_NVi = new GroupBox();
            textBoxResult_NVI = new TextBox();
            chartFunction_NVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textPanel_NVI = new Panel();
            seriesPanel_NVi = new Panel();
            splitterFunction_NVI = new Splitter();
            taskPanel_NVI.SuspendLayout();
            groupBoxData_NVI.SuspendLayout();
            groupBoxTop_NVI.SuspendLayout();
            groupBoxResult_NVi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).BeginInit();
            textPanel_NVI.SuspendLayout();
            seriesPanel_NVi.SuspendLayout();
            SuspendLayout();
            // 
            // taskPanel_NVI
            // 
            taskPanel_NVI.BackColor = SystemColors.ControlLight;
            taskPanel_NVI.Controls.Add(buttonDone_NVI);
            taskPanel_NVI.Controls.Add(buttonSave_NVI);
            taskPanel_NVI.Controls.Add(buttonHelp_NVI);
            taskPanel_NVI.Controls.Add(groupBoxData_NVI);
            taskPanel_NVI.Controls.Add(groupBoxTop_NVI);
            taskPanel_NVI.Dock = DockStyle.Top;
            taskPanel_NVI.Location = new Point(0, 0);
            taskPanel_NVI.Margin = new Padding(3, 2, 3, 2);
            taskPanel_NVI.Name = "taskPanel_NVI";
            taskPanel_NVI.Size = new Size(911, 70);
            taskPanel_NVI.TabIndex = 0;
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_NVI.BackColor = Color.GreenYellow;
            buttonDone_NVI.Cursor = Cursors.Hand;
            buttonDone_NVI.FlatStyle = FlatStyle.Flat;
            buttonDone_NVI.Location = new Point(721, 19);
            buttonDone_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(98, 45);
            buttonDone_NVI.TabIndex = 4;
            buttonDone_NVI.Text = "Выполнить";
            buttonDone_NVI.UseVisualStyleBackColor = false;
            buttonDone_NVI.Click += buttonDone_NVI_Click;
            // 
            // buttonSave_NVI
            // 
            buttonSave_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_NVI.BackColor = SystemColors.ActiveCaption;
            buttonSave_NVI.Cursor = Cursors.Hand;
            buttonSave_NVI.FlatStyle = FlatStyle.Flat;
            buttonSave_NVI.Location = new Point(634, 20);
            buttonSave_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonSave_NVI.Name = "buttonSave_NVI";
            buttonSave_NVI.Size = new Size(82, 44);
            buttonSave_NVI.TabIndex = 3;
            buttonSave_NVI.Text = "Сохранить";
            buttonSave_NVI.UseVisualStyleBackColor = false;
            buttonSave_NVI.Click += buttonSave_NVI_Click;
            // 
            // buttonHelp_NVI
            // 
            buttonHelp_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NVI.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_NVI.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVI.Location = new Point(824, 20);
            buttonHelp_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonHelp_NVI.Name = "buttonHelp_NVI";
            buttonHelp_NVI.Padding = new Padding(3, 2, 3, 2);
            buttonHelp_NVI.Size = new Size(76, 44);
            buttonHelp_NVI.TabIndex = 2;
            buttonHelp_NVI.Text = "Справка";
            buttonHelp_NVI.UseVisualStyleBackColor = false;
            buttonHelp_NVI.Click += buttonHelp_NVI_Click;
            // 
            // groupBoxData_NVI
            // 
            groupBoxData_NVI.Controls.Add(textBoxVarEnd_NVI);
            groupBoxData_NVI.Controls.Add(textBoxVarStart_NVI);
            groupBoxData_NVI.Controls.Add(labelVarStart_NVI);
            groupBoxData_NVI.Controls.Add(labelVarEnd_NVI);
            groupBoxData_NVI.Location = new Point(368, 2);
            groupBoxData_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxData_NVI.Name = "groupBoxData_NVI";
            groupBoxData_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxData_NVI.Size = new Size(259, 66);
            groupBoxData_NVI.TabIndex = 1;
            groupBoxData_NVI.TabStop = false;
            groupBoxData_NVI.Text = "Ввод данных";
            // 
            // textBoxVarEnd_NVI
            // 
            textBoxVarEnd_NVI.Location = new Point(144, 41);
            textBoxVarEnd_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxVarEnd_NVI.Name = "textBoxVarEnd_NVI";
            textBoxVarEnd_NVI.Size = new Size(110, 23);
            textBoxVarEnd_NVI.TabIndex = 1;
            textBoxVarEnd_NVI.Text = "5";
            // 
            // textBoxVarStart_NVI
            // 
            textBoxVarStart_NVI.Location = new Point(21, 41);
            textBoxVarStart_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxVarStart_NVI.Name = "textBoxVarStart_NVI";
            textBoxVarStart_NVI.Size = new Size(110, 23);
            textBoxVarStart_NVI.TabIndex = 1;
            textBoxVarStart_NVI.Text = "-5";
            // 
            // labelVarStart_NVI
            // 
            labelVarStart_NVI.AutoSize = true;
            labelVarStart_NVI.Location = new Point(21, 25);
            labelVarStart_NVI.Name = "labelVarStart_NVI";
            labelVarStart_NVI.Size = new Size(69, 15);
            labelVarStart_NVI.TabIndex = 0;
            labelVarStart_NVI.Text = "Старт шага";
            // 
            // labelVarEnd_NVI
            // 
            labelVarEnd_NVI.AutoSize = true;
            labelVarEnd_NVI.Location = new Point(144, 25);
            labelVarEnd_NVI.Name = "labelVarEnd_NVI";
            labelVarEnd_NVI.Size = new Size(72, 15);
            labelVarEnd_NVI.TabIndex = 0;
            labelVarEnd_NVI.Text = "Конец шага";
            // 
            // groupBoxTop_NVI
            // 
            groupBoxTop_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTop_NVI.Location = new Point(3, 2);
            groupBoxTop_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxTop_NVI.Name = "groupBoxTop_NVI";
            groupBoxTop_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxTop_NVI.Size = new Size(360, 64);
            groupBoxTop_NVI.TabIndex = 0;
            groupBoxTop_NVI.TabStop = false;
            groupBoxTop_NVI.Text = "Условие";
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BackColor = SystemColors.ControlLight;
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Dock = DockStyle.Fill;
            textBoxTask_NVI.Location = new Point(3, 18);
            textBoxTask_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxTask_NVI.Multiline = true;
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(354, 44);
            textBoxTask_NVI.TabIndex = 0;
            textBoxTask_NVI.Text = "Произвести табулирование функции на диапазоне [-5;5]\r\nРезультат вывести в textBox и сохранить в OutPutFileTask4V19.txt";
            // 
            // groupBoxResult_NVi
            // 
            groupBoxResult_NVi.Controls.Add(textBoxResult_NVI);
            groupBoxResult_NVi.Dock = DockStyle.Fill;
            groupBoxResult_NVi.Location = new Point(3, 2);
            groupBoxResult_NVi.Margin = new Padding(4, 4, 4, 4);
            groupBoxResult_NVi.Name = "groupBoxResult_NVi";
            groupBoxResult_NVi.Padding = new Padding(4, 4, 4, 4);
            groupBoxResult_NVi.Size = new Size(230, 338);
            groupBoxResult_NVi.TabIndex = 0;
            groupBoxResult_NVi.TabStop = false;
            groupBoxResult_NVi.Text = "Вывод";
            // 
            // textBoxResult_NVI
            // 
            textBoxResult_NVI.BackColor = SystemColors.Control;
            textBoxResult_NVI.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_NVI.Dock = DockStyle.Fill;
            textBoxResult_NVI.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_NVI.Location = new Point(4, 20);
            textBoxResult_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxResult_NVI.Multiline = true;
            textBoxResult_NVI.Name = "textBoxResult_NVI";
            textBoxResult_NVI.ReadOnly = true;
            textBoxResult_NVI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_NVI.Size = new Size(222, 314);
            textBoxResult_NVI.TabIndex = 0;
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
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_NVI.Series.Add(series1);
            chartFunction_NVI.Size = new Size(675, 342);
            chartFunction_NVI.TabIndex = 0;
            chartFunction_NVI.Text = "seriesChart_NVI";
            title1.BackColor = Color.White;
            title1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.Name = "seriesName_NVI";
            title1.Text = "График функции";
            chartFunction_NVI.Titles.Add(title1);
            // 
            // textPanel_NVI
            // 
            textPanel_NVI.BackColor = SystemColors.ActiveCaption;
            textPanel_NVI.Controls.Add(groupBoxResult_NVi);
            textPanel_NVI.Dock = DockStyle.Left;
            textPanel_NVI.Location = new Point(0, 70);
            textPanel_NVI.Margin = new Padding(3, 2, 3, 2);
            textPanel_NVI.MaximumSize = new Size(350, 450);
            textPanel_NVI.MinimumSize = new Size(236, 336);
            textPanel_NVI.Name = "textPanel_NVI";
            textPanel_NVI.Padding = new Padding(3, 2, 3, 2);
            textPanel_NVI.Size = new Size(236, 342);
            textPanel_NVI.TabIndex = 1;
            // 
            // seriesPanel_NVi
            // 
            seriesPanel_NVi.Controls.Add(splitterFunction_NVI);
            seriesPanel_NVi.Controls.Add(chartFunction_NVI);
            seriesPanel_NVi.Dock = DockStyle.Fill;
            seriesPanel_NVi.Location = new Point(236, 70);
            seriesPanel_NVi.Margin = new Padding(3, 2, 3, 2);
            seriesPanel_NVi.MinimumSize = new Size(438, 300);
            seriesPanel_NVi.Name = "seriesPanel_NVi";
            seriesPanel_NVi.Size = new Size(675, 342);
            seriesPanel_NVi.TabIndex = 2;
            // 
            // splitterFunction_NVI
            // 
            splitterFunction_NVI.Location = new Point(0, 0);
            splitterFunction_NVI.Margin = new Padding(3, 2, 3, 2);
            splitterFunction_NVI.Name = "splitterFunction_NVI";
            splitterFunction_NVI.Size = new Size(4, 342);
            splitterFunction_NVI.TabIndex = 1;
            splitterFunction_NVI.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 412);
            Controls.Add(seriesPanel_NVi);
            Controls.Add(textPanel_NVI);
            Controls.Add(taskPanel_NVI);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(927, 451);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 19 | Носков В. И.";
            taskPanel_NVI.ResumeLayout(false);
            groupBoxData_NVI.ResumeLayout(false);
            groupBoxData_NVI.PerformLayout();
            groupBoxTop_NVI.ResumeLayout(false);
            groupBoxTop_NVI.PerformLayout();
            groupBoxResult_NVi.ResumeLayout(false);
            groupBoxResult_NVi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_NVI).EndInit();
            textPanel_NVI.ResumeLayout(false);
            seriesPanel_NVi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel taskPanel_NVI;
        private GroupBox groupBoxResult_NVi;
        private TextBox textBoxResult_NVI;
        private GroupBox groupBoxTop_NVI;
        private TextBox textBoxTask_NVI;
        private GroupBox groupBoxData_NVI;
        private TextBox textBoxVarEnd_NVI;
        private TextBox textBoxVarStart_NVI;
        private Label labelVarStart_NVI;
        private Label labelVarEnd_NVI;
        private Button buttonHelp_NVI;
        private Button buttonSave_NVI;
        private Button buttonDone_NVI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NVI;
        private Panel textPanel_NVI;
        private Panel seriesPanel_NVi;
        private Splitter splitterFunction_NVI;
    }
}
