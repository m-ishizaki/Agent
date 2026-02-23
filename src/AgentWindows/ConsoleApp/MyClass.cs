using System.Security.Principal;

namespace ConsoleApp;

public static class MyClass
{
    private static string? startupUri { get; }
    static MyClass()
    {
        startupUri = System.Windows.Application.Current?.StartupUri.AbsoluteUri;
    }

    public static int Add() => 0;
    public static int Add(string a1, string a2) => Convert.ToInt32(a1) + Convert.ToInt32(a2);
    public static int Add(string a1, string a2, string a3) => Convert.ToInt32(a1) + Convert.ToInt32(a2) + Convert.ToInt32(a3);
}
