using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGUI
{
    public class CharacterFactory
    {
      
          public Character CreateChar(int c)
          {
           
            if ((c == 0)||(c==1))
            {
               
                return new Witch(c);

            }
            
            if (c == 2)
            {
                return new Warrior();
            }
            else 
                return new Witch(c);

          
        }
    }
}
