class Ungulate
{
    protected void Eat() { /* whatever */ }
}

class Giraffe : Ungulate
{
    public static void FeedThem()
    {
        Giraffe g1 = new Giraffe();
        Ungulate g2 = new Giraffe();
        g1.Eat(); // fine
        // g2.Eat(); //! compile-time error "Cannot access protected member"
    }
}

class Dog : Ungulate
{
    public void Main()
    {
        Dog d1 = new Dog();
        Ungulate d2 = new Dog();
        d1.Eat(); // fine
        // d2.Eat(); //! compile-time error "Cannot access protected member"
    }
}

class Program
{
    public static void Main()
    {
        Dog d1 = new Dog();
        Ungulate d2 = new Dog();
        // d1.Eat(); //! compile-time error "Cannot access protected member"
        // d2.Eat(); //! compile-time error "Cannot access protected member"

        Giraffe g1 = new Giraffe();
        Ungulate g2 = new Giraffe();
        // g1.Eat(); //! compile-time error "Cannot access protected member"
        // g2.Eat(); //! compile-time error "Cannot access protected member"
    }
}