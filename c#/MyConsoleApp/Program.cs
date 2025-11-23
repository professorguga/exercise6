using MyConsoleApp;

int a = 5;
int b = 3;
int c = 7;
int d = 4;
int e = 2;
int f = 10;

bool x = true;
bool y = false;
bool z = true;
bool isAdmin = false;

Console.WriteLine(Library.OrFunc(Library.AndFunc(Library.GreaterThan(Library.Add(a, Library.Multiply(b, c)), Library.Subtract(d, e)), x), y));
Console.WriteLine(Library.AndFunc(Library.AndFunc(Library.LessEqual(Library.Multiply(Library.Subtract(a, b), Library.Add(c, d)), e), z), Library.NotFunc(x)));
Console.WriteLine(Library.OrFunc(Library.Equal(Library.Mod(Library.Add(Library.Add(a, b), c), d), 0), Library.AndFunc(Library.GreaterThan(f, e), isAdmin)));
Console.WriteLine(Library.AndFunc(Library.NotFunc(Library.OrFunc(x, y)), Library.GreaterThan(Library.Multiply(a, a), Library.Multiply(b, c))));