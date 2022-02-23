#region increment decrement
int a = 5;
Console.WriteLine($"Result of a : {a}");
Console.WriteLine($"Post Increment : {a++}");
Console.WriteLine($"Post Increment : {a}");
Console.WriteLine($"Post Increment : {a += 10}");
int b = 20;
Console.WriteLine($"Result of b : {b}");
Console.WriteLine($"Pre Increment : {--b}");
Console.WriteLine($"Pre Increment : {b -= 4}");
Console.WriteLine($"Pre Increment : {b}");
#endregion

#region math operations
Console.WriteLine($"Divisition : {16 / 5}");
Console.WriteLine($"Remain/Modulas  : {17 % 5}");
Console.WriteLine($"Addition  : {5 * 4}");
Console.WriteLine($"Multiply  : {4 * .5}");
Console.WriteLine($"Multiply  : {12.5 * .6}");
Console.WriteLine($"Multiply  : {12.5f * .6f}");
Console.WriteLine($"Multiply  : {12.5d * .6d}");
Console.WriteLine($"Multiply  : {12.5m * .6m}");


int x = 5;
x += 9;
Console.WriteLine($"Add of : {x}");
x -= 4;
Console.WriteLine($"Sub of : {x}");
x *= 3;
Console.WriteLine($"Mul of : {x}");
x /= 2;
Console.WriteLine($"Div of : {x}");
x %= 4;
Console.WriteLine($"Mod of : {x}");
#endregion

#region bitwise operations
uint a1 = 0b_0000_0000_0000_0000_0000_0000_1011_1000;
uint b1 = 0b_0000_0000_0000_0000_0000_0000_1001_1100;
Console.WriteLine($"Number in decimal {Convert.ToString(a1, toBase: 10)}");
Console.WriteLine($"Number in decimal {Convert.ToString(b1, toBase: 10)}");
uint c1 = ~a1;
Console.WriteLine($"Number in 1st complement {Convert.ToString(c1, toBase: 2)}");
Console.WriteLine($"Number in decimal {Convert.ToString(c1, toBase: 10)}");

uint x2 = 0b_1011_1000;
uint x3 = 0b_1011_1000;
uint d = x2 << 2;
Console.WriteLine($"Number in Binary {Convert.ToString(d, toBase: 2)}");
Console.WriteLine($"Number in decimal {Convert.ToString(d, toBase: 10)}");

uint e = x3 >> 2;
Console.WriteLine($"Number in Binary {Convert.ToString(e, toBase: 2)}");
Console.WriteLine($"Number in decimal {Convert.ToString(e, toBase: 10)}");

uint a2 = 0b_1011_1000;
uint b2 = 0b_1001_1100;
uint x4 = a2 & b2;
uint x5 = a2 | b2;
uint x6 = a2 ^ b2;
Console.WriteLine($"And Operation : {Convert.ToString(x4, toBase: 2)}");
Console.WriteLine($"And Operation : {Convert.ToString(x4, toBase: 10)}");
Console.WriteLine($"Or Operation : {Convert.ToString(x5, toBase: 2)}");
Console.WriteLine($"Or Operation : {Convert.ToString(x5, toBase: 10)}");
Console.WriteLine($"XOR Operation : {Convert.ToString(x6, toBase: 2)}");
Console.WriteLine($"XOR Operation : {Convert.ToString(x6, toBase: 10)}");

#endregion 




