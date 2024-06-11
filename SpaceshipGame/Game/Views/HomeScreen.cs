using SpaceshipGame.Game.Views;

namespace SpaceshipGame
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Btn_Jogar_Click(object sender, EventArgs e)
        {
            Hide();
            GameScreen gameScreen = new();
            gameScreen.Show();
            gameScreen.FormClosed += (s, args) => Show();
        }

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            Hide();
            HelpScreen helpScreen = new();
            helpScreen.Show();
            helpScreen.FormClosed += (s, args) => Show();
        }
    }
}
