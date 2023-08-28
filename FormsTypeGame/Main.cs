namespace FormsTypeGame
{
    public partial class Main : Form
    {
        int Score = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCharacter.Text = GetRandomCharacter().ToString();
            gameTimer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        Random randomCharacter = new Random();
        private char GetRandomCharacter()
        {
            return (char)randomCharacter.Next(97, 123);

        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPressKey = e.KeyChar;
            if (lblCharacter.Text == userPressKey.ToString())
            {
                Score += 1;
                labelScore.Text = "Score " + Score;
                lblCharacter.Text = GetRandomCharacter().ToString();
            }
            else
            {
                // Do nothing
            }
        }
    }
}