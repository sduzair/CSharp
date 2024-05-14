using System.Net.Http.Json;

class Program
{
    static async Task Main(string[] args)
    {
        var joke = await GetRandomJoke();
        // var joke = await GetRandomJokeWithoutStateMachine();
        // var joke = await GetRandomJokeWithStateMachine();

        Console.ReadLine();
    }

    private static async Task<Joke?> GetRandomJoke()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync("https://official-joke-api.appspot.com/random_joke");
        var joke = await response.Content.ReadFromJsonAsync<Joke>();
        return joke;
    }

    private static Task<Joke> GetRandomJokeWithoutStateMachine()
    {
        return Task.FromResult(new Joke()
        {
            Id = 1,
            Setup = "What is the least spoken language in the world?",
            Punchline = "Sign Language",
            Type = "General"
        });
    }

    private static Task<Joke> GetRandomJokeWithStateMachine()
    {
        return Task.Run(() => new Joke()
        {
            Id = 1,
            Setup = "What is the least spoken language in the world?",
            Punchline = "Sign Language",
            Type = "General"
        });
    }
}