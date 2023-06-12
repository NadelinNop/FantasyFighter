using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TestingGUI
{
    public class GamePlayGUI:GUI,UI
    {
        private string[] lines;

        public GamePlayGUI()
        {
            Background = new Bitmap("Background", "Background.png");
            lines = File.ReadAllLines("iconnames.txt");
        }
        public override void Draw(Window w)
        {
            SplashKit.DrawBitmapOnWindow(w, Background, 0, 0);
            SplashKit.DrawRectangle(Color.Red, 10, 10, 300, 20);
            SplashKit.DrawRectangle(Color.Red, 490, 10, 300, 20);

        }
       
        public override void DrawButton(Color color, int x, int y, int width, int height)
        {
           
        }
        public  int CheckInput()
        {

            return 1;
        }
    }
}
