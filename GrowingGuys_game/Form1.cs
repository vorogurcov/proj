using GrowingGuys_game.Properties;
using System.Net.NetworkInformation;

namespace GrowingGuys_game
{
    public partial class MainForm : Form
    {
        static int isPressed = 0;
        static bool isSoloMode = false;
        static bool isInGame = false;
        static int playerOneScore = 0;
        static int playerTwoScore = 0;
        static bool isFirstPlayerTurn = true;
        public MainForm()
        {
            InitializeComponent();

        }
        public void HideAll()
        {
            foreach (Control control in this.Controls)
            {
                if (control.ToString() != "MenuStrip" &&
                    control.ToString() != "ToolStrip" &&
                    control.ToString() != "ContextMenuStrip"
                    && control.Name != "pictureRuler")
                {
                    if (isInGame && control.Name != "picturePlayerOne" && control.Name != "picturePlayerTwo" &&
                        control.Name != "playerText" && control.Name != "playerOneSc" && control.Name != "playerTwoSc"
                       )
                    {
                        control.Enabled = false;
                        control.Visible = false;
                    }
                    else if (!isInGame)
                    {
                        control.Enabled = false;
                        control.Visible = false;
                    }



                }
            }

        }
        public void ShowAll()
        {
            foreach (Control control in this.Controls)
            {
                if (control.ToString() != "MenuStrip" &&
                   control.ToString() != "ToolStrip" &&
                   control.ToString() != "ContextMenuStrip"
                   && control.Name != "pictureRuler")
                {
                    if (isInGame && (control.Name == "buttonOnePlayer" || control.Name == "buttonTwoPlayers"))
                    {
                        control.Enabled = true;
                        control.Visible = true;
                    }
                    else if (isInGame)
                    {
                        control.Enabled = false;
                        control.Visible = false;
                    }
                }
            }
        }



        public void ShowDice()
        {
            Random rnd = new Random();
            int res = rnd.Next(1, 7);
            if (!isFirstPlayerTurn || isSoloMode)
                playerOneSc.Text = (playerOneScore += res).ToString();
            else if (!isSoloMode)
                playerTwoSc.Text = (playerTwoScore += res).ToString();
            switch (res)
            {
                case 1:
                    diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice1.png");
                    break;
                case 2:
                    diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice2.png");
                    break;
                case 3:
                    diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice3.png");
                    break;
                case 4:
                    diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice4.png");
                    break;
                case 5:
                    diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice5.png");
                    break;
                case 6:
                    diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice6.png");
                    break;
            }
            TurnOnControl(buttonOK);
        }
        private void buttonOnePlayer_Click(object sender, EventArgs e)
        {
            if (isPressed == 0)
            {
                buttonPlay.Image =
               new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\play.png");
                isSoloMode = true;
                InvokeChooseScreen();
                isPressed = 1;

            }
            else if (isPressed == 1)
            {
                picturePlayerOne.BackColor = Color.DeepSkyBlue;
                isPressed = 2;
                picturePlayerOne.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\boy1.png");

                if (isSoloMode)
                {

                    HideAll();


                  

                    TurnOnControl(playerText);
                    TurnOnControl(buttonPlay);
                    TurnOnControl(playerOneSc);
                    TurnOnControl(picturePlayerOne);
                    isPressed = 0;
                    isSoloMode = true;
                    isInGame = true;
                }
            }
            else if (isPressed == 2)
            {

                picturePlayerTwo.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\boy2.png");
                HideAll();
                picturePlayerTwo.BackColor = Color.DeepSkyBlue;

              
                TurnOnControl(buttonPlay);
                TurnOnControl(playerText);
                TurnOnControl(playerOneSc);
                TurnOnControl(playerTwoSc);
                TurnOnControl(picturePlayerOne);
                TurnOnControl(picturePlayerTwo);
                isPressed = 0;
                isSoloMode = false;
                isInGame = true;
            }

        }
        private void InvokeChooseScreen()
        {
            // TODO: Load Boy / Girl image
            buttonOnePlayer.BackgroundImage = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\BOY.png");
            buttonOnePlayer.Text = "Мальчик";

            buttonTwoPlayers.BackgroundImage = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\GIRL.png");
            buttonTwoPlayers.Text = "Девочка";


        }

