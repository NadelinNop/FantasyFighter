using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace TestingGUI
{
    public abstract class GUI
    {
        private Bitmap _background;
        private int _x, _y, _width, _height;
        public GUI()
        {

        }
        public Bitmap Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public abstract void Draw(Window w);
        public abstract void DrawButton(Color color, int x, int y, int width, int height);



       
    }
}
