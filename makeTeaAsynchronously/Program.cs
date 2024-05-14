internal class Program
{
    private static async Task Main(string[] args)
    {
        string[] teaTypes = ["Green Tea", "Black Tea"];
        await MakeTeaAsync(teaTypes);
    }

    private static async Task MakeTeaAsync(string[] teaTypes)
    {
        var boilWaterTask = BoilWaterAsync(3000);
        Console.WriteLine("CupsPrepared");

        var selection = PromptForAndReturnTeaType(teaTypes);

        Console.WriteLine($"Cups{selection.Replace(" ", "")}BagsAdded");
        // Console.WriteLine(Environment.CurrentManagedThreadId);
        await boilWaterTask;
        // Console.WriteLine(Environment.CurrentManagedThreadId);
        Console.WriteLine("CupsBoiledWaterAdded");
        Console.WriteLine($"Cups{selection.Replace(" ", "")}Served");
        Console.ReadLine();
    }

    private static async Task BoilWaterAsync(int seconds)
    {
        Console.WriteLine("KettleWaterAdded");
        Console.WriteLine("KettleWaterBoilingStarted");
        await Task.Delay(seconds);
        Console.WriteLine("KettleWaterBoilingFinished");
    }

    private static string PromptForAndReturnTeaType(string[] teaTypes)
    {
        string? teaType = string.Empty;
        while (teaType != "1" && teaType != "2")
        {
            Console.WriteLine($"\nSelect tea type (1 for {teaTypes[0]} for 2 for {teaTypes[1]}):");
            teaType = Console.ReadLine();
        }
        var selection = teaType == "1" ? teaTypes[0] : teaTypes[1];
        Console.WriteLine($"You selected: {selection}\n");
        return selection;
    }
}