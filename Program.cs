using System;

namespace RollDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int throws;
            int die;

            Console.Write("How many time will you throw the dice? ");
            throws = int.Parse(Console.ReadLine());
            Console.Write("Which die will you throw? ");
            die = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Dice dice = new Dice();
            Console.WriteLine(dice.RollDie(throws, die));
        }
    }
}