        private void buttonTwoPlayers_Click(object sender, EventArgs e)
        {

            if (isPressed == 0)
            {
                buttonPlay.Image =
               new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\play.png");
                isSoloMode = false;
                InvokeChooseScreen();
                isPressed = 1;


            }
            else if (isPressed == 1)
            {
                picturePlayerOne.BackColor = Color.Pink;
                picturePlayerOne.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\girl1.png");
                if (!isSoloMode)
                {

                    InvokeChooseScreen();
                    isPressed = 2;
                }
                else
                {
                    HideAll();

                    TurnOnControl(playerText);
                    TurnOnControl(buttonPlay);
                    TurnOnControl(playerOneSc);
                    TurnOnControl(picturePlayerOne);


                    isInGame = true;
                    isPressed = 0;
                    isSoloMode = true;
                }

            }
            else if (isPressed == 2)
            {

                picturePlayerTwo.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\girl2.png");
                HideAll();
                picturePlayerTwo.BackColor = Color.Pink;



                TurnOnControl(buttonPlay);
                TurnOnControl(playerText);
                TurnOnControl(playerOneSc);
                TurnOnControl(playerTwoSc);
                TurnOnControl(picturePlayerOne);
                TurnOnControl(picturePlayerTwo);
                isPressed = 0;
                isSoloMode = false;
                isInGame = true;
            }
        }

        void TurnOnControl(Control cont)
        {
            cont.Enabled = true;
            cont.Visible = true;
        }
        void TurnOffControl(Control cont)
        {
            cont.Enabled = false;
            cont.Visible = false;
        }

        private async void buttonPlay_Click(object sender, EventArgs e)
        {

            if (playerOneScore < 30 && playerTwoScore < 30)
            {
                if (isFirstPlayerTurn || isSoloMode)
                {
                    isFirstPlayerTurn = false;
                    playerText.Text = "Бросок Игрока 1!";
                }
                else if (!isSoloMode)
                {
                    isFirstPlayerTurn = true;
                    playerText.Text = "Бросок Игрока 2!";
                }
                TurnOnControl(pictureRuler);
                TurnOffControl(buttonPlay);

                diceCube.Image = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\dice.gif");
                Random rnd = new Random();
                TurnOnControl(diceCube);
                await Task.Delay(rnd.Next(500, 1800));
                ShowDice();


            }
            else
            {
                buttonPlay.Image =
                    new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\play.jpg");

                buttonPlay.FlatStyle = FlatStyle.Flat;
                buttonPlay.FlatAppearance.BorderSize = 5;
                buttonPlay.Text = "Победа Игрока " + ((playerOneScore > playerTwoScore) ? "1" : "2");

                playerText.Enabled = true;
                playerText.Text = "Нажми, чтобы выйти в меню :)";
            }
        }

        static int firstChangedSize = 0;

