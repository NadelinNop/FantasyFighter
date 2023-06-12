using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGUI
{
    public class State
    {
        public enum StateBase
        {
            Select,
            Move,
            End
        }
        private StateBase state = StateBase.Select;
        public StateBase currentState { get { return state; } set { state = value; } }

        public void TakeAction(Character first, Character second)
        {
            if (first != null && second != null)
            {
                currentState = StateBase.Move;
                if (first.Health < 1 || second.Health<1)
                {
                    currentState = StateBase.End;
                }

            }
            
        }

       
    }
}
