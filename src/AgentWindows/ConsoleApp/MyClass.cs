using System.Security.Principal;

namespace ConsoleApp;

public static class MyClass
{
    private static string? startUpUri { get; set; }
    static MyClass() {
        startUpUri =  System.Windows.Application.Current?.StartupUri.AbsoluteUri;
    }
    public static int Add() => 0;
    public static int Add(string a1, string a2) => Convert.ToInt32(a1) + Convert.ToInt32(a2);
}
