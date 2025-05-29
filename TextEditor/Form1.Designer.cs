/*
* Copyright (c) 2025 London Sheard
*
* This software is released under the BSD 3-Clause License.
* See LICENSE file for details.
*/

namespace TextEditor
{
    partial class Form1
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
            textBox = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveCurrentToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeCurrentFileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            licenseToolStripMenuItem = new ToolStripMenuItem();
            filePathLabel = new Label();
            openFileDialog = new OpenFileDialog();
            fileStatusLabel = new Label();
            saveFileDialog = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(16, 48);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(800, 392);
            textBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(830, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeCurrentFileToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(163, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveCurrentToolStripMenuItem, saveAsToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(163, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveCurrentToolStripMenuItem
            // 
            saveCurrentToolStripMenuItem.Name = "saveCurrentToolStripMenuItem";
            saveCurrentToolStripMenuItem.Size = new Size(139, 22);
            saveCurrentToolStripMenuItem.Text = "Save current";
            saveCurrentToolStripMenuItem.Click += saveCurrentToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(139, 22);
            saveAsToolStripMenuItem.Text = "Save as new";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeCurrentFileToolStripMenuItem
            // 
            closeCurrentFileToolStripMenuItem.Name = "closeCurrentFileToolStripMenuItem";
            closeCurrentFileToolStripMenuItem.Size = new Size(163, 22);
            closeCurrentFileToolStripMenuItem.Text = "Close current file";
            closeCurrentFileToolStripMenuItem.Click += closeCurrentFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(163, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { licenseToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // licenseToolStripMenuItem
            // 
            licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            licenseToolStripMenuItem.Size = new Size(113, 22);
            licenseToolStripMenuItem.Text = "License";
            licenseToolStripMenuItem.Click += licenseToolStripMenuItem_Click;
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Location = new Point(24, 448);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(0, 15);
            filePathLabel.TabIndex = 2;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // fileStatusLabel
            // 
            fileStatusLabel.AutoSize = true;
            fileStatusLabel.Location = new Point(632, 448);
            fileStatusLabel.Name = "fileStatusLabel";
            fileStatusLabel.Size = new Size(0, 15);
            fileStatusLabel.TabIndex = 3;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 471);
            Controls.Add(fileStatusLabel);
            Controls.Add(filePathLabel);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "London's Text Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label filePathLabel;
        private ToolStripMenuItem saveToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem saveCurrentToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem closeCurrentFileToolStripMenuItem;
        private Label fileStatusLabel;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem licenseToolStripMenuItem;
    }
}
