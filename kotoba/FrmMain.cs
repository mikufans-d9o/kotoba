namespace kotoba
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Ms_Import_Click(object sender, EventArgs e)
        {
            OfdImport.Filter = "Word Files (*.words)|*.words";
            if (OfdImport.ShowDialog() == DialogResult.OK)
            {
                string wordsPath = OfdImport.FileName;
                string meansPath = Path.ChangeExtension(wordsPath, ".means");

                if (!File.Exists(meansPath))
                {
                    MessageBox.Show("δ�ҵ���Ӧ�� .means �ļ�:\n" + meansPath, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] words = File.ReadAllLines(wordsPath);
                string[] means = File.ReadAllLines(meansPath);

                if (words.Length != means.Length)
                {
                    MessageBox.Show($"��������{words.Length}������������{means.Length}����һ�£��޷���Ӧ���룡", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // ��ȡ�ļ���������·������չ����
                string fileNameOnly = Path.GetFileNameWithoutExtension(wordsPath);
                this.Text = "kotoba [" + fileNameOnly + "]";
                MessageBox.Show($"����ɹ��������� {importCount} �Ե���-���塣", "�ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ms_Check_Click(object sender, EventArgs e)
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
                MessageBox.Show("��ǰû�п�����Ĭд�ĵ��ʡ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  ����ʿ�������Ϊ����
            FrmDictation testForm = new FrmDictation(wordPairs);
            testForm.ShowDialog();
        }

        private void Ms_About_Click(object sender, EventArgs e)
        {
            FrmAbout testForm = new FrmAbout();
            testForm.ShowDialog();
        }
    }
}