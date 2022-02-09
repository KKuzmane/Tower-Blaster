using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class Display
    {
        public static void DisplayOpponentBlocks(int opponentNumber, int playerNumber, int position)
        {
            Console.WriteLine(BlockBuilder.BuilderTop(opponentNumber) + "  ---  " + BlockBuilder.BuilderTop(playerNumber));
            Console.WriteLine(BlockBuilder.BuilderMiddle(opponentNumber) + $"  |{position}|  " + BlockBuilder.BuilderMiddle(playerNumber));
            Console.WriteLine(BlockBuilder.BuilderTop(opponentNumber) + "  ---  " + BlockBuilder.BuilderTop(playerNumber));
        }
    }
}
