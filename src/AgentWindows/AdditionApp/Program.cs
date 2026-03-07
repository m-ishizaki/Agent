Console.WriteLine("足し算アプリ");
Console.Write("1つ目の数値を入力してください: ");
string? input1 = Console.ReadLine();
Console.Write("2つ目の数値を入力してください: ");
string? input2 = Console.ReadLine();

if (long.TryParse(input1, out long a) && long.TryParse(input2, out long b))
{
    long result = a + b;
    Console.WriteLine($"結果: {a} + {b} = {result}");
}
else
{
    Console.WriteLine("無効な入力です。整数を入力してください。");
}
