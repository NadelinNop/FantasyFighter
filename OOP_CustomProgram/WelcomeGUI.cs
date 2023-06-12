using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace TestingGUI
{
    public class WelcomeGUI : GUI, Input,UI
    {
        private Point2D pt;
        private int start;
            public WelcomeGUI()
            {
                Background = new Bitmap("MenuBackground", "menuimage.png");
            start = 0;
            }
            public override void Draw(Window w)
            {
                SplashKit.DrawBitmapOnWindow(w, Background,0,0);
                DrawStartButton();
                DrawQuitButton();
               
            }
            public override void DrawButton(Color color, int x, int y, int width, int height )
            {
                 SplashKit.DrawRectangle(color, x, y, width, height);
            }
            public  void DrawStartButton()
            {
                SplashKit.DrawText("Start Game", Color.White, "Retro Gaming.ttf", 18, 348, 200);
                DrawButton(Color.White, 340, 198, 140, 26); 
               
            }   
            public  void DrawQuitButton()
            {
                SplashKit.DrawText("Quit Game", Color.White, "Retro Gaming.ttf", 18, 356, 250);
                 DrawButton(Color.White, 340, 250, 140, 26);
               
            }
            public  Point2D GetInput()
            {
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                     pt = SplashKit.MousePosition();
                }
                return pt;
            }
            public int CheckInput()
            {
              
                 if (SplashKit.MouseClicked(MouseButton.RightButton))
                 {
                   
                     if ((SplashKit.PointInRectangle(GetInput(), SplashKit.RectangleFrom(340, 198, 140, 26)) == true))
                    {
                        start = 1;
                    }
                     else if((SplashKit.PointInRectangle(GetInput(), SplashKit.RectangleFrom(340, 250, 140, 26))== true))
                    {
                        start =  2;
                    }
                 }
                return start;
             }
    }
}


