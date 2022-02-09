using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class Opponent_turn
    {
        public static int NewNumber()
        {
            Random random = new Random();
            Console.WriteLine($"Do You want {Gameplay.ReturnedNumber} or do You want mystery number y/n?");
            int randomYN = random.Next(0, 2);
            string YNinput;
            if (randomYN == 1)
            {
                YNinput = "y";
                Console.WriteLine("y");
            }
            else
            {
                YNinput = "n";
                Console.WriteLine("n");
            }

            if (YNinput == "n")
            {
                int a = Gameplay.ReturnedNumber;
                Gameplay.ReturnedNumber = Assigning_numbers.GetBlockValues();
                Assigning_numbers.possibleNumbers.Add(a);
            }

            return Gameplay.ReturnedNumber;
        }

        public static void ChangeBlockValue(int newNumber)
        {
            Random random = new Random();
            Console.WriteLine($"Where you want to put {newNumber}?");
            int input = OpponentLogic.OpponentsNumberLocation(newNumber);
            Console.WriteLine(input);

            if (input == 1)
            {
                int a = Gameplay.OBlock1;
                Gameplay.OBlock1 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            else if (input == 2)
            {
                int a = Gameplay.OBlock2;
                Gameplay.OBlock2 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            else if (input == 3)
            {
                int a = Gameplay.OBlock3;
                Gameplay.OBlock3 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            else if (input == 4)
            {
                int a = Gameplay.OBlock4;
                Gameplay.OBlock4 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            else if (input == 5)
            {
                int a = Gameplay.OBlock5;
                Gameplay.OBlock5 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            else if (input == 6)
            {
                int a = Gameplay.OBlock6;
                Gameplay.OBlock6 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            else if (input == 7)
            {
                int a = Gameplay.OBlock7;
                Gameplay.OBlock7 = newNumber;
                Gameplay.ReturnedNumber = a;
            }
            Gameplay.ShowBuilding();
        }
    }
}
