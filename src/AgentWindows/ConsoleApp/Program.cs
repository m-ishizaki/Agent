using ConsoleApp;

Console.WriteLine("Hello, World!");

int result =
args.Length == 3
    ? MyClass.Add(args[0], args[1], args[2])
    : 0;

Console.WriteLine($"result: {result}");

/*
public static class MyClass
{
    public static int Add(string a1,string a2)=> Convert.ToInt32(a1) +Convert.ToInt32(a2);
}
*/
