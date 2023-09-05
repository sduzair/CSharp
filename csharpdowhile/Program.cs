using System.Diagnostics;

static bool MonsterWins(int monsterPoints)
{
    return monsterPoints > 0;
}

static bool HeroWins(int heroPoints)
{
    return heroPoints > 0;
}

var damage = new Random();

int heroPoints = 10;
int monsterPoints = 10;

for (int i = 0; i < 100; i++)
{
    heroPoints = 10;
    monsterPoints = 10;

    do
    {
        // hero attack
        var monsterDamage = damage.Next(1, 11);
        monsterPoints -= monsterDamage;
        PrintDamage("Monster", monsterPoints, monsterDamage);

        // monster attack
        var heroDamage = damage.Next(1, 11);
        heroPoints -= heroDamage;
        PrintDamage("Hero", heroPoints, heroDamage);

        Console.WriteLine();

    } while (heroPoints > 0 && monsterPoints > 0);

}

// Mutually exclusive events
Debug.Assert((HeroWins(heroPoints) && MonsterWins(monsterPoints)) == false, "Cannot be that both Hero and Monster win!");

//Mutually exhaustive events
Debug.Assert(!HeroWins(heroPoints) && !MonsterWins(monsterPoints) == false, "Cannot be that neither Hero nor Monster win!");

if (HeroWins(heroPoints))
{
    Console.WriteLine("Hero wins!");
}
if (MonsterWins(monsterPoints))
{
    Console.WriteLine("Monster wins!");
}

static void PrintDamage(string player, int playerPoints, int playerDamage)
{
    Console.Write($"{player}: ");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("-" + playerDamage + " ");
    Console.ResetColor();
    Console.Write("-> ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(playerPoints + "\n");
    Console.ResetColor();
}

// static string Colorize(string text, ConsoleColor color)
// {
//     string colorCode = "\u001b[" + (int)color + "m";
//     string resetCode = "\u001b[0m";
//     return colorCode + text + resetCode;
// }