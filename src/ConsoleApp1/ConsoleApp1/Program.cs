// 数あてゲーム
using System;

Console.WriteLine("数あてゲームへようこそ！");
Console.WriteLine("1から100までの数字を当ててください。");

Random random = new Random();
int answer = random.Next(1, 101); // 1から100までの乱数
int attempts = 0;
int guess = 0;

while (guess != answer)
{
    Console.Write("予想を入力してください: ");
    string? input = Console.ReadLine();
    
    if (int.TryParse(input, out guess))
    {
        attempts++;
        
        if (guess < answer)
        {
            Console.WriteLine("もっと大きい数字です！");
        }
        else if (guess > answer)
        {
            Console.WriteLine("もっと小さい数字です！");
        }
        else
        {
            Console.WriteLine($"正解です！答えは {answer} でした。");
            Console.WriteLine($"{attempts}回で当てることができました！");
        }
    }
    else
    {
        Console.WriteLine("有効な数字を入力してください。");
    }
}

Console.WriteLine("ゲーム終了です。ありがとうございました！");
