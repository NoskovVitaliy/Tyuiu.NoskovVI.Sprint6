namespace Tyuiu.NoskovVI.Sprint6.Task7.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTools_NVI = new Panel();
            buttonSaveFile_NVI = new Button();
            buttonFindFile_NVI = new Button();
            buttonOutput_NVI = new Button();
            buttonFormAbout_NVI = new Button();
            groupBoxInfoExit_NVI = new GroupBox();
            dataGridViewOut_NVI = new DataGridView();
            groupBoxInfoEnter_NVI = new GroupBox();
            dataGridViewIn_NVI = new DataGridView();
            openFileDialogTask_NVI = new OpenFileDialog();
            toolTipHelp_NVI = new ToolTip(components);
            panelQuestion_NVI = new Panel();
            groupBoxTask_NVI = new GroupBox();
            textBoxTask_NVI = new TextBox();
            splitContainerTask_NVI = new SplitContainer();
            saveFileDialogOutput_NVI = new SaveFileDialog();
            panelTools_NVI.SuspendLayout();
            groupBoxInfoExit_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NVI).BeginInit();
            groupBoxInfoEnter_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NVI).BeginInit();
            panelQuestion_NVI.SuspendLayout();
            groupBoxTask_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTask_NVI).BeginInit();
            splitContainerTask_NVI.Panel1.SuspendLayout();
            splitContainerTask_NVI.Panel2.SuspendLayout();
            splitContainerTask_NVI.SuspendLayout();
            SuspendLayout();
            // 
            // panelTools_NVI
            // 
            panelTools_NVI.BackColor = SystemColors.ControlLight;
            panelTools_NVI.Controls.Add(buttonSaveFile_NVI);
            panelTools_NVI.Controls.Add(buttonFindFile_NVI);
            panelTools_NVI.Controls.Add(buttonOutput_NVI);
            panelTools_NVI.Controls.Add(buttonFormAbout_NVI);
            panelTools_NVI.Dock = DockStyle.Top;
            panelTools_NVI.Location = new Point(0, 0);
            panelTools_NVI.Margin = new Padding(3, 2, 3, 2);
            panelTools_NVI.Name = "panelTools_NVI";
            panelTools_NVI.Padding = new Padding(3, 2, 3, 2);
            panelTools_NVI.Size = new Size(831, 72);
            panelTools_NVI.TabIndex = 0;
            // 
            // buttonSaveFile_NVI
            // 
            buttonSaveFile_NVI.BackgroundImage = Properties.Resources.Save;
            buttonSaveFile_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveFile_NVI.Enabled = false;
            buttonSaveFile_NVI.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_NVI.Location = new Point(230, 4);
            buttonSaveFile_NVI.Name = "buttonSaveFile_NVI";
            buttonSaveFile_NVI.Size = new Size(107, 63);
            buttonSaveFile_NVI.TabIndex = 1;
            toolTipHelp_NVI.SetToolTip(buttonSaveFile_NVI, "Сохранить результат в файл");
            buttonSaveFile_NVI.UseVisualStyleBackColor = true;
            buttonSaveFile_NVI.Click += buttonSaveFile_NVI_Click;
            buttonSaveFile_NVI.MouseEnter += buttonSaveFile_NVI_MouseEnter;
            // 
            // buttonFindFile_NVI
            // 
            buttonFindFile_NVI.BackColor = SystemColors.Control;
            buttonFindFile_NVI.BackgroundImage = Properties.Resources.Folder;
            buttonFindFile_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFindFile_NVI.FlatStyle = FlatStyle.Flat;
            buttonFindFile_NVI.Location = new Point(5, 4);
            buttonFindFile_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonFindFile_NVI.Name = "buttonFindFile_NVI";
            buttonFindFile_NVI.Size = new Size(107, 63);
            buttonFindFile_NVI.TabIndex = 0;
            toolTipHelp_NVI.SetToolTip(buttonFindFile_NVI, "Выбрать файл для вводных данных");
            buttonFindFile_NVI.UseVisualStyleBackColor = false;
            buttonFindFile_NVI.Click += buttonFindFile_NVI_Click;
            buttonFindFile_NVI.MouseEnter += buttonFindFile_NVI_MouseEnter;
            // 
            // buttonOutput_NVI
            // 
            buttonOutput_NVI.BackColor = SystemColors.Control;
            buttonOutput_NVI.BackgroundImage = Properties.Resources.Paste_Tick;
            buttonOutput_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOutput_NVI.Enabled = false;
            buttonOutput_NVI.FlatStyle = FlatStyle.Flat;
            buttonOutput_NVI.Location = new Point(117, 4);
            buttonOutput_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonOutput_NVI.Name = "buttonOutput_NVI";
            buttonOutput_NVI.Size = new Size(107, 63);
            buttonOutput_NVI.TabIndex = 0;
            toolTipHelp_NVI.SetToolTip(buttonOutput_NVI, "Провести действие и вывести результат");
            buttonOutput_NVI.UseVisualStyleBackColor = false;
            buttonOutput_NVI.Click += buttonOutput_NVI_Click;
            buttonOutput_NVI.MouseEnter += buttonOutput_NVI_MouseEnter;
            // 
            // buttonFormAbout_NVI
            // 
            buttonFormAbout_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFormAbout_NVI.BackgroundImage = Properties.Resources.Information;
            buttonFormAbout_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFormAbout_NVI.FlatStyle = FlatStyle.Flat;
            buttonFormAbout_NVI.Location = new Point(743, 4);
            buttonFormAbout_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonFormAbout_NVI.Name = "buttonFormAbout_NVI";
            buttonFormAbout_NVI.Size = new Size(82, 63);
            buttonFormAbout_NVI.TabIndex = 0;
            toolTipHelp_NVI.SetToolTip(buttonFormAbout_NVI, "Нажмите, чтобы узнать о разработчике программы");
            buttonFormAbout_NVI.UseVisualStyleBackColor = true;
            buttonFormAbout_NVI.Click += buttonFormAbout_NVI_Click;
            buttonFormAbout_NVI.MouseEnter += buttonFormAbout_NVI_MouseEnter;
            // 
            // groupBoxInfoExit_NVI
            // 
            groupBoxInfoExit_NVI.Controls.Add(dataGridViewOut_NVI);
            groupBoxInfoExit_NVI.Dock = DockStyle.Fill;
            groupBoxInfoExit_NVI.Location = new Point(3, 3);
            groupBoxInfoExit_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxInfoExit_NVI.Name = "groupBoxInfoExit_NVI";
            groupBoxInfoExit_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxInfoExit_NVI.Size = new Size(406, 249);
            groupBoxInfoExit_NVI.TabIndex = 2;
            groupBoxInfoExit_NVI.TabStop = false;
            groupBoxInfoExit_NVI.Text = "Вывод";
            // 
            // dataGridViewOut_NVI
            // 
            dataGridViewOut_NVI.AllowUserToResizeColumns = false;
            dataGridViewOut_NVI.AllowUserToResizeRows = false;
            dataGridViewOut_NVI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_NVI.ColumnHeadersVisible = false;
            dataGridViewOut_NVI.Dock = DockStyle.Fill;
            dataGridViewOut_NVI.Location = new Point(3, 18);
            dataGridViewOut_NVI.Name = "dataGridViewOut_NVI";
            dataGridViewOut_NVI.RowHeadersVisible = false;
            dataGridViewOut_NVI.Size = new Size(400, 229);
            dataGridViewOut_NVI.TabIndex = 0;
            // 
            // groupBoxInfoEnter_NVI
            // 
            groupBoxInfoEnter_NVI.Controls.Add(dataGridViewIn_NVI);
            groupBoxInfoEnter_NVI.Dock = DockStyle.Fill;
            groupBoxInfoEnter_NVI.Location = new Point(3, 3);
            groupBoxInfoEnter_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxInfoEnter_NVI.Name = "groupBoxInfoEnter_NVI";
            groupBoxInfoEnter_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxInfoEnter_NVI.Size = new Size(409, 249);
            groupBoxInfoEnter_NVI.TabIndex = 1;
            groupBoxInfoEnter_NVI.TabStop = false;
            groupBoxInfoEnter_NVI.Text = "Ввод";
            // 
            // dataGridViewIn_NVI
            // 
            dataGridViewIn_NVI.AllowUserToResizeColumns = false;
            dataGridViewIn_NVI.AllowUserToResizeRows = false;
            dataGridViewIn_NVI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_NVI.ColumnHeadersVisible = false;
            dataGridViewIn_NVI.Dock = DockStyle.Fill;
            dataGridViewIn_NVI.Location = new Point(3, 18);
            dataGridViewIn_NVI.Name = "dataGridViewIn_NVI";
            dataGridViewIn_NVI.RowHeadersVisible = false;
            dataGridViewIn_NVI.Size = new Size(403, 229);
            dataGridViewIn_NVI.TabIndex = 0;
            // 
            // openFileDialogTask_NVI
            // 
            openFileDialogTask_NVI.FileName = "openFileDialog1";
            // 
            // toolTipHelp_NVI
            // 
            toolTipHelp_NVI.IsBalloon = true;
            toolTipHelp_NVI.ToolTipTitle = "Подсказка";
            // 
            // panelQuestion_NVI
            // 
            panelQuestion_NVI.Controls.Add(groupBoxTask_NVI);
            panelQuestion_NVI.Dock = DockStyle.Top;
            panelQuestion_NVI.Location = new Point(0, 72);
            panelQuestion_NVI.Name = "panelQuestion_NVI";
            panelQuestion_NVI.Size = new Size(831, 67);
            panelQuestion_NVI.TabIndex = 2;
            // 
            // groupBoxTask_NVI
            // 
            groupBoxTask_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTask_NVI.Dock = DockStyle.Fill;
            groupBoxTask_NVI.Location = new Point(0, 0);
            groupBoxTask_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask_NVI.Name = "groupBoxTask_NVI";
            groupBoxTask_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask_NVI.Size = new Size(831, 67);
            groupBoxTask_NVI.TabIndex = 0;
            groupBoxTask_NVI.TabStop = false;
            groupBoxTask_NVI.Text = "Условие";
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Dock = DockStyle.Fill;
            textBoxTask_NVI.Location = new Point(3, 18);
            textBoxTask_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxTask_NVI.Multiline = true;
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(825, 47);
            textBoxTask_NVI.TabIndex = 0;
            textBoxTask_NVI.Text = resources.GetString("textBoxTask_NVI.Text");
            // 
            // splitContainerTask_NVI
            // 
            splitContainerTask_NVI.BackColor = SystemColors.ActiveCaption;
            splitContainerTask_NVI.Dock = DockStyle.Fill;
            splitContainerTask_NVI.Location = new Point(0, 139);
            splitContainerTask_NVI.Name = "splitContainerTask_NVI";
            // 
            // splitContainerTask_NVI.Panel1
            // 
            splitContainerTask_NVI.Panel1.Controls.Add(groupBoxInfoEnter_NVI);
            splitContainerTask_NVI.Panel1.Padding = new Padding(3);
            // 
            // splitContainerTask_NVI.Panel2
            // 
            splitContainerTask_NVI.Panel2.Controls.Add(groupBoxInfoExit_NVI);
            splitContainerTask_NVI.Panel2.Padding = new Padding(3);
            splitContainerTask_NVI.Size = new Size(831, 255);
            splitContainerTask_NVI.SplitterDistance = 415;
            splitContainerTask_NVI.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 394);
            Controls.Add(splitContainerTask_NVI);
            Controls.Add(panelQuestion_NVI);
            Controls.Add(panelTools_NVI);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(847, 433);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 6 | Носков В. И.";
            Load += FormMain_Load;
            panelTools_NVI.ResumeLayout(false);
            groupBoxInfoExit_NVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NVI).EndInit();
            groupBoxInfoEnter_NVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NVI).EndInit();
            panelQuestion_NVI.ResumeLayout(false);
            groupBoxTask_NVI.ResumeLayout(false);
            groupBoxTask_NVI.PerformLayout();
            splitContainerTask_NVI.Panel1.ResumeLayout(false);
            splitContainerTask_NVI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTask_NVI).EndInit();
            splitContainerTask_NVI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools_NVI;
        private GroupBox groupBoxInfoExit_NVI;
        private GroupBox groupBoxInfoEnter_NVI;
        private Button buttonFindFile_NVI;
        private Button buttonOutput_NVI;
        private Button buttonFormAbout_NVI;
        private OpenFileDialog openFileDialogTask_NVI;
        private ToolTip toolTipHelp_NVI;
        private Panel panelQuestion_NVI;
        private GroupBox groupBoxTask_NVI;
        private TextBox textBoxTask_NVI;
        private SplitContainer splitContainerTask_NVI;
        private DataGridView dataGridViewOut_NVI;
        private DataGridView dataGridViewIn_NVI;
        private SaveFileDialog saveFileDialogOutput_NVI;
        private Button buttonSaveFile_NVI;
    }
}
