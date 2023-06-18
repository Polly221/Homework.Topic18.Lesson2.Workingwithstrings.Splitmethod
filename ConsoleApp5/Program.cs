//1
Console.Write("Введите строку чисел: "); 
string str = Console.ReadLine()!;
string[] mas = str.Split(',');
int sum = 0;
foreach (string i in mas)
{
    sum += int.Parse(i);
}
Console.WriteLine("S=" + sum);
//2
Console.Write("Введите предложение: "); 
string str2 = Console.ReadLine()!;
string[] mas2 = str2.Split(' '); 
int count = 0;
foreach (string i in mas2)
{
    count ++;
}

Console.WriteLine("S=" + count);