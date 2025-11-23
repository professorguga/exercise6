namespace Lib;

public static class Library 
{
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
}