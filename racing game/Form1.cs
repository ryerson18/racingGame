using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace racing_game
{
    public partial class Form1 : Form
    {
        string state = "waiting";

        //player 1
        Rectangle Car1;
        //player 2
        Rectangle Car2;

        //colour
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        //track Pen
        Pen WhitePen = new Pen(Color.WhiteSmoke, 5);

        // list of track limits
        List<Rectangle> tracklimitsList = new List<Rectangle>();

        // track 1
        // check ponits 
        Rectangle check1 = new Rectangle(490, 88, 5, 190);
        Rectangle check2 = new Rectangle(760, 390, 210, 5);
        Rectangle check3 = new Rectangle(500, 525, 5, 175);
        Rectangle check4 = new Rectangle(7, 390, 210, 5);
        Rectangle redCheck = new Rectangle(540, 88, 5, 190);

        bool car1Check1 = false;
        bool car1Check2 = false;
        bool car1Check3 = false;
        bool car1Check4 = false;
        bool car1redCheck = false;

        bool car2Check1 = false;
        bool car2Check2 = false;
        bool car2Check3 = false;
        bool car2Check4 = false;
        bool car2redCheck = false;

        // track 2
        // check ponits 
        Rectangle track2check1 = new Rectangle(480, 30, 7, 100);
        Rectangle track2redCheck = new Rectangle(530, 30, 7, 100);
        Rectangle track2check2 = new Rectangle(790, 30, 7, 100);
        Rectangle track2check3 = new Rectangle(865, 175, 100, 7);
        Rectangle track2check4 = new Rectangle(865, 540, 100, 7);
        Rectangle track2check5 = new Rectangle(790, 613, 7, 60);
        Rectangle track2check6 = new Rectangle(175, 613, 7, 60);
        Rectangle track2check7 = new Rectangle(15, 555, 80, 7);
        Rectangle track2check8 = new Rectangle(15, 395, 80, 7);
        Rectangle track2check9 = new Rectangle(175, 225, 7, 100);
        Rectangle track2check10 = new Rectangle(253, 395, 80, 7);
        Rectangle track2check11 = new Rectangle(450, 525, 7, 80);
        Rectangle track2check12 = new Rectangle(575, 450, 125, 7);
        Rectangle track2check13 = new Rectangle(575, 290, 120, 7);
        Rectangle track2check14 = new Rectangle(485, 150, 7, 70);
        Rectangle track2check15 = new Rectangle(125, 147, 7, 73);
        Rectangle track2check16 = new Rectangle(125, 33, 7, 105);
        //car 1 check
        bool track2car1Check1 = false;
        bool track2car1Check2 = false;
        bool track2car1Check3 = false;
        bool track2car1Check4 = false;
        bool track2car1Check5 = false;
        bool track2car1Check6 = false;
        bool track2car1Check7 = false;
        bool track2car1Check8 = false;
        bool track2car1Check9 = false;
        bool track2car1Check10 = false;
        bool track2car1Check11 = false;
        bool track2car1Check12 = false;
        bool track2car1Check13 = false;
        bool track2car1Check14 = false;
        bool track2car1Check15 = false;
        bool track2car1Check16 = false;
        bool track2car1redCheck = false;
        //car 2 check
        bool track2car2Check1 = false;
        bool track2car2Check2 = false;
        bool track2car2Check3 = false;
        bool track2car2Check4 = false;
        bool track2car2Check5 = false;
        bool track2car2Check6 = false;
        bool track2car2Check7 = false;
        bool track2car2Check8 = false;
        bool track2car2Check9 = false;
        bool track2car2Check10 = false;
        bool track2car2Check11 = false;
        bool track2car2Check12 = false;
        bool track2car2Check13 = false;
        bool track2car2Check14 = false;
        bool track2car2Check15 = false;
        bool track2car2Check16 = false;
        bool track2car2redCheck = false;

        // player movement 
        // player 1 
        bool arrowLeft = false;
        bool arrowRight = false;
        bool arrowUp = false;
        bool arrowDown = false;

        // player 2
        bool aLeft = false;
        bool dRigth = false;
        bool wUp = false;
        bool sDown = false;

        //player 1 value
        int carAngle1 = 0;
        int carSpeed1 = 10;
        int widthCar1 = 15;
        int heightCar1 = 30;
        int carlap1 = 0;
        int car1Track2 = 0;

        //player 2 value
        int carAngle2 = 90;
        int carSpeed2 = 10;
        int widthCar2 = 15;
        int heightCar2 = 30;
        int carlap2 = 0;
        int car2Track2 = 0;

        int track = 2;
        public Form1()
        {
            InitializeComponent();
        }

        public void OnStart()
        {

            tracklimitsList.Clear();

            // track 1 
            if (track == 1)
            {
                tracklimitsList.Add(new Rectangle(0, 45, 1000, 40));
                tracklimitsList.Add(new Rectangle(0, 705, 1000, 40));
                tracklimitsList.Add(new Rectangle(0, 50, 5, 700));
                tracklimitsList.Add(new Rectangle(5, 86, 50, 140));
                tracklimitsList.Add(new Rectangle(56, 86, 50, 80));
                tracklimitsList.Add(new Rectangle(54, 170, 20, 30));
                tracklimitsList.Add(new Rectangle(70, 162, 20, 20));
                tracklimitsList.Add(new Rectangle(105, 80, 50, 50));
                tracklimitsList.Add(new Rectangle(105, 130, 20, 20));
                tracklimitsList.Add(new Rectangle(0, 705, 1000, 40));
                tracklimitsList.Add(new Rectangle(0, 50, 5, 700));
                tracklimitsList.Add(new Rectangle(5, 86, 50, 140));
                tracklimitsList.Add(new Rectangle(56, 86, 50, 80));
                tracklimitsList.Add(new Rectangle(54, 170, 20, 30));
                tracklimitsList.Add(new Rectangle(70, 162, 20, 20));
                tracklimitsList.Add(new Rectangle(105, 80, 50, 50));
                tracklimitsList.Add(new Rectangle(145, 74, 40, 40));
                tracklimitsList.Add(new Rectangle(180, 65, 60, 30));
                tracklimitsList.Add(new Rectangle(0, 50, 5, 700));
                tracklimitsList.Add(new Rectangle(5, 86, 50, 140));
                tracklimitsList.Add(new Rectangle(56, 86, 50, 80));
                tracklimitsList.Add(new Rectangle(54, 170, 20, 30));
                tracklimitsList.Add(new Rectangle(70, 162, 20, 20));
                tracklimitsList.Add(new Rectangle(105, 80, 50, 50));
                tracklimitsList.Add(new Rectangle(1, 200, 35, 60));
                tracklimitsList.Add(new Rectangle(1, 230, 20, 60));
                tracklimitsList.Add(new Rectangle(5, 565, 50, 150));
                tracklimitsList.Add(new Rectangle(56, 86, 50, 80));
                tracklimitsList.Add(new Rectangle(30, 600, 50, 150));
                tracklimitsList.Add(new Rectangle(80, 620, 20, 100));
                tracklimitsList.Add(new Rectangle(100, 640, 20, 100));
                tracklimitsList.Add(new Rectangle(120, 650, 20, 100));
                tracklimitsList.Add(new Rectangle(140, 665, 20, 100));
                tracklimitsList.Add(new Rectangle(160, 682, 40, 100));
                tracklimitsList.Add(new Rectangle(180, 694, 60, 30));
                tracklimitsList.Add(new Rectangle(1, 530, 35, 60));
                tracklimitsList.Add(new Rectangle(1, 500, 20, 60));
                tracklimitsList.Add(new Rectangle(960, 80, 50, 20));
                tracklimitsList.Add(new Rectangle(940, 80, 50, 157));
                tracklimitsList.Add(new Rectangle(920, 80, 20, 127));
                tracklimitsList.Add(new Rectangle(900, 80, 20, 106));
                tracklimitsList.Add(new Rectangle(880, 80, 50, 87));
                tracklimitsList.Add(new Rectangle(860, 80, 20, 66));
                tracklimitsList.Add(new Rectangle(830, 80, 60, 50));
                tracklimitsList.Add(new Rectangle(780, 80, 50, 25));
                tracklimitsList.Add(new Rectangle(740, 80, 40, 15));
                tracklimitsList.Add(new Rectangle(980, 80, 20, 1000));
                tracklimitsList.Add(new Rectangle(328, 279, 320, 243));
            }
            //track 2
            if (track == 2)
            {
                tracklimitsList.Add(new Rectangle(0, 215, 500, 8));
                tracklimitsList.Add(new Rectangle(0, 0, 9, 750));
                tracklimitsList.Add(new Rectangle(0, 208, 83, 30));
                tracklimitsList.Add(new Rectangle(973, 0, 984, 750));
                tracklimitsList.Add(new Rectangle(0, 678, 985, 749));
                tracklimitsList.Add(new Rectangle(0, 0, 985, 28));
                tracklimitsList.Add(new Rectangle(703, 175, 155, 360));
                tracklimitsList.Add(new Rectangle(103, 380, 145, 180));
                tracklimitsList.Add(new Rectangle(0, 0, 50, 60));
                tracklimitsList.Add(new Rectangle(0, 0, 25, 225));
                tracklimitsList.Add(new Rectangle(25, 175, 18, 40));
                tracklimitsList.Add(new Rectangle(338, 264, 230, 180));
                tracklimitsList.Add(new Rectangle(320, 223, 180, 45));
                tracklimitsList.Add(new Rectangle(220, 135, 575, 15));
                tracklimitsList.Add(new Rectangle(676, 145, 150, 38));
                tracklimitsList.Add(new Rectangle(949, 20, 40, 40));
                tracklimitsList.Add(new Rectangle(195, 600, 600, 10));
                tracklimitsList.Add(new Rectangle(130, 560, 150, 40));
                tracklimitsList.Add(new Rectangle(684, 550, 155, 40));
                tracklimitsList.Add(new Rectangle(600, 590, 210, 10));
            }

            //player 1 starting value
            carAngle1 = 90;
            carSpeed1 = 5;
            widthCar1 = 15;
            heightCar1 = 30;
            carlap1 = 0;
            if (track == 1)
            {
                int xCar1 = 400;
                int yCar1 = 120;

                Car1 = new Rectangle(xCar1, yCar1, widthCar1, heightCar1);
            }

            if (track == 2)
            {
                int xCar1 = 450;
                int yCar1 = 50;

                Car1 = new Rectangle(xCar1, yCar1, widthCar1, heightCar1);
            }


            //player 2 starting value
            carAngle2 = 90;
            carSpeed2 = 5;
            widthCar2 = 15;
            heightCar2 = 30;
            carlap2 = 0;

            if (track == 1)
            {
                int xCar2 = 400;
                int yCar2 = 210;

                Car2 = new Rectangle(xCar2, yCar2, widthCar2, heightCar2);
            }
            if (track == 2)
            {
                int xCar2 = 450;
                int yCar2 = 90;

                Car2 = new Rectangle(xCar2, yCar2, widthCar2, heightCar2);
            }

            //display score text
            if (track == 1)
            {
                car1Lap.Visible = true;
                car2Lap.Visible = true;

                Winlabel.Text = "";
                car1Lap.Text = "";
                car2Lap.Text = "";

                state = "playing";
                Game_Timer.Enabled = true;
            }

            if (track == 2)
            {
                track2car1Lap.Visible = true;
                track2car2Lap.Visible = true;

                Winlabel.Text = "";
                track2car1Lap.Text = "";
                track2car2Lap.Text = "";

                state = "playing";
                Game_Timer.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    arrowUp = true;
                    break;
                case Keys.Down:
                    arrowDown = true;
                    break;
                case Keys.Left:
                    arrowLeft = true;
                    break;
                case Keys.Right:
                    arrowRight = true;
                    break;
                case Keys.W:
                    wUp = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aLeft = true;
                    break;
                case Keys.D:
                    dRigth = true;
                    break;
                case Keys.Space:
                    if (state == "waiting" || state == "over")
                    {
                        OnStart();
                    }
                    break;
                case Keys.Escape:
                    if (state == "waiting" || state == "over")
                    {
                        Application.Exit();
                    }
                    break;


            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    arrowUp = false;
                    break;
                case Keys.Down:
                    arrowDown = false;
                    break;
                case Keys.Left:
                    arrowLeft = false;
                    break;
                case Keys.Right:
                    arrowRight = false;
                    break;
                case Keys.W:
                    wUp = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aLeft = false;
                    break;
                case Keys.D:
                    dRigth = false;
                    break;
            }
        }

        private void Game_Timer_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void movecar1Forwand()
        {
            double angleInRadian = Math.PI * carAngle1 / 180;
            int deltaY = (int)(carSpeed1 * Math.Cos(angleInRadian));
            int deltaX = (int)(carSpeed1 * Math.Sin(angleInRadian));

            Car1.Y -= deltaY;
            Car1.X += deltaX;
        }

        public void movecar1Bakcwards()
        {
            double angleInRadian = Math.PI * carAngle1 / 180;
            int deltaY = (int)(carSpeed1 * Math.Cos(angleInRadian));
            int deltaX = (int)(carSpeed1 * Math.Sin(angleInRadian));

            Car1.Y += deltaY;
            Car1.X -= deltaX;
        }

        public void movecar2Forwand()
        {
            double angleInRadian = Math.PI * carAngle2 / 180;
            int deltaY = (int)(carSpeed2 * Math.Cos(angleInRadian));
            int deltaX = (int)(carSpeed2 * Math.Sin(angleInRadian));

            Car2.Y -= deltaY;
            Car2.X += deltaX;
        }

        public void movecar2Bakcwards()
        {
            double angleInRadian = Math.PI * carAngle2 / 180;
            int deltaY = (int)(carSpeed2 * Math.Cos(angleInRadian));
            int deltaX = (int)(carSpeed2 * Math.Sin(angleInRadian));

            Car2.Y += deltaY;
            Car2.X -= deltaX;
        }
    }
}
