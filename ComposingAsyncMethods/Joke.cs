internal class Joke
{
    public int Id { get; set; }
    public bool Error { get; set; }
    public string Category { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string Setup { get; set; } = null!;
    public string Delivery { get; set; } = null!;
    public Flags Flags { get; set; } = null!;
    public bool Safe { get; set; }
    public string Lang { get; set; } = null!;

    public static async IAsyncEnumerable<Joke> GetJokesWhenEachAsync(int count = 5)
    {
        var tasks = Enumerable.Range(0, count)
                              .Select(_ => GetJokeAsync());
        await foreach (Task<Joke> task in Task.WhenEach(tasks))
        {
            yield return await task;
        }
    }

    public static async Task<Joke[]> GetJokesWhenAllAsync(int count = 5)
        => await Task.WhenAll(Enumerable.Range(0, count)
                                        .Select(_ => GetJokeAsync()));

    public static async IAsyncEnumerable<Joke> GetJokesAsyncEnumerable(int count = 5)
    {
        List<Task<Joke>> tasks = Enumerable.Range(0, count)
                                            .Select(_ => GetJokeAsync())
                                            .ToList();
        while (tasks.Count > 0)
        {
            var completedTask = await Task.WhenAny(tasks);
            tasks.Remove(completedTask);
            yield return await completedTask;
        }

    }

    public static async Task<IReadOnlyList<Joke>> GetJokesAsync(int count = 5)
    {
        List<Joke> jokes = [];
        for (int i = 0; i < count; i++)
        {
            var joke = await GetJokeAsync();
            jokes.Add(joke);
        }
        return jokes;
    }

    private static async Task<Joke> GetJokeAsync(CancellationToken cancellationToken = default)
    {
        // using var client = new HttpClient();
        // var uri = $"https://v2.jokeapi.dev/joke/Any";
        // var response = await client.GetAsync(uri, cancellationToken);
        // return (await response.Content.ReadFromJsonAsync<Joke>(cancellationToken))!;
        await Task.Delay(2, cancellationToken);
        return new Joke()
        {
            Error = false,
            Category = "Dark",
            Type = "twopart",
            Setup = "What's black and sits at the top of a stairwell?",
            Delivery = "A paraplegic after a house fire.",
            Flags = new Flags()
            {
                Nsfw = false,
                Religious = false,
                Political = false,
                Racist = false,
                Sexist = false,
                Explicit = false
            },
            Id = 135,
            Safe = false,
            Lang = "en"
        };
    }

    public override string ToString()
    {
        return $"Id: {Id}\nError: {Error}\nCategory: {Category}\nType: {Type}\nSetup: {Setup}\nDelivery: {Delivery}\nFlags: {Flags}\nSafe: {Safe}\nLang: {Lang}";
    }
}
