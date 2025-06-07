using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kotoba
{
    public partial class FrmDictation : Form
    {
        private List<WordPair> _quizList;
        private int _currentIndex = 0;
        int result = 0;
        public FrmDictation(List<WordPair> allPairs)
        {
            this.AcceptButton = BtnCheck;
            InitializeComponent();
            // 抽取最多 20 个并打乱
            var rnd = new Random();
            _quizList = allPairs.OrderBy(x => rnd.Next()).Take(20).ToList();
            ShowCurrentQuestion();
        }
        private void ShowCurrentQuestion()
        {
            if (_currentIndex < _quizList.Count)
            {
                LblMeans.Text = _quizList[_currentIndex].Meaning;
                TxtWords.Text = "";
                LblResult.Text = $"第 {_currentIndex + 1} / {_quizList.Count} 题";
                TxtWords.Focus();
            }
            else
            {
                MessageBox.Show("默写完成！" + Convert.ToString(result) + "/" + Convert.ToString(_quizList.Count), "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblMeans.Text = "";
                TxtWords.Enabled = false;
                BtnCheck.Enabled = false;
                LblResult.Text = "完成！";
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= _quizList.Count)
                return;
            string userInput = TxtWords.Text.Trim();
            string correctAnswer = _quizList[_currentIndex].Word;
            if (string.Equals(userInput, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                LblResult.Text = "✅";
                result += 1;
            }
            else
            {
                LblResult.Text = $"❌ 正确答案是 {correctAnswer}";
            }

            _currentIndex++;
            // 延时 1 秒后进入下一题
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                ShowCurrentQuestion();
            };
            timer.Start();
        }
    }

    public class WordPair
    {
        public string Word { get; set; }
        public string Meaning { get; set; }

        public WordPair(string word, string meaning)
        {
            Word = word;
            Meaning = meaning;
        }
    }
}
