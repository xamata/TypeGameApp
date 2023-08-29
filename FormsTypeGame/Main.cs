using TypingGameLibrary;

namespace FormsTypeGame
{
    public partial class Main : Form
    {
        int score = 0;
        int seconds = 30;
        string wordFilePath = "C:\\src\\TypeGameApp\\TypingGameLibrary\\Words.txt";
        string parsedWords;
        WordParsing wordParser;
        public Main()
        {
            InitializeComponent();
            wordParser = new WordParsing();
            parsedWords = wordParser.ParseWords(wordFilePath);
            labelTest.Text = parsedWords.Length.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCharacter.Text = wordParser.ParseWords(wordFilePath);
            

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
            if(seconds == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("The form will now be closed.", "Time Elapsed");
                Close();
            }
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < parsedWords.Length; i++)
            {
                char userPressKey = e.KeyChar;
                labelTest.Text = e.KeyChar.ToString();
                if (lblCharacter.Text[i] == userPressKey)
                {
                    score += 1;
                    labelScore.Text = "Score " + score;
                }
                else
                {
                    // Do nothing
                }

            }
        }
    }
}