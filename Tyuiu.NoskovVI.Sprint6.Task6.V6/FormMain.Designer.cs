namespace Tyuiu.NoskovVI.Sprint6.Task6.V6
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
            buttonFindFile_NVI = new Button();
            buttonOutput_NVI = new Button();
            buttonFormAbout_NVI = new Button();
            panelTask_NVI = new Panel();
            groupBoxInfoExit_NVI = new GroupBox();
            textBoxOut_NVI = new TextBox();
            groupBoxInfoEnter_NVI = new GroupBox();
            textBoxIn_NVI = new TextBox();
            groupBoxTask_NVI = new GroupBox();
            textBoxTask_NVI = new TextBox();
            openFileDialogTask_NVI = new OpenFileDialog();
            toolTipHelp_NVI = new ToolTip(components);
            panelTools_NVI.SuspendLayout();
            panelTask_NVI.SuspendLayout();
            groupBoxInfoExit_NVI.SuspendLayout();
            groupBoxInfoEnter_NVI.SuspendLayout();
            groupBoxTask_NVI.SuspendLayout();
            SuspendLayout();
            // 
            // panelTools_NVI
            // 
            panelTools_NVI.BackColor = SystemColors.ControlLight;
            panelTools_NVI.Controls.Add(buttonFindFile_NVI);
            panelTools_NVI.Controls.Add(buttonOutput_NVI);
            panelTools_NVI.Controls.Add(buttonFormAbout_NVI);
            panelTools_NVI.Dock = DockStyle.Top;
            panelTools_NVI.Location = new Point(0, 0);
            panelTools_NVI.Name = "panelTools_NVI";
            panelTools_NVI.Padding = new Padding(3);
            panelTools_NVI.Size = new Size(948, 96);
            panelTools_NVI.TabIndex = 0;
            // 
            // buttonFindFile_NVI
            // 
            buttonFindFile_NVI.BackColor = SystemColors.Control;
            buttonFindFile_NVI.BackgroundImage = Properties.Resources.Folder;
            buttonFindFile_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFindFile_NVI.FlatStyle = FlatStyle.Flat;
            buttonFindFile_NVI.Location = new Point(6, 6);
            buttonFindFile_NVI.Name = "buttonFindFile_NVI";
            buttonFindFile_NVI.Size = new Size(122, 84);
            buttonFindFile_NVI.TabIndex = 0;
            toolTipHelp_NVI.SetToolTip(buttonFindFile_NVI, "Выбрать файл для вводных данных");
            buttonFindFile_NVI.UseVisualStyleBackColor = false;
            buttonFindFile_NVI.Click += buttonFindFile_NVI_Click;
            // 
            // buttonOutput_NVI
            // 
            buttonOutput_NVI.BackColor = SystemColors.Control;
            buttonOutput_NVI.BackgroundImage = Properties.Resources.Paste_Tick;
            buttonOutput_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOutput_NVI.Enabled = false;
            buttonOutput_NVI.FlatStyle = FlatStyle.Flat;
            buttonOutput_NVI.Location = new Point(134, 6);
            buttonOutput_NVI.Name = "buttonOutput_NVI";
            buttonOutput_NVI.Size = new Size(122, 84);
            buttonOutput_NVI.TabIndex = 0;
            toolTipHelp_NVI.SetToolTip(buttonOutput_NVI, "Провести действие и вывести результат");
            buttonOutput_NVI.UseVisualStyleBackColor = false;
            buttonOutput_NVI.Click += buttonOutput_NVI_Click;
            // 
            // buttonFormAbout_NVI
            // 
            buttonFormAbout_NVI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFormAbout_NVI.BackgroundImage = Properties.Resources.Information;
            buttonFormAbout_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFormAbout_NVI.FlatStyle = FlatStyle.Flat;
            buttonFormAbout_NVI.Location = new Point(848, 6);
            buttonFormAbout_NVI.Name = "buttonFormAbout_NVI";
            buttonFormAbout_NVI.Size = new Size(94, 84);
            buttonFormAbout_NVI.TabIndex = 0;
            toolTipHelp_NVI.SetToolTip(buttonFormAbout_NVI, "Нажмите, чтобы узнать о разработчике программы");
            buttonFormAbout_NVI.UseVisualStyleBackColor = true;
            buttonFormAbout_NVI.Click += buttonFormAbout_NVI_Click;
            // 
            // panelTask_NVI
            // 
            panelTask_NVI.Controls.Add(groupBoxInfoExit_NVI);
            panelTask_NVI.Controls.Add(groupBoxInfoEnter_NVI);
            panelTask_NVI.Controls.Add(groupBoxTask_NVI);
            panelTask_NVI.Dock = DockStyle.Fill;
            panelTask_NVI.Location = new Point(0, 96);
            panelTask_NVI.Name = "panelTask_NVI";
            panelTask_NVI.Padding = new Padding(3);
            panelTask_NVI.Size = new Size(948, 421);
            panelTask_NVI.TabIndex = 1;
            // 
            // groupBoxInfoExit_NVI
            // 
            groupBoxInfoExit_NVI.Controls.Add(textBoxOut_NVI);
            groupBoxInfoExit_NVI.Dock = DockStyle.Fill;
            groupBoxInfoExit_NVI.Location = new Point(477, 91);
            groupBoxInfoExit_NVI.Name = "groupBoxInfoExit_NVI";
            groupBoxInfoExit_NVI.Size = new Size(468, 327);
            groupBoxInfoExit_NVI.TabIndex = 2;
            groupBoxInfoExit_NVI.TabStop = false;
            groupBoxInfoExit_NVI.Text = "Вывод";
            // 
            // textBoxOut_NVI
            // 
            textBoxOut_NVI.Dock = DockStyle.Fill;
            textBoxOut_NVI.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOut_NVI.Location = new Point(3, 23);
            textBoxOut_NVI.Multiline = true;
            textBoxOut_NVI.Name = "textBoxOut_NVI";
            textBoxOut_NVI.ReadOnly = true;
            textBoxOut_NVI.ScrollBars = ScrollBars.Both;
            textBoxOut_NVI.Size = new Size(462, 301);
            textBoxOut_NVI.TabIndex = 0;
            // 
            // groupBoxInfoEnter_NVI
            // 
            groupBoxInfoEnter_NVI.Controls.Add(textBoxIn_NVI);
            groupBoxInfoEnter_NVI.Dock = DockStyle.Left;
            groupBoxInfoEnter_NVI.Location = new Point(3, 91);
            groupBoxInfoEnter_NVI.Name = "groupBoxInfoEnter_NVI";
            groupBoxInfoEnter_NVI.Size = new Size(474, 327);
            groupBoxInfoEnter_NVI.TabIndex = 1;
            groupBoxInfoEnter_NVI.TabStop = false;
            groupBoxInfoEnter_NVI.Text = "Ввод";
            // 
            // textBoxIn_NVI
            // 
            textBoxIn_NVI.Dock = DockStyle.Fill;
            textBoxIn_NVI.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_NVI.Location = new Point(3, 23);
            textBoxIn_NVI.Multiline = true;
            textBoxIn_NVI.Name = "textBoxIn_NVI";
            textBoxIn_NVI.ReadOnly = true;
            textBoxIn_NVI.ScrollBars = ScrollBars.Both;
            textBoxIn_NVI.Size = new Size(468, 301);
            textBoxIn_NVI.TabIndex = 0;
            // 
            // groupBoxTask_NVI
            // 
            groupBoxTask_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTask_NVI.Dock = DockStyle.Top;
            groupBoxTask_NVI.Location = new Point(3, 3);
            groupBoxTask_NVI.Name = "groupBoxTask_NVI";
            groupBoxTask_NVI.Size = new Size(942, 88);
            groupBoxTask_NVI.TabIndex = 0;
            groupBoxTask_NVI.TabStop = false;
            groupBoxTask_NVI.Text = "Условие";
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Dock = DockStyle.Fill;
            textBoxTask_NVI.Location = new Point(3, 23);
            textBoxTask_NVI.Multiline = true;
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(936, 62);
            textBoxTask_NVI.TabIndex = 0;
            textBoxTask_NVI.Text = resources.GetString("textBoxTask_NVI.Text");
            // 
            // openFileDialogTask_NVI
            // 
            openFileDialogTask_NVI.FileName = "openFileDialog1";
            // 
            // toolTipHelp_NVI
            // 
            toolTipHelp_NVI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 517);
            Controls.Add(panelTask_NVI);
            Controls.Add(panelTools_NVI);
            MinimumSize = new Size(966, 564);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 6 | Носков В. И.";
            panelTools_NVI.ResumeLayout(false);
            panelTask_NVI.ResumeLayout(false);
            groupBoxInfoExit_NVI.ResumeLayout(false);
            groupBoxInfoExit_NVI.PerformLayout();
            groupBoxInfoEnter_NVI.ResumeLayout(false);
            groupBoxInfoEnter_NVI.PerformLayout();
            groupBoxTask_NVI.ResumeLayout(false);
            groupBoxTask_NVI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools_NVI;
        private Panel panelTask_NVI;
        private GroupBox groupBoxInfoExit_NVI;
        private GroupBox groupBoxInfoEnter_NVI;
        private GroupBox groupBoxTask_NVI;
        private TextBox textBoxOut_NVI;
        private TextBox textBoxIn_NVI;
        private TextBox textBoxTask_NVI;
        private Button buttonFindFile_NVI;
        private Button buttonOutput_NVI;
        private Button buttonFormAbout_NVI;
        private OpenFileDialog openFileDialogTask_NVI;
        private ToolTip toolTipHelp_NVI;
    }
}
