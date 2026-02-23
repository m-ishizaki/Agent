using ConsoleApp;

Console.WriteLine("Hello, World!");

int result =
args.Length == 0
    ? MyClass.Add()
    : args.Length == 2
    ? MyClass.Add(args[0], args[1])
    : 0;

Console.WriteLine($"result: {result}");

/*
public static class MyClass
{
    public static int Add(string a1,string a2)=> Convert.ToInt32(a1) +Convert.ToInt32(a2);
}
*/
