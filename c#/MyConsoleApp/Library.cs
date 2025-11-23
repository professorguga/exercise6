namespace MyConsoleApp;

public static class Library 
{   
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int Divide(int x, int y)
    {
        return x / y;
    }

    public static int Mod(int x, int y)
    {
        return x % y;
    }

    public static bool AndFunc(bool x, bool y)
    {
        return x && y;
    }

    public static bool OrFunc(bool x, bool y)    => x || y;

    public static bool NotFunc(bool x) => !x;

    public static bool GreaterThan(int x, int y) => x > y;

    public static bool LessEqual(int x, int y) => x <= y;

    public static bool Equal(int x, int y) => x == y;
}