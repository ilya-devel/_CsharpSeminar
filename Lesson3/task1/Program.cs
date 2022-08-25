try
{
System.Console.WriteLine("Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());
ShowPosition(x, y);
}
catch
{
    System.Console.WriteLine("You must enter int number!!!");
}

static void ShowPosition(int X, int Y)
{
    if (X>0 && Y>0) System.Console.WriteLine(1);
    else if (X>0 && Y<0) System.Console.WriteLine(2);
    else if (X<0 && Y<0) System.Console.WriteLine(3);
    else if (X<0 && Y>0) System.Console.WriteLine(4);
    else System.Console.WriteLine("You entered invalid coordinate!");
}