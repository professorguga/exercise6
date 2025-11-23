using System.Diagnostics;
using Lib;

static int Add(int x, int y)
{
    return x + y;
}

static int Subtract(int x, int y)
{
    return x - y;
}

static int Multiply(int x, int y)
{
    return x * y;
}

static int Divide(int x, int y)
{
    return x / y;
}

static int Mod(int x, int y)
{
    return x % y;
}

static bool AndFunc(bool x, bool y)
{
    return x && y;
}

static bool OrFunc(bool x, bool y)    => x || y;

static bool NotFunc(bool x) => !x;

static bool GreaterThan(int x, int y) => x > y;

static bool LessEqual(int x, int y) => x <= y;

static bool Equal(int x, int y) => x == y;


// 1
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

OrFunc(AndFunc(GreaterThan(Add(a, Multiply(b, c)), Subtract(d, e)), x), y);
AndFunc(AndFunc(LessEqual(Multiply(Subtract(a, b), Add(c, d)), e), z), NotFunc(x));
OrFunc(Equal(Mod(Add(Add(a, b), c), d), 0), AndFunc(GreaterThan(f, e), isAdmin));
AndFunc(NotFunc(OrFunc(x, y)), GreaterThan(Multiply(a, a), Multiply(b, c)));