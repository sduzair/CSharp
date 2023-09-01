using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var cartItem = new CartItem("Apple", 0.99m);
        var cartItem2 = new CartItem("Apple", 0.99m);

        var items = new HashSet<CartItem>(new CartItemEqualityComparer()) { cartItem, cartItem2 };

        cartItem.Quantity = 1;
        cartItem2.Quantity = 5;

        Debug.Assert(items.Contains(cartItem));
    }
}

public record CartItem(string Name, decimal Price)
{
    public int Quantity { get; set; }
}

public class CartItemEqualityComparer : IEqualityComparer<CartItem>
{
    public bool Equals(CartItem? x, CartItem? y)
    {
        if (x is null || y is null)
        {
            return false;
        }
        return x.Name == y.Name;
    }
    public int GetHashCode(CartItem obj)
    {
        return obj.Name.GetHashCode();
    }
}
