using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;


namespace TestingGUI
{
    public abstract class Character
    {
        private string _name;
        private int _health;
        private int _attackDmg;

        private Bitmap _bitmapOpt;
        private DrawingOptions _opt;
        private Bitmap _bitmap;
        private Bitmap _bitmapRight;
        private Bitmap _bitmapRun;
        private Bitmap _bitmapRunRight;
        private Bitmap _bitmapAttack;
        private Bitmap _bitmapAttackRight;
        private Bitmap _bitmapTakeDMG;
        private AnimationScript _animationScriptIdle;
        private AnimationScript _animationScriptRun;
        private AnimationScript _animationScriptAttack;
        private AnimationScript _animationScriptTakeDmg;
        private Animation _animationIdle;
        private Animation _animationRun;
        private Animation _animationAttack;
        private Animation _takeDmg;
        private int _x;
        private int _y;
        private Boolean _right;
        private Boolean _selected;
        private int _cellWidth;




        public Character()
        {

        }

        public int CellWidth
        {
            get
            {
                return _cellWidth;
            }
            set
            {
                _cellWidth = value;
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
        public Boolean Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public Boolean Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }


        public Bitmap BitmapOpt
        {
            get
            {
                return _bitmapOpt;
            }
            set
            {
                _bitmapOpt = value;
            }
        }
        public DrawingOptions Option
        {
            get
            {
                return _opt;
            }
            set
            {
                _opt = value;
            }
        }
        public Bitmap BitmapTakeDMG
        {
            get
            {
                return _bitmapTakeDMG;
            }
            set
            {
                _bitmapTakeDMG = value;
            }
        }
        public Bitmap Bitmap
        {
            get
            {
                return _bitmap;
            }
            set
            {
                _bitmap = value;
            }
        }
        public Bitmap BitmapRight
        {
            get
            {
                return _bitmapRight;
            }
            set
            {
                _bitmapRight = value;
            }
        }
        public Bitmap BitmapRun
        {
            get
            {
                return _bitmapRun;
            }
            set
            {
                _bitmapRun = value;
            }
        }
        public Bitmap BitmapRunRight
        {
            get
            {
                return _bitmapRunRight;
            }
            set
            {
                _bitmapRunRight = value;
            }
        }
        public Bitmap BitmapAttack
        {
            get
            {
                return _bitmapAttack;
            }
            set
            {
                _bitmapAttack = value;
            }
        }
        public Bitmap BitmapAttackRight
        {
            get
            {
                return _bitmapAttackRight;
            }
            set
            {
                _bitmapAttackRight = value;
            }
        }

        public AnimationScript AnimationScriptIdle
        {
            get
            {
                return _animationScriptIdle;
            }
            set
            {
                _animationScriptIdle = value;
            }
        }
        public AnimationScript AnimationScriptRun
        {
            get
            {
                return _animationScriptRun;
            }
            set
            {
                _animationScriptRun = value;
            }
        }
        public AnimationScript AnimationScriptTakeDmg
        {
            get
            {
                return _animationScriptTakeDmg;
            }
            set
            {
                _animationScriptTakeDmg = value;
            }
        }
        public AnimationScript AnimationScriptAttack
        {
            get
            {
                return _animationScriptAttack;
            }
            set
            {
                _animationScriptAttack = value;
            }
        }
        public Animation AnimationTakeDmg
        {
            get
            {
                return _takeDmg;
            }
            set
            {
                _takeDmg = value;
            }
        }
        public Animation AnimationIdle
        {
            get
            {
                return _animationIdle;
            }
            set
            {
                _animationIdle = value;
            }
        }
        public Animation AnimationRun
        {
            get
            {
                return _animationRun;
            }
            set
            {
                _animationRun = value;
            }
        }
        public Animation AnimationAttack
        {
            get
            {
                return _animationAttack;
            }
            set
            {
                _animationAttack = value;
            }
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        public int Attackdmg
        {
            get
            {
                return _attackDmg;
            }
            set
            {
                _attackDmg = value;
            }
        }


        public abstract void Draw();


        public abstract void Attack();
        public abstract int TakeDmg(int attack);

    }
}

