using TypingGameLibrary;

namespace FormsTypeGame
{
    public partial class mainForm : Form
    {
        int score = 0;
        int seconds = 30;
        int keyPressedCount = 0;
        List<char> chars = new List<char>();
        string wordFilePath = "C:\\src\\TypeGameApp\\TypingGameLibrary\\Words.txt";
        string parsedWords;
        WordParsing wordParser;
        public mainForm()
        {
            InitializeComponent();
            wordParser = new WordParsing();
            parsedWords = wordParser.ParseWords(wordFilePath);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            characterLabel.Text = wordParser.ParseWords(wordFilePath);

            //gameTimer.Interval = (10 * 1000); // 10 seconds
            gameTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = $"00:{seconds--}";
            if (seconds == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("The form will now be closed.", "Time Elapsed");
                Close();
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            var enteredKey = e.KeyChar;

            chars.Add(enteredKey);

            testLabel.Text = new string(chars.ToArray());

            if (enteredKey == testLabel.Text[keyPressedCount])
            {
                scoreLabel.Text = $"Score: {++score}";
            }
            keyPressedCount++;
        }
    }
}