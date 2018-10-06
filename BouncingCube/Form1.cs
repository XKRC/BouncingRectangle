using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace BouncingCube
{
    public partial class Form1 : Form
    {

        int characterXLeft;
        int characterXRight;
        int characterYTop;
        int characterYBottom;
        int characterWidth;
        int characterHeight;
        int xLeftBound;
        int xRightBound;
        int yTopBound;
        int yBottomBound;

        int characterVx;
        int characterVy;

        int deltaX;
        int deltaY;

        int threashold; //the threashold will be one pixle 
        Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0),3);
        Graphics character;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threashold = 2;
            //let the character start on the middle left
            characterXLeft = 0 + threashold;
            characterWidth = outputPic.ClientSize.Height / 20;
            characterXRight = characterWidth + characterXLeft;
            characterYTop = outputPic.ClientSize.Height / 2;
            characterHeight = outputPic.ClientSize.Height / 20;
            characterYBottom = characterHeight + characterYTop;
            outputPic.Invalidate();
            deltaX = 1;
            deltaY = 1;

            //double buffering technique
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }


        void projectNextFrame()
        {
            //finds where the box will move next
        }

        private void outputPic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(blackPen, characterXLeft, characterYTop, characterXRight - characterXLeft, characterYBottom - characterYTop);
        }

        private void moveFrame()
        {

                characterXLeft += deltaX;
                characterXRight = characterWidth + characterXLeft;
                characterYTop += deltaY;
                characterYBottom = characterHeight + characterYTop;
                //character.FillRectangle(blackPen, new Rectangle(characterXLeft, characterYTop, characterXRight - characterXLeft, characterYBottom - characterYTop));
      
            if (characterXLeft < 0 + threashold)
            {
                deltaX = 1;
                characterXLeft = threashold;
                characterXRight = characterWidth + characterXLeft;
                //Debug.WriteLine("Has hit the left");

            }

            if (characterXRight > outputPic.ClientSize.Width - threashold)
            {
                deltaX = -1;
                characterXRight = outputPic.ClientSize.Width - threashold;
                characterXLeft = characterXRight - characterWidth;
                //Debug.WriteLine("Has hit the right");

            }

            if (characterYTop < 0 + threashold)
            {
                deltaY = 1;
                characterYTop = threashold;
                characterYBottom = characterHeight + characterYTop;
                //Debug.WriteLine("Has hit the top");
            }

            if (characterYBottom > outputPic.ClientSize.Height - threashold)
            {
                deltaY = -1;
                characterYBottom = outputPic.ClientSize.Height - threashold;
                characterYTop = characterYBottom - characterHeight;
                //Debug.WriteLine("Has hit the bottom");
            }
        }

        private void outputPic_Click(object sender, EventArgs e)
        {
            moveFrame();
        }


        //1000 interval = 1000ms = 1s
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveFrame();
            outputPic.Invalidate();  //calls the paint event
        }
    }
}
