namespace kotoba
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OfdImport.Filter = "Word Files (*.words)|*.words";
            if (OfdImport.ShowDialog() == DialogResult.OK)
            {
                string wordsPath = OfdImport.FileName;
                string meansPath = Path.ChangeExtension(wordsPath, ".means");

                if (!File.Exists(meansPath))
                {
                    MessageBox.Show("未找到对应的 .means 文件:\n" + meansPath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] words = File.ReadAllLines(wordsPath);
                string[] means = File.ReadAllLines(meansPath);

                if (words.Length != means.Length)
                {
                    MessageBox.Show($"单词数（{words.Length}）与释义数（{means.Length}）不一致，无法对应导入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DgvReview.Rows.Clear();

                int importCount = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i].Trim();
                    string mean = means[i].Trim();

                    if (!string.IsNullOrWhiteSpace(word) && !string.IsNullOrWhiteSpace(mean))
                    {
                        DgvReview.Rows.Add(word, mean);
                        importCount++;
                    }
                }

                // 获取文件名（不含路径和扩展名）
                string fileNameOnly = Path.GetFileNameWithoutExtension(wordsPath);
                this.Text = "kotoba [" + fileNameOnly + "]";
                MessageBox.Show($"导入成功！共导入 {importCount} 对单词-释义。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 开始默写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wordPairs = new List<WordPair>();

            foreach (DataGridViewRow row in DgvReview.Rows)
            {
                if (row.Cells["DgvReview_Words"].Value is string word &&
                    row.Cells["DgvReview_Means"].Value is string mean &&
                    !string.IsNullOrWhiteSpace(word) &&
                    !string.IsNullOrWhiteSpace(mean))
                {
                    wordPairs.Add(new WordPair(word.Trim(), mean.Trim()));
                }
            }

            if (wordPairs.Count == 0)
            {
                MessageBox.Show("当前没有可用于默写的单词。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  传入词库数据作为参数
            DictationForm testForm = new DictationForm(wordPairs);
            testForm.ShowDialog();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm testForm = new AboutForm();
            testForm.ShowDialog();
        }
    }
}
