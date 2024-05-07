// write code for a boxing and unboxing example here

int a = 123;

object b = a;

a = 1234;

int c = (int)b;

Console.WriteLine($"a = {a}, b = {b}, c = {c}");
// a = 1234, b = 123, c = 123
