using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class Gameplay
    {
        public static int ReturnedNumber = Assigning_numbers.GetBlockValues();

        public static int Block1 = Assigning_numbers.GetBlockValues();
        public static int Block2 = Assigning_numbers.GetBlockValues();
        public static int Block3 = Assigning_numbers.GetBlockValues();
        public static int Block4 = Assigning_numbers.GetBlockValues();
        public static int Block5 = Assigning_numbers.GetBlockValues();
        public static int Block6 = Assigning_numbers.GetBlockValues();
        public static int Block7 = Assigning_numbers.GetBlockValues();

        public static int OBlock1 = Assigning_numbers.GetBlockValues();
        public static int OBlock2 = Assigning_numbers.GetBlockValues();
        public static int OBlock3 = Assigning_numbers.GetBlockValues();
        public static int OBlock4 = Assigning_numbers.GetBlockValues();
        public static int OBlock5 = Assigning_numbers.GetBlockValues();
        public static int OBlock6 = Assigning_numbers.GetBlockValues();
        public static int OBlock7 = Assigning_numbers.GetBlockValues();
        
        public static void ShowBuilding()
        {
            Console.WriteLine("----Opponent----       -----Player-----");
            Display.DisplayOpponentBlocks(OBlock1, Block1, 1);
            Display.DisplayOpponentBlocks(OBlock2, Block2, 2);
            Display.DisplayOpponentBlocks(OBlock3, Block3, 3);
            Display.DisplayOpponentBlocks(OBlock4, Block4, 4);
            Display.DisplayOpponentBlocks(OBlock5, Block5, 5);
            Display.DisplayOpponentBlocks(OBlock6, Block6, 6);
            Display.DisplayOpponentBlocks(OBlock7, Block7, 7);
        }

        public static int NewNumber()
        {
            Console.WriteLine($"Do You want {ReturnedNumber} or do You want mystery number y/n?");
            string YNinput = Console.ReadLine();

            if (YNinput == "n")
            {
                int a = ReturnedNumber;
                ReturnedNumber = Assigning_numbers.GetBlockValues();
                Assigning_numbers.possibleNumbers.Add(a);
            }

            return ReturnedNumber;
        }

        public static void ChangeBlockValue(int newNumber)
        {
            Console.WriteLine($"Where you want to put {newNumber}?");
            int input = Convert.ToInt32(Console.ReadLine());

            while (input < 1 && input > 7)
            {
                Console.WriteLine("Wrong input, pick again");
                input = Convert.ToInt32(Console.ReadLine());
            }

            if (input == 1)
            {
                int a = Block1;
                Block1 = newNumber;
                ReturnedNumber = a;
            }
            else if (input == 2)
            {
                int a = Block2;
                Block2 = newNumber;
                ReturnedNumber = a;
            }
            else if (input == 3)
            {
                int a = Block3;
                Block3 = newNumber;
                ReturnedNumber = a;
            }
            else if (input == 4)
            {
                int a = Block4;
                Block4 = newNumber;
                ReturnedNumber = a;
            }
            else if (input == 5)
            {
                int a = Block5;
                Block5 = newNumber;
                ReturnedNumber = a;
            }
            else if (input == 6)
            {
                int a = Block6;
                Block6 = newNumber;
                ReturnedNumber = a;
            }
            else if (input == 7)
            {
                int a = Block7;
                Block7 = newNumber;
                ReturnedNumber = a;
            }
            ShowBuilding();
        }
    }
}
