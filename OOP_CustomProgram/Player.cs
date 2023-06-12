using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGUI
{
    public abstract class Player
    {
        private Boolean turn;
        private int i;
        public Boolean Turn
        {
            get
            {
                return turn;
            }
            set
            {
                turn = value;
            }
        }
        public int I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }
        public abstract void Draw();
     
        public abstract void CharSelection(int c);
        public abstract void CheckingInput();

        public abstract void Move(Character c, Character target);
    }
}
