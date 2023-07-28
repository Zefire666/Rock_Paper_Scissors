using System;
using System.IO;
using System.Collections;
using System.Linq;
using static Training.Player;

namespace Training;
    class Program
    {

        static void Main(string[] args)
        {
        Player bot = new Player();
        Player alex = new Player(VARIANTS.PAPER, "Alex");

        Console.WriteLine(bot.whoWins(bot, alex));

        Console.WriteLine("Hello");

        Console.ReadLine();


    }
    }
