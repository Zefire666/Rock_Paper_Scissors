using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training;
    public class Player
    {
    public enum VARIANTS { ROCK, PAPER, SCISSORS };

    private string name;
    public VARIANTS choice;

    public Player()
    {
        name = "Bot";
        Random random = new Random();
        choice = (VARIANTS)random.Next(0, 3);
    }

    public Player(VARIANTS choice, string name)
    {
        this.name = name;
        this.choice = choice;
    }

    public string whoWins(Player p1, Player p2)
    {
        if (p1.choice == p2.choice)
        {
            return "Draw";
        }
        else if (p1.choice == VARIANTS.ROCK && p2.choice == VARIANTS.SCISSORS ||
            p1.choice == VARIANTS.PAPER && p2.choice == VARIANTS.ROCK ||
            p1.choice == VARIANTS.SCISSORS && p2.choice == VARIANTS.PAPER)
        {
            return $"Победил игрок с именем: {p1.name}";
        }
        else
        {
            return $"Победил игрок с именем: {p2.name}";
        }
    }
    }
