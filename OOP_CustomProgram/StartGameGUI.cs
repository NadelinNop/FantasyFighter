using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.IO;
namespace TestingGUI

{
    public class StartGameGUI : GUI, Input, UI
    {
        private Point2D pt;
        private string[] lines;
       
        private int selected;
    

        public StartGameGUI()
        {
            lines = File.ReadAllLines("iconnames.txt");
            X = 100;
            Y = 100;
            
        }
        public override void Draw(Window w)
        {
            //SplashKit.DrawBitmapOnWindow(w, Background, 0, 0);
            SplashKit.DrawText("Player 1", Color.Black, "Retro Gaming.ttf", 18, 70, 50);
            SplashKit.DrawText("Player 2", Color.Black, "Retro Gaming.ttf", 18, 650, 50);
            SplashKit.DrawText("Select your fighter", Color.Black, "Retro Gaming.ttf", 18, 280, 20);
            DrawSelectButton();
            DrawIcons();
        }
        public override void DrawButton(Color color, int x, int y, int width, int height)
        {
            SplashKit.DrawRectangle(color, x, y, width, height);
        }
        public void DrawSelectButton()
        {
            SplashKit.DrawText("Confirm", Color.Black, "Retro Gaming.ttf", 18, 350, 320);
            SplashKit.DrawRectangle(Color.Black, 345, 320, 100, 20);
        }
        public  void DrawIcons()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                SplashKit.DrawBitmap(lines[i], X * i+ 300, Y);
                SplashKit.DrawRectangle(Color.White, X * i + 300, Y, 50, 50);
               //X = i * X + 300;
                
            }
            
        }


        public Point2D GetInput()
        {
            if (SplashKit.MouseClicked(MouseButton.RightButton))
            {
                pt = SplashKit.MousePosition();
            }
            return pt;
        }
        public void DrawOutLine(int i)
        {
          
                SplashKit.DrawRectangle(Color.Black, X * i + 300 - 2, Y - 2, 54, 54); 
            
        }
            public int CheckInput()
            {
           
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {          
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if ((SplashKit.PointInRectangle(GetInput(), SplashKit.RectangleFrom(X * i + 300, Y, 50, 50)) == true))
                        {
                    
                            selected = i;
                    
                        }

                    }

                }

                DrawOutLine(selected);

                return selected;
            }
}
}