namespace Tyuiu.NoskovVI.Sprint6.Task1.V3
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
            groupBoxData_NVI = new GroupBox();
            textBoxEnd_NVI = new TextBox();
            textBoxStart_NVI = new TextBox();
            labelForEnd_NVI = new Label();
            labelForStart_NVI = new Label();
            buttonHelp_NVI = new Button();
            groupBoxTask_NVi = new GroupBox();
            textBox1 = new TextBox();
            groupBoxResult_NVI = new GroupBox();
            vScrollBarResult_NVI = new VScrollBar();
            labelResult_NVI = new Label();
            textBoxResult_NVI = new TextBox();
            buttonDone_NVI = new Button();
            groupBoxData_NVI.SuspendLayout();
            groupBoxTask_NVi.SuspendLayout();
            groupBoxResult_NVI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData_NVI
            // 
            groupBoxData_NVI.Controls.Add(textBoxEnd_NVI);
            groupBoxData_NVI.Controls.Add(textBoxStart_NVI);
            groupBoxData_NVI.Controls.Add(labelForEnd_NVI);
            groupBoxData_NVI.Controls.Add(labelForStart_NVI);
            groupBoxData_NVI.Font = new Font("Leelawadee UI", 9F);
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
            // 
            // textBoxStart_NVI
            // 
            textBoxStart_NVI.Location = new Point(21, 63);
            textBoxStart_NVI.Name = "textBoxStart_NVI";
            textBoxStart_NVI.Size = new Size(125, 27);
            textBoxStart_NVI.TabIndex = 2;
            // 
            // labelForEnd_NVI
            // 
            labelForEnd_NVI.AutoSize = true;
            labelForEnd_NVI.Font = new Font("Leelawadee UI", 9F);
            labelForEnd_NVI.Location = new Point(162, 36);
            labelForEnd_NVI.Name = "labelForEnd_NVI";
            labelForEnd_NVI.Size = new Size(89, 20);
            labelForEnd_NVI.TabIndex = 1;
            labelForEnd_NVI.Text = "Конец шага";
            // 
            // labelForStart_NVI
            // 
            labelForStart_NVI.AutoSize = true;
            labelForStart_NVI.Font = new Font("Leelawadee UI", 9F);
            labelForStart_NVI.Location = new Point(21, 36);
            labelForStart_NVI.Name = "labelForStart_NVI";
            labelForStart_NVI.Size = new Size(87, 20);
            labelForStart_NVI.TabIndex = 0;
            labelForStart_NVI.Text = "Старт шага";
            // 
            // buttonHelp_NVI
            // 
            buttonHelp_NVI.BackColor = SystemColors.Highlight;
            buttonHelp_NVI.FlatAppearance.BorderColor = Color.Red;
            buttonHelp_NVI.FlatAppearance.BorderSize = 2;
            buttonHelp_NVI.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVI.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            groupBoxResult_NVI.Controls.Add(vScrollBarResult_NVI);
            groupBoxResult_NVI.Controls.Add(labelResult_NVI);
            groupBoxResult_NVI.Controls.Add(textBoxResult_NVI);
            groupBoxResult_NVI.Location = new Point(585, 12);
            groupBoxResult_NVI.Name = "groupBoxResult_NVI";
            groupBoxResult_NVI.Size = new Size(281, 434);
            groupBoxResult_NVI.TabIndex = 3;
            groupBoxResult_NVI.TabStop = false;
            groupBoxResult_NVI.Text = "Вывод данных";
            // 
            // vScrollBarResult_NVI
            // 
            vScrollBarResult_NVI.Location = new Point(253, 46);
            vScrollBarResult_NVI.Name = "vScrollBarResult_NVI";
            vScrollBarResult_NVI.Size = new Size(22, 380);
            vScrollBarResult_NVI.TabIndex = 2;
            vScrollBarResult_NVI.Scroll += vScrollBarResult_NVI_Scroll;
            // 
            // labelResult_NVI
            // 
            labelResult_NVI.AutoSize = true;
            labelResult_NVI.Location = new Point(6, 23);
            labelResult_NVI.Name = "labelResult_NVI";
            labelResult_NVI.Size = new Size(75, 20);
            labelResult_NVI.TabIndex = 1;
            labelResult_NVI.Text = "Результат";
            // 
            // textBoxResult_NVI
            // 
            textBoxResult_NVI.BorderStyle = BorderStyle.None;
            textBoxResult_NVI.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_NVI.Location = new Point(6, 46);
            textBoxResult_NVI.Multiline = true;
            textBoxResult_NVI.Name = "textBoxResult_NVI";
            textBoxResult_NVI.ReadOnly = true;
            textBoxResult_NVI.Size = new Size(269, 373);
            textBoxResult_NVI.TabIndex = 0;
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_NVI.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            buttonDone_NVI.FlatAppearance.BorderSize = 2;
            buttonDone_NVI.FlatStyle = FlatStyle.Flat;
            buttonDone_NVI.Location = new Point(456, 358);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(114, 88);
            buttonDone_NVI.TabIndex = 4;
            buttonDone_NVI.Text = "Выполнить";
            buttonDone_NVI.UseVisualStyleBackColor = false;
            buttonDone_NVI.Click += buttonDone_NVI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(buttonDone_NVI);
            Controls.Add(groupBoxResult_NVI);
            Controls.Add(groupBoxTask_NVi);
            Controls.Add(buttonHelp_NVI);
            Controls.Add(groupBoxData_NVI);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 3 | Носков В. И.";
            groupBoxData_NVI.ResumeLayout(false);
            groupBoxData_NVI.PerformLayout();
            groupBoxTask_NVi.ResumeLayout(false);
            groupBoxTask_NVi.PerformLayout();
            groupBoxResult_NVI.ResumeLayout(false);
            groupBoxResult_NVI.PerformLayout();
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
        private TextBox textBoxResult_NVI;
        private VScrollBar vScrollBarResult_NVI;
        private Label labelResult_NVI;
        private Button buttonDone_NVI;
    }
}
