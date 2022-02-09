using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class BlockBuilder
    {
        public static string BuilderTop(int number)
        {
            string blockTop = "";

            if (number > 0 && number < 10)
            {
                blockTop = "     ------     ";
            }
            else if (number > 9 && number < 20)
            {
                blockTop = "    --------    ";
            }
            else if (number > 19 && number < 30)
            {
                blockTop = "   ----------   ";
            }
            else if (number > 29 && number < 40)
            {
                blockTop = "  ------------  ";
            }
            else if (number > 39 && number < 50)
            {
                blockTop = " -------------- ";
            }
            else
            {
                blockTop = "----------------";
            }

            return blockTop;
        }

        public static string BuilderMiddle(int number)
        {
            string blockMiddle = "";

            if (number > 0 && number < 10)
            {
                blockMiddle = $"     |  {Convert.ToString(number)} |     ";
            }
            else if (number > 9 && number < 20)
            {
                blockMiddle = $"    |  {Convert.ToString(number)}  |    ";
            }
            else if (number > 19 && number < 30)
            {
                blockMiddle = $"   |   {Convert.ToString(number)}   |   ";
            }

            else if (number > 29 && number < 40)
            {
                blockMiddle = $"  |    {Convert.ToString(number)}    |  ";
            }

            else if (number > 39 && number < 50)
            {
                blockMiddle = $" |     {Convert.ToString(number)}     | ";
            }
            else
            {
                blockMiddle = $"|      {Convert.ToString(number)}      |";
            }

            return blockMiddle;
        }
    }
}
