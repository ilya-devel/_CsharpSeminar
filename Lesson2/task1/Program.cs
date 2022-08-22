int rndNum = new Random().Next(10, 100);
System.Console.WriteLine($"Number: {rndNum}");

MaxGenerateNum();

void MaxGenerateNum(int rndN)
{
int num1 = rndN/10;
int num2 = rndN%10;

if (num1 > num2) System.Console.WriteLine($"{num1} > {num2}");
else if (num1 < num2) System.Console.WriteLine($"{num2} > {num1}");
else System.Console.WriteLine("Both numbers equal");
}