        static int secondChangedSize = 0;
        private void ChangePlayerSize(int score, PictureBox player)
        {
            double WidthCoef = 1.15;
            double HeighCoef = 1.2;
            if (score >= 10 && score < 20 && ((firstChangedSize == 0 && player.Name == "picturePlayerOne")
                || (secondChangedSize == 0 && player.Name == "picturePlayerTwo")))
            {
                player.Size = new Size((int)(player.Width * WidthCoef), (int)(player.Height * HeighCoef));
                if (player.Name == "picturePlayerOne")
                    firstChangedSize = 1;
                else
                    secondChangedSize = 1;
            }
            else if (score >= 20 && score < 30 && ((firstChangedSize == 1 && player.Name == "picturePlayerOne")
                || (secondChangedSize == 1 && player.Name == "picturePlayerTwo")))
            {
                player.Size = new Size((int)(player.Width * WidthCoef), (int)(player.Height * HeighCoef));
                if (player.Name == "picturePlayerOne")
                    firstChangedSize = 2;
                else
                    secondChangedSize = 2;
            }
            else if (score >= 30 && ((firstChangedSize == 2 && player.Name == "picturePlayerOne")
                || (secondChangedSize == 2 && player.Name == "picturePlayerTwo")))
            {
                player.Size = new Size((int)(player.Width * WidthCoef), (int)(player.Height * HeighCoef));
                if (player.Name == "picturePlayerOne")
                    firstChangedSize = 3;
                else
                    secondChangedSize = 3;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChangePlayerSize(playerOneScore, picturePlayerOne);
            ChangePlayerSize(playerTwoScore, picturePlayerTwo);
            HideAll();
            TurnOnControl(buttonPlay);
            buttonPlay.Image =
                 new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\play.png");
        }

        void ChangeToStartPos()
        {
            buttonOnePlayer.Location = new Point(102, 165);
            buttonOnePlayer.Size = new Size(250, 330);

            buttonTwoPlayers.Location = new Point(698, 165);
            buttonTwoPlayers.Size = new Size(250, 330);

            buttonOK.Location = new Point(466, 336);
            buttonOK.Size = new Size(131, 52);

            diceCube.Location = new Point(390, 122);
            diceCube.Size = new Size(284, 207);
            diceCube.BackgroundImage = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\rnb3.jpg");

            buttonPlay.Location = new Point(307, 383);
            buttonPlay.Size = new Size(439, 130);
            ///////////////////////////////////
            ///
            picturePlayerTwo.Size = new Size(119, 230);
            picturePlayerTwo.Location = new Point(829, 307);

            picturePlayerOne.Size = new Size(119, 230);
            picturePlayerOne.Location = new Point(114, 307);
            

            pictureRuler.Location = new Point(6, 95);
            pictureRuler.Size = new Size(178, 443);
            pictureRuler.BackgroundImage =
                new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\tree1.jpg");

            playerText.Location = new Point(390, 35);
            playerText.Size = new Size(286, 80);
            playerText.BackgroundImage =
                new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\text.jpg");
            playerTwoSc.Location = new Point(671, 46);
            playerTwoSc.Size = new Size(121, 59);
            playerTwoSc.BackgroundImage =
                        new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\but1.jpg");

            playerOneSc.Location = new Point(272, 43);
            playerOneSc.Size = new Size(121, 59);
            playerOneSc.BackgroundImage =
                        new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\but2.jpg");
        }
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void MainForm_Resize(object sender, EventArgs e)
        {

            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {

                    // Maximized!
                    buttonOnePlayer.Location = new Point((int)(102 * 1.9), (int)(165 * 5.0 / 3.0));
                    buttonOnePlayer.Size = new Size(500, 599);

                    buttonTwoPlayers.Location = new Point((int)(698 * 1.75), (int)(165 * 5.0 / 3.0));
                    buttonTwoPlayers.Size = new Size(500, 599);

                    buttonOK.Location = new Point((int)(466 * 1.8), (int)(336 * 5.5 / 3.0));
                    buttonOK.Size = new Size(230, 71);

                    diceCube.Location = new Point((int)(390 * 1.82), (int)(124 * 5.0 / 3.0));
                    diceCube.Size = new Size(500, 380);
                    diceCube.BackgroundImage = new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\rnb2.jpg");

                    buttonPlay.Location = new Point((int)(307 * 2.4), (int)(383 * 5.0 / 3.0));
                    //////////////////////////////////////
                    picturePlayerTwo.Location = new Point((int)(829 * 1.9), (int)(307 * 8.0 / 3.0));
                    picturePlayerTwo.Size = new Size(200, 400);


                    picturePlayerOne.Location = new Point((int)(114 * 1.9), (int)(307 * 8.0 / 3.0));
                    picturePlayerOne.Size = new Size(200, 400);

                    pictureRuler.Location = new Point((int)(2 * 1.9) - 2, (int)(94 / 2) - 18);
                    pictureRuler.Size = new Size(300, 900);
                    pictureRuler.BackgroundImage =
                       new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\measurement_2.jpg");

                    playerText.Location = new Point((int)(390 * 1.95), (int)(35 * 5.0 / 3.0) - 3);
                    playerText.Size = new Size(400, 120);
                    playerText.BackgroundImage =
                        new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\text2.jpg");

                    playerTwoSc.Location = new Point((int)(671 * 1.8), (int)(46 * 5.0 / 3.0));
                    playerTwoSc.Size = new Size(200, 100);
                    playerTwoSc.BackgroundImage =
                        new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\but2_2.jpg");

                    playerOneSc.Location = new Point((int)(272 * 1.9), (int)(43 * 5.0 / 3.0));
                    playerOneSc.Size = new Size(200, 100);
                    playerOneSc.BackgroundImage =
                        new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\but1_2.jpg");
                }
                if (WindowState == FormWindowState.Normal)
                {
                    ChangeToStartPos();

                    // Restored!
                }
            }

        }



        private void playerText_Click(object sender, EventArgs e)
        {
            ShowAll();
            TurnOffControl(pictureRuler);
            TurnOffControl(buttonOK);
            playerOneScore = 0;
            playerTwoScore = 0;
            playerOneSc.Text = "";
            playerTwoSc.Text = "";
            TurnOffControl(playerText);
            TurnOffControl(buttonPlay);
            buttonPlay.BackgroundImage =
                new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\dice_cube\\play.jpg");
            buttonPlay.FlatStyle = FlatStyle.Standard;
            buttonPlay.FlatAppearance.BorderSize = 1;
            buttonOnePlayer.BackgroundImage =
                new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\oneplayer.png");
            buttonOnePlayer.Text = "Один игрок";
            buttonTwoPlayers.BackgroundImage =
                new Bitmap("D:\\Projects\\c#\\GrowingGuys_game\\GrowingGuys_game\\children\\twoplayers.png");
            buttonTwoPlayers.Text = "Два игрока";
            isPressed = 0;
            isSoloMode = false;
            isInGame = false;
            isFirstPlayerTurn = true;
            playerText.Text = "";
            buttonPlay.Text = "";

            
            picturePlayerOne.Size = new Size(119, 230);
            picturePlayerTwo.Size = new Size(119, 230);

            picturePlayerOne.Location = new Point(114, 307);
            picturePlayerTwo.Location = new Point(829, 307);

            firstChangedSize = 0;
            secondChangedSize = 0;
            //ChangeToStartPos();
        }

       
    }
}
