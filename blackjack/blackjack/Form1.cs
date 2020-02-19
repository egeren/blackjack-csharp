using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace blackjack
{
    public partial class mainForm : Form
    {

        bool playerTurn = false;
        byte howManyOpponent = 0;
        byte howManyPlayer = 0;
        byte opponentValue = 0;
        byte playerValue = 0;
        int speed;
        int speedY;
        double b = 3;
        int opponentPosX = 380;
        int opponentPosY = 0;
        int targetPosX;
        int playerPosX = 380;
        int playerPosY = 350;
        PictureBox playerCard;
        List<PictureBox> existingCards = new List<PictureBox>();
        List<PictureBox> opponentCards = new List<PictureBox>();
        List<PictureBox> playerCards = new List<PictureBox>();
        string[] cards =
            {   // value-Color-Type example: JokerRedHeart
                "aRed1", "2Red1", "3Red1", "4Red1", "5Red1", "6Red1", "7Red1", "8Red1", "9Red1", "10Red1", "jRed1", "qRed1", "kRed1",
                "aRed2", "2Red2", "3Red2", "4Red2", "5Red2", "6Red2", "7Red2", "8Red2", "9Red2", "10Red2", "jRed2", "qRed2", "kRed2",
                "aBlack3", "2Black3", "3Black3", "4Black3", "5Black3", "6Black3", "7Black3", "8Black3", "9Black3", "10Black3", "jBlack3", "qBlack3", "kBlack3",
                "aBlack4", "2Black4", "3Black4", "4Black4", "5Black4", "6Black4", "7Black4", "8Black4", "9Black4", "10Black4", "jBlack4", "qBlack4", "kBlack4"
            };

        public mainForm()
        {
            InitializeComponent();
        }
        public void initGame()
        {
            // Initializing & Preparing Game...
            logo.Visible = false;
            playButton.Visible = false;
            card.Location = new Point(830, 170);
            card.BackgroundImage = blackjack.Properties.Resources.cardBack;
            card.Visible = true;
            playerTurn = false;
            howManyOpponent = 0;
            howManyPlayer = 0;
            opponentValue = 0;
            playerValue = 0;
            timerCheck.Tag = "start";
            timerCheck.Enabled = true;
            sendCard("opponent");
        }

        public void createCard(string who)
        {
            Random choose = new Random();
            playerCard = new PictureBox();
            this.Controls.Add(playerCard);
            playerCard.Location = card.Location;
            playerCard.Size = card.Size;
            playerCard.BackColor = Color.Transparent;
            playerCard.BackgroundImage = card.BackgroundImage;
            playerCard.BackgroundImageLayout = card.BackgroundImageLayout;
            playerCard.Visible = true;
            playerCard.Tag = cards[choose.Next(0,cards.Length)];
            existingCards.Add(playerCard);
            if (who == "opponent")
                opponentCards.Add(playerCard);
            else
                playerCards.Add(playerCard);
            playerCard.BringToFront();
        }

        public void sendCard(string who)
        {
            hitButton.Visible = false;
            standButton.Visible = false;
            createCard(who);
            calculateSpeed(who);
            animation.Tag = who;
            animation.Enabled = true;
            timerCheck.Enabled = true;
            if (who == "opponent")
            {
                howManyOpponent++;
                playerTurn = true;
            }
            else if (who == "player")
            {
                howManyPlayer++;
                playerTurn = false;
            }
        }

        void calculateSpeed(string who)
        {
            if (who == "opponent")
            {
                targetPosX = opponentPosX + (howManyOpponent * 30);
                speed = (playerCard.Location.X - targetPosX) / 10;
                speedY = (playerCard.Location.Y - opponentPosY) / 10;
            }
            else if (who == "player")
            {
                targetPosX = playerPosX + (howManyPlayer * 30);
                speed = (playerCard.Location.X - targetPosX) / 10;
                speedY = (playerCard.Location.Y - playerPosY) / 10;
            }
        }

        int OBEB(int x, int y)
        {
            if (x >= y)
            {
                for (int i = y; ; i--)
                {
                    if (x % i == 0 && y % i == 0)
                    {
                        MessageBox.Show(i.ToString());
                        return i;
                    }
                }
            }
            else
            {
                for (int i = y; y != 0; i--)
                {
                    if (x % i == 0)
                    {
                        MessageBox.Show(i.ToString());
                        return i;
                    }
                }
            }
            return 0;
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            initGame();
        }

        void animatiosn()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void animation_Tick(object sender, EventArgs e)
        {
            playerCard.Location = new Point(playerCard.Location.X - speed, playerCard.Location.Y - speedY);

            if (playerCard.Location.X == targetPosX)
            {
                animation.Enabled = false;
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (animation.Enabled == true)
            {
            }
            else
            {
                timerCheck.Enabled = false;
                if (howManyPlayer == 2)
                {
                    timerCheck.Enabled = false;
                    showCard(true);
                    calculate();
                    play();
                }
                else
                {
                    if (playerTurn)
                    {
                        sendCard("player");
                    }
                    else
                    {
                        sendCard("opponent");
                    }
                }
            }
        }
        void showCard(bool firstTime)
        {
            if(firstTime)
            {
                opponentCards[0].BackgroundImage = blackjack.Properties.Resources.getImage(opponentCards[0].Tag.ToString());
                foreach (PictureBox i in playerCards)
                {
                    i.BackgroundImage = blackjack.Properties.Resources.getImage(i.Tag.ToString());
                }
            }
            else
            {
                playerCards[playerCards.Count].BackgroundImage = blackjack.Properties.Resources.getImage(opponentCards[0].Tag.ToString());
            }
        }

        void calculate()
        {
            string value;
            playerValue = 0;
            opponentValue = 0;
            foreach (PictureBox i in opponentCards)
            {
                
                value = i.Tag.ToString()[0].ToString();
                if (value == "j" || value == "q" || value == "k")
                {
                    opponentValue += 10;
                }
                else if (value == "a")
                {
                    if(opponentValue + 11 < 21)
                    {
                        opponentValue += 11;
                    }
                    else
                    {
                        opponentValue += 1;
                    }
                }
                else
                {
                    opponentValue += Convert.ToByte(value);
                }
                
            }
            foreach (PictureBox i in playerCards)
            {
                
                value = i.Tag.ToString()[0].ToString();
                if (value == "j" || value == "q" || value == "k")
                {
                    playerValue += 10;
                }
                else if (value == "a")
                {
                    if (playerValue + 11 < 21)
                    {
                        playerValue += 11;
                    }
                    else
                    {
                        playerValue += 1;
                    }
                }
                else
                {
                    playerValue += Convert.ToByte(value);
                }
                MessageBox.Show(playerValue.ToString());
            }
            playerLabel.Text = playerValue.ToString();
        }  // calculates everytime fix this!!
        void play()
        {
            hitButton.Visible = true;
            standButton.Visible = true;
            hitLabel.Visible = true;
            standLabel.Visible = true;
            playerLabel.Visible = true;
        }
        private void hitButton_Click(object sender, EventArgs e)
        {
            sendCard("player");
        }

        private void standButton_Click(object sender, EventArgs e)
        {

        }

    }
}