//? Casting -> Truncates ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
int value = (int)1.5m;  //! loss of data
System.Console.WriteLine(value);    // Output: 1

/*
    - Casting from high to low precision is called narrowing conversion
        - This can result in loss of data as is the case above
    - Casting from low to high precision is called widening conversion
*/

// int value2;
// bool isParseSuccess = int.TryParse(1.5m, out value2);

/*
    - int is a alias for System.Int32
    - TryParse() is a static method of the Int32 class which only accepts a string as its first argument
*/

//? Converting -> Rounds ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
int value3 = Convert.ToInt32(1.5m);
System.Console.WriteLine(value3);   // Output: 2

/*
    - Convert.ToInt32() is a static method of the Convert class which accepts a decimal as its first argument
        - Overloaded methods exist for other types
    - Convert.ToInt32() rounds the decimal value to the nearest integer
        - Here rounding instead of truncating occurs
*/