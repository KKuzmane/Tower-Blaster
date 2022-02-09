using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tower_Blaster
{
    public class Program
    {
        public static bool PTurn = true;
        public static bool OTurn = false;
        public static bool OVictory = false;
        public static bool PVictory = false;

        static void Main(string[] args)
        {
            Gameplay.ShowBuilding();

            while (OVictory != true || PVictory != true)
            {
                if (PTurn == true)
                {
                    Gameplay.ChangeBlockValue(Gameplay.NewNumber());
                    OTurn = true;
                    PTurn = false;
                    VictoryConditions.PlayerVictory();
                    if (PVictory == true)
                    {
                        Console.WriteLine("You won!");
                        break;
                    }
                }
                else
                {
                    Opponent_turn.ChangeBlockValue(Opponent_turn.NewNumber());
                    PTurn = true;
                    OTurn = false;
                    VictoryConditions.OpponentVictory();
                    if (OVictory == true)
                    {
                        Console.WriteLine("You lost!");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
