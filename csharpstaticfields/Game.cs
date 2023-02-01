public class Game
{
    public List<Player> Players { get; set; }
    public Dice Dice { get; set; }
    public int Rounds { get; set; }
    public Game()
    {
        Players = new List<Player>();
        Dice = new Dice();
    }
    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }
    public void Play()
    {
        for (int i = 0; i < Rounds; i++)
        {
            foreach (Player player in Players)
            {
                int score = Dice.Roll();
                player.Score += score;
                Console.WriteLine($"{player.Name} rolled a {score} and now has {player.Score} points.");
            }
        }
    }
}