using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.IO;

namespace TestingGUI
{
    public class Player1 : Player
    {

        private string[] namelines;
        private string[] lines;
      
        private Bitmap Background;
        public Player1()
        {
            Turn = true;
            namelines = File.ReadAllLines("CharNames.txt");
            lines = File.ReadAllLines("iconnames.txt");
           
        }
        public override void Draw()
        {
           
            SplashKit.DrawLine(Color.Black, 70, 70, 170, 70);
            SplashKit.DrawBitmap(lines[I], 80, 100);

        }
        public override void CharSelection(int c)
        {

            SplashKit.DrawBitmap(lines[c], 80, 100);
            CheckingInput();
            Console.WriteLine(namelines[I]);
            I = c;
        }

        public override void CheckingInput()
        {
            Point2D pt = SplashKit.MousePosition();
            if (SplashKit.MouseClicked(MouseButton.RightButton))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if ((SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(345, 320, 100, 20)) == true))
                    {
                       
                        Turn = false;

                    }

                }

            }
        }
        public override void Move(Character c, Character target)
        {
           
            if (c.Selected == true)
            {

                if (SplashKit.KeyDown(KeyCode.DKey))
                {
                    c.Right = true;
                    c.X = c.X + 2;
                    c.BitmapOpt = c.BitmapRun;
                    c.Option = SplashKit.OptionWithAnimation(c.AnimationRun);
                    c.AnimationRun.Update();
                 
                }

                else if (SplashKit.KeyDown(KeyCode.AKey))
                {
                    c.Right = false;
                    c.X = c.X - 2;
                    c.BitmapOpt = c.BitmapRunRight;
                    c.Option = SplashKit.OptionWithAnimation(c.AnimationRun);
                    c.AnimationRun.Update();
                }
                else
                {
                    if (c.Right == true)
                    {
                        c.BitmapOpt = c.Bitmap;
                        c.Option = SplashKit.OptionWithAnimation(c.AnimationIdle);
                        c.AnimationIdle.Update();
                    }
                    else
                    {
                        c.Right = false;
                        c.BitmapOpt = c.BitmapRight;
                        c.Option = SplashKit.OptionWithAnimation(c.AnimationIdle);
                        c.AnimationIdle.Update();
                    }
                }
                if (SplashKit.KeyDown(KeyCode.QKey))
                {

                    if (c.Right == true)
                    {
                        c.BitmapOpt = c.BitmapAttack;
                        c.Option = SplashKit.OptionWithAnimation(c.AnimationAttack);
                        c.AnimationAttack.Update();
                        c.AnimationRun.Update();

                    }
                    else
                    {

                        c.BitmapOpt = c.BitmapAttackRight;
                        c.Option = SplashKit.OptionWithAnimation(c.AnimationAttack);
                        c.AnimationAttack.Update();
                        c.AnimationRun.Update();

                    }
                    if (target.Health > 0)
                    {

                        if ((target.X < (c.X + c.CellWidth)) & ((target.X + target.CellWidth) > c.X))
                        {


                            if (target.TakeDmg(c.Attackdmg) == 0)
                            {

                                target.Selected = false;
                            }

                        }

                    }



                }
               
                c.Draw();

                c.CellWidth = SplashKit.BitmapCellWidth(c.BitmapOpt);
               
            }
            SplashKit.FillRectangle(Color.Red, 490, 10, target.Health, 20);

        }
    }
}
        