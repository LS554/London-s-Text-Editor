namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            textBox.TextChanged += TextBox_TextChanged!;
        }

        private void TextBox_TextChanged(object? sender, EventArgs e) {
            fileStatusLabel.Text = "*Unsaved changes to current file";
            fileStatusLabel.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;
                string fileContent = System.IO.File.ReadAllText(filePath);
                textBox.Text = fileContent;
                filePathLabel.Text = filePath;
                fileStatusLabel.Hide();
            }
        }

        private void saveCurrentToolStripMenuItem_Click(object sender, EventArgs e) {
            string textBoxContent = textBox.Text;
            if (filePathLabel.Text != "") {
                string filePath = filePathLabel.Text;
                System.IO.File.WriteAllText(filePath, textBoxContent);
                fileStatusLabel.Hide();
            } else { 
                MessageBox.Show("No active file.");
            }
        }

        private void closeCurrentFileToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fileStatusLabel.Text == "*Unsaved changes to current file") {
                MessageBox.Show("Unsaved Changes!");
            } else {
                fileStatusLabel.Text = "";
                textBox.Text = "";
                filePathLabel.Text = "";
            }
        }
    }
}
