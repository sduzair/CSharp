using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        //create a new cart with 2 items and serialize it to json
        var cart = CartDto.Create();

        var json = JsonSerializer.Serialize(cart);

        Console.WriteLine(json);

        //deserialize the json back to a cart
        var cart2 = JsonSerializer.Deserialize<CartDto>(json);
        Console.WriteLine(cart2);
    }
}

internal record CartDto(int Id, HashSet<CartItemDto> Items, decimal TotalPrice)
{
    public static CartDto Create()
    {
        HashSet<CartItemDto> items = new() { new("Shampoo", 3, 3.99m), new("Soap", 2, 1.99m) };
        decimal totalPrice = items.Aggregate(0m, (acc, item) => acc + item.UnitPrice * item.Quantity);
        return new(default, items, totalPrice);
    }
}
internal record CartItemDto(string Name, int Quantity, decimal UnitPrice);