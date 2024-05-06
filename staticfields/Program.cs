// main entry point for the application add player to the game and start the game 


// create a new game
Game game = new();

// add players to the Game
game.AddPlayer(new Player("Player 1"));
game.AddPlayer(new Player("Player 2"));

Console.WriteLine("Welcome to the Dice Game!");
// start the game
game.Play();




