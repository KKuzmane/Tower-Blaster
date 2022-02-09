using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class OpponentLogic
    {
        public static int OpponentsNumberLocation(int newNumber)
        {
            int position = 0;
            if (newNumber == 1)
                position = 1;
            else if (newNumber == 50)
                position = 7;
            else if (newNumber < 15)
                if (Gameplay.OBlock1 > Gameplay.OBlock2 && Gameplay.OBlock1 > newNumber)
                    position = 1;
                else
                    position = 2;
            else if(newNumber >= 15 && newNumber < 30)
                if (Gameplay.OBlock3 > Gameplay.OBlock4)
                    position = 3;
                else if (Gameplay.OBlock2 > Gameplay.OBlock3)
                    position = 2;
                else
                    position = 4;
            else if (newNumber >= 30 && newNumber < 43)
                if (Gameplay.OBlock6 < Gameplay.OBlock5)
                    position = 5;
                else if (Gameplay.OBlock7 < Gameplay.OBlock6 && newNumber > Gameplay.OBlock7)
                    position = 7;
                else
                    position = 6;
            else if (newNumber >= 43 && newNumber <= 50)
                if (Gameplay.OBlock6 > Gameplay.OBlock7 && Gameplay.OBlock6 < newNumber)
                    position = 7;
                else
                    position = 6;
                
            return position;
        }
    }
}
