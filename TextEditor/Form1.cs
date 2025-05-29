/*
* Copyright (c) 2025 London Sheard
*
* This software is released under the BSD 3-Clause License.
* See LICENSE file for details.
*/

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private bool hasUnsavedChanges = false;

        public Form1()
        {
            InitializeComponent();
            textBox.TextChanged += TextBox_TextChanged!;
            fileStatusLabel.Hide();
        }

        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            fileStatusLabel.Text = "*Unsaved changes to current file";
            if (textBox.Text != "")
            {
                fileStatusLabel.Show();
                hasUnsavedChanges = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = System.IO.File.ReadAllText(filePath);
                textBox.Text = fileContent;
                filePathLabel.Text = filePath;
                fileStatusLabel.Hide();
                hasUnsavedChanges = false;
            }
        }

        private void saveCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textBoxContent = textBox.Text;
            if (filePathLabel.Text != "")
            {
                string filePath = filePathLabel.Text;
                System.IO.File.WriteAllText(filePath, textBoxContent);
                fileStatusLabel.Hide();
                hasUnsavedChanges = false;
            }
            else
            {
                MessageBox.Show("No active file.");
            }
        }

        private void closeCurrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hasUnsavedChanges)
            {
                var result = MessageBox.Show(
                    "Unsaved Changes!\nDo you want to close active file anyway?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    fileStatusLabel.Text = "";
                    fileStatusLabel.Hide();
                    textBox.Text = "";
                    filePathLabel.Text = "";
                    hasUnsavedChanges = false;
                }
            }
            else
            {
                fileStatusLabel.Text = "";
                fileStatusLabel.Hide();
                textBox.Text = "";
                filePathLabel.Text = "";
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newFileName = saveFileDialog.FileName;
                string text = textBox.Text;
                System.IO.File.WriteAllText(newFileName, text);
                fileStatusLabel.Hide();
                hasUnsavedChanges = false;
                filePathLabel.Text = newFileName;
            }
            else
            {
                MessageBox.Show("Error saving as new file");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hasUnsavedChanges)
            {
                var result = MessageBox.Show(
                    "Unsaved Changes!\nDo you want to exit anyway?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form license = new LicenseForm();
            license.Show();
        }
    }
}
