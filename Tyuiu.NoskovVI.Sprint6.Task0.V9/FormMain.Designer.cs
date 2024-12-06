namespace Tyuiu.NoskovVI.Sprint6.Task0.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxInput_NVI = new GroupBox();
            textBoxForX_NVI = new TextBox();
            labelX_NVI = new Label();
            groupBoxOutput_NVI = new GroupBox();
            labelResult_NVI = new Label();
            textBoxDone_NVI = new TextBox();
            buttonDone_NVI = new Button();
            groupBoxTask_NVI = new GroupBox();
            textBoxTask_NVI = new TextBox();
            pictureBoxTask_NVI = new PictureBox();
            buttonHelp_NVI = new Button();
            groupBoxInput_NVI.SuspendLayout();
            groupBoxOutput_NVI.SuspendLayout();
            groupBoxTask_NVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_NVI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInput_NVI
            // 
            groupBoxInput_NVI.Controls.Add(textBoxForX_NVI);
            groupBoxInput_NVI.Controls.Add(labelX_NVI);
            groupBoxInput_NVI.Font = new Font("Leelawadee UI", 9F);
            groupBoxInput_NVI.Location = new Point(19, 185);
            groupBoxInput_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxInput_NVI.Name = "groupBoxInput_NVI";
            groupBoxInput_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxInput_NVI.Size = new Size(263, 101);
            groupBoxInput_NVI.TabIndex = 0;
            groupBoxInput_NVI.TabStop = false;
            groupBoxInput_NVI.Text = "Ввод данных";
            // 
            // textBoxForX_NVI
            // 
            textBoxForX_NVI.Location = new Point(18, 53);
            textBoxForX_NVI.Margin = new Padding(3, 2, 3, 2);
            textBoxForX_NVI.Name = "textBoxForX_NVI";
            textBoxForX_NVI.Size = new Size(110, 23);
            textBoxForX_NVI.TabIndex = 1;
            textBoxForX_NVI.KeyPress += textBoxForX_NVI_KeyPress;
            // 
            // labelX_NVI
            // 
            labelX_NVI.AutoSize = true;
            labelX_NVI.Font = new Font("Leelawadee UI", 9F);
            labelX_NVI.Location = new Point(18, 36);
            labelX_NVI.Name = "labelX_NVI";
            labelX_NVI.Size = new Size(91, 15);
            labelX_NVI.TabIndex = 0;
            labelX_NVI.Text = "Переменная X";
            // 
            // groupBoxOutput_NVI
            // 
            groupBoxOutput_NVI.Controls.Add(labelResult_NVI);
            groupBoxOutput_NVI.Controls.Add(textBoxDone_NVI);
            groupBoxOutput_NVI.Font = new Font("Leelawadee UI", 9F);
            groupBoxOutput_NVI.Location = new Point(301, 185);
            groupBoxOutput_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxOutput_NVI.Name = "groupBoxOutput_NVI";
            groupBoxOutput_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxOutput_NVI.Size = new Size(159, 101);
            groupBoxOutput_NVI.TabIndex = 1;
            groupBoxOutput_NVI.TabStop = false;
            groupBoxOutput_NVI.Text = "Вывод данных";
            // 
            // labelResult_NVI
            // 
            labelResult_NVI.AutoSize = true;
            labelResult_NVI.Font = new Font("Leelawadee UI", 9F);
            labelResult_NVI.Location = new Point(18, 35);
            labelResult_NVI.Name = "labelResult_NVI";
            labelResult_NVI.Size = new Size(68, 15);
            labelResult_NVI.TabIndex = 3;
            labelResult_NVI.Text = "Результат";
            // 
            // textBoxDone_NVI
            // 
            textBoxDone_NVI.BorderStyle = BorderStyle.None;
            textBoxDone_NVI.Location = new Point(18, 53);
            textBoxDone_NVI.Name = "textBoxDone_NVI";
            textBoxDone_NVI.ReadOnly = true;
            textBoxDone_NVI.Size = new Size(110, 16);
            textBoxDone_NVI.TabIndex = 0;
            // 
            // buttonDone_NVI
            // 
            buttonDone_NVI.Font = new Font("Leelawadee UI", 9F);
            buttonDone_NVI.Location = new Point(411, 291);
            buttonDone_NVI.Margin = new Padding(3, 2, 3, 2);
            buttonDone_NVI.Name = "buttonDone_NVI";
            buttonDone_NVI.Size = new Size(110, 38);
            buttonDone_NVI.TabIndex = 2;
            buttonDone_NVI.Text = "Выполнить";
            buttonDone_NVI.UseVisualStyleBackColor = true;
            buttonDone_NVI.Click += buttonDone_NVI_Click;
            // 
            // groupBoxTask_NVI
            // 
            groupBoxTask_NVI.Controls.Add(textBoxTask_NVI);
            groupBoxTask_NVI.Font = new Font("Leelawadee UI", 9F);
            groupBoxTask_NVI.Location = new Point(19, 11);
            groupBoxTask_NVI.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask_NVI.Name = "groupBoxTask_NVI";
            groupBoxTask_NVI.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask_NVI.Size = new Size(410, 170);
            groupBoxTask_NVI.TabIndex = 3;
            groupBoxTask_NVI.TabStop = false;
            groupBoxTask_NVI.Text = "Условие";
            // 
            // textBoxTask_NVI
            // 
            textBoxTask_NVI.BorderStyle = BorderStyle.None;
            textBoxTask_NVI.Font = new Font("Leelawadee UI", 9F);
            textBoxTask_NVI.Location = new Point(18, 21);
            textBoxTask_NVI.Name = "textBoxTask_NVI";
            textBoxTask_NVI.ReadOnly = true;
            textBoxTask_NVI.Size = new Size(376, 16);
            textBoxTask_NVI.TabIndex = 1;
            textBoxTask_NVI.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxTask_NVI
            // 
            pictureBoxTask_NVI.Image = (Image)resources.GetObject("pictureBoxTask_NVI.Image");
            pictureBoxTask_NVI.Location = new Point(435, 32);
            pictureBoxTask_NVI.Name = "pictureBoxTask_NVI";
            pictureBoxTask_NVI.Size = new Size(98, 61);
            pictureBoxTask_NVI.TabIndex = 4;
            pictureBoxTask_NVI.TabStop = false;
            // 
            // buttonHelp_NVI
            // 
            buttonHelp_NVI.FlatStyle = FlatStyle.Flat;
            buttonHelp_NVI.Location = new Point(363, 291);
            buttonHelp_NVI.Name = "buttonHelp_NVI";
            buttonHelp_NVI.Size = new Size(42, 38);
            buttonHelp_NVI.TabIndex = 5;
            buttonHelp_NVI.Text = "?";
            buttonHelp_NVI.UseVisualStyleBackColor = true;
            buttonHelp_NVI.Click += buttonHelp_NVI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 338);
            Controls.Add(buttonHelp_NVI);
            Controls.Add(pictureBoxTask_NVI);
            Controls.Add(groupBoxTask_NVI);
            Controls.Add(buttonDone_NVI);
            Controls.Add(groupBoxOutput_NVI);
            Controls.Add(groupBoxInput_NVI);
            Font = new Font("Leelawadee UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Носков В. И.";
            groupBoxInput_NVI.ResumeLayout(false);
            groupBoxInput_NVI.PerformLayout();
            groupBoxOutput_NVI.ResumeLayout(false);
            groupBoxOutput_NVI.PerformLayout();
            groupBoxTask_NVI.ResumeLayout(false);
            groupBoxTask_NVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_NVI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInput_NVI;
        private Label labelX_NVI;
        private TextBox textBoxForX_NVI;
        private GroupBox groupBoxOutput_NVI;
        private Button buttonDone_NVI;
        private TextBox textBoxDone_NVI;
        private Label labelResult_NVI;
        private GroupBox groupBoxTask_NVI;
        private TextBox textBoxTask_NVI;
        private PictureBox pictureBoxTask_NVI;
        private Button buttonHelp_NVI;
    }
}
