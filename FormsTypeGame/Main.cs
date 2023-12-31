using TypingGameLibrary;

namespace FormsTypeGame
{
    public partial class mainForm : Form
    {
        int score = 0;
        int seconds = 30;
        int keyPressedCount = 0;
        int wordIndex = 0;
        string[] splitWords;
        List<char> charactersPressed = new List<char>();
        string wordFilePath = "C:\\src\\TypeGameApp\\TypingGameLibrary\\Words.txt";
        WordParsing wordParser = new WordParsing();
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string parsedWords = wordParser.ParseWords(wordFilePath);
            splitWords = parsedWords.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in splitWords)
            {
                characterLabel.Text += word + " ";
            }

            if (true)
            {

            }

            mainTextBox.Focus();
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
            if (e.KeyChar == (char)Keys.Space)
            {
                if (mainTextBox.Text == splitWords[wordIndex])
                {
                    scoreLabel.Text = $"Score {++score}";
                }
                wordIndex++;
                e.KeyChar = (char)0; // Erases loaded 'space' char
                mainTextBox.Text = "";
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}