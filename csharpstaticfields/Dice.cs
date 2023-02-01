public class Dice
{
    public static int Sides { get; set; } = 6;
    public static int Roll()
    {
        Random random = new();
        return random.Next(1, Sides + 1);
    }
}