﻿namespace Tyuiu.NoskovVI.Sprint6.Task6.V6
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_NVI = new PictureBox();
            labelInfo_NVI = new Label();
            buttonOk_NVI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_NVI).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_NVI
            // 
            pictureBoxAvatar_NVI.BackgroundImage = Properties.Resources.MyAvatar;
            pictureBoxAvatar_NVI.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar_NVI.Location = new Point(12, 43);
            pictureBoxAvatar_NVI.Name = "pictureBoxAvatar_NVI";
            pictureBoxAvatar_NVI.Size = new Size(136, 167);
            pictureBoxAvatar_NVI.TabIndex = 0;
            pictureBoxAvatar_NVI.TabStop = false;
            // 
            // labelInfo_NVI
            // 
            labelInfo_NVI.AutoSize = true;
            labelInfo_NVI.Location = new Point(171, 43);
            labelInfo_NVI.Name = "labelInfo_NVI";
            labelInfo_NVI.Size = new Size(387, 180);
            labelInfo_NVI.TabIndex = 1;
            labelInfo_NVI.Text = resources.GetString("labelInfo_NVI.Text");
            // 
            // buttonOk_NVI
            // 
            buttonOk_NVI.FlatStyle = FlatStyle.Flat;
            buttonOk_NVI.Location = new Point(496, 237);
            buttonOk_NVI.Name = "buttonOk_NVI";
            buttonOk_NVI.Size = new Size(94, 29);
            buttonOk_NVI.TabIndex = 2;
            buttonOk_NVI.Text = "ОК";
            buttonOk_NVI.UseVisualStyleBackColor = true;
            buttonOk_NVI.Click += buttonOk_NVI_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 278);
            Controls.Add(buttonOk_NVI);
            Controls.Add(labelInfo_NVI);
            Controls.Add(pictureBoxAvatar_NVI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_NVI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_NVI;
        private Label labelInfo_NVI;
        private Button buttonOk_NVI;
    }
}