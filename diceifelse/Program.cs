internal class Program
{
    private static readonly int THRESHOLD1 = 16;
    private static readonly int THRESHOLD2 = 10;
    private static readonly int THRESHOLD3 = 7;
    private static void Main(string[] args)
    {
        var dice = new Random();

        var roll1 = dice.Next(1, 7);
        var roll2 = dice.Next(1, 7);
        var roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (IsDoubles(roll1, roll2, roll3))
        {
            System.Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }
        else if (IsTriples(roll1, roll2, roll3))
        {
            System.Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        if (total >= THRESHOLD1)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= THRESHOLD2)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == THRESHOLD3)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
    }

    private static bool IsTriples(int roll1, int roll2, int roll3)
    {
        return roll1 == roll2 && roll1 == roll3;
    }

    private static bool IsDoubles(int roll1, int roll2, int roll3)
    {
        if (roll1 == roll2) return true;
        if (roll1 == roll3) return true;
        if (roll2 == roll3) return true;
        return false;
    }
}