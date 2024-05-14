using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

internal class Program
{
    private static void Main()
    {
        var summary = BenchmarkRunner.Run<BenchmarkComposingAsyncOps>();
    }

}

public class BenchmarkComposingAsyncOps
{
    [Benchmark]
    public Task GetSequentiallyAsync() => Joke.GetJokesAsync();

    [Benchmark]
    public async Task GetWhenAnyAsync()
    {
        await foreach (var _ in Joke.GetJokesAsyncEnumerable());
    }

    [Benchmark]
    public Task GetWhenAllAsync() => Joke.GetJokesWhenAllAsync();

    [Benchmark]
    public async Task GetWhenEachAsync()
    {
        await foreach (var joke in Joke.GetJokesWhenEachAsync())
        {
            continue;
        }
    }
}