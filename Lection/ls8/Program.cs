var pyrPascal = new List<int[]>();
pyrPascal.Add(new int[] { 1 });
pyrPascal.Add(new int[] { 1, 1 });

int rows = 128;

for (int i = 2; i < rows; i++)
{
    int[] row = new int[i + 1];
    row[0] = 1;
    row[i] = 1;
    for (int j = 1; j < i; j++) row[j] = pyrPascal[pyrPascal.Count - 1][j] + pyrPascal[pyrPascal.Count - 1][j - 1];
    pyrPascal.Add(row);
}

for (int i = 0; i < pyrPascal.Count; i++)
{
    for (int x = 0; x < pyrPascal.Count - i; x++) System.Console.Write(" ");
    {
        for (int j = 0; j < pyrPascal[i].Length; j++) 
        {
            if (pyrPascal[i][j] % 2 == 0) System.Console.Write($"  ");
            else System.Console.Write($"* ");
        }
    }
    System.Console.WriteLine();
}