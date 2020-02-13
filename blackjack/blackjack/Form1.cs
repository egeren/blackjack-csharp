using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class mainForm : Form
    {
        bool opponentSent = false;
        byte opponentCount = 0;
        byte playerCount = 0;
        int speed = 2;
        int speedY = 0;
        double b = 3f;
        int opponentPosX = 380;
        int opponentPosY = 10;
        int playerPosX = 0;
        int playerPosY = 0;
        PictureBox playerCard;
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
            opponentSent = false;
            opponentCount = 0;
            playerCount = 0;
            string[] cards =
            {   // value-Color-Type example: JokerRedHeart
                "aRed1", "2Red1", "3Red1", "4Red1", "5Red1", "6Red1", "7Red1", "8Red1", "9Red1", "10Red1", "jRed1", "qRed1", "kRed1",
                "aRed2", "2Red2", "3Red2", "4Red2", "5Red2", "6Red2", "7Red2", "8Red2", "9Red2", "10Red2", "jRed2", "qRed2", "kRed2",
                "aBlack3", "2Black3", "3Black3", "4Black3", "5Black3", "6Black3", "7Black3", "8Black3", "9Black3", "10Black3", "jBlack3", "qBlack3", "kBlack3",
                "aBlack4", "2Black4", "3Black4", "4Black4", "5Black4", "6Black4", "7Black4", "8Black4", "9Black4", "10Black4", "jBlack4", "qBlack4", "kBlack4"
            };
            
        }

        public void createCard()
        {
            playerCard = new PictureBox();
            this.Controls.Add(playerCard);
            playerCard.Location = card.Location;
            playerCard.Size = card.Size;
            playerCard.BackColor = Color.Transparent;
            playerCard.BackgroundImage = card.BackgroundImage;
            playerCard.BackgroundImageLayout = card.BackgroundImageLayout;
            playerCard.Visible = true;
            playerCard.BringToFront();

            sendToOpponent();
            
        }
        public void sendToOpponent()
        { // location 380 10
            if (!animation.Enabled)
            {
                speed = calculateSpeed(true)/10;
            }

            if (playerCard.Location.Y >= 10)
            {
                animation.Enabled = true;
            }
            else
            {
                animation.Enabled = false;
            }
        }
        int calculateSpeed(bool isOpponent)
        {
            if (isOpponent)
            {
                return (opponentPosX / OBEB(playerCard.Location.X, playerCard.Location.Y));
            }
            return 0;
        }

        int OBEB(int x, int y)
        {
            if(x >= y)
            {
                for(int i= y;;i--)
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

        private void debug_Click(object sender, EventArgs e)
        {
            createCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void animation_Tick(object sender, EventArgs e)
        {
            if(animation.Tag.ToString() == "opponent")
            {
                playerCard.Location = new Point(playerCard.Location.X-44,playerCard.Location.Y-16);
                sendToOpponent();
            }
            else if(animation.Tag.ToString() == "opponentX")
            {
                //playerCard.Location = new Point(playerCard.Location.X-animSpeed, playerCard.Location.Y);
                sendToOpponent();
            }
        }
    }
}
