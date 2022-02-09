using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class VictoryConditions
    {
        public static void OpponentVictory()
        {
            if (Gameplay.OBlock1 < Gameplay.OBlock2 && Gameplay.OBlock2 < Gameplay.OBlock3 &&
                Gameplay.OBlock3 < Gameplay.OBlock4 && Gameplay.OBlock4 < Gameplay.OBlock5 &&
                Gameplay.OBlock5 < Gameplay.OBlock6 && Gameplay.OBlock6 < Gameplay.OBlock7)
            {
                Program.OVictory = true;
            }
        }

        public static void PlayerVictory()
        {
            if (Gameplay.Block1 < Gameplay.Block2 && Gameplay.Block2 < Gameplay.Block3 &&
                Gameplay.Block3 < Gameplay.Block4 && Gameplay.Block4 < Gameplay.Block5 &&
                Gameplay.Block5 < Gameplay.Block6 && Gameplay.Block6 < Gameplay.Block7)
            {
                Program.PVictory = true;
            }
        }
    }
}
