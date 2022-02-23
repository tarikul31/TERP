#region single array 
int[] myar = new int[5];
myar[0] = 25;
myar[1] = 30;
myar[2] = 35;
myar[3] = 32;
myar[4] = 40;
foreach (int i in myar)
{
    Console.WriteLine(i);
}

int[] myar2 = new int[] { 20, 15, 10, 25, 10 };
double result = myavg(myar2);
Console.WriteLine($"Average Result : { result}");

int mysum (int[] arrs)
{
    int res = 0;
    for (int i = 0; i < arrs.Length; i++)
    {
        res += arrs[i];
    }
    return res;
}
double myavg(int[] arrs2)
{
    double res2 = Convert.ToDouble(mysum(arrs2));
    return res2 / arrs2.Length;
}

#endregion

#region jagged array
int[][] myar3 = new int[4][];
myar3[0] = new int[] {5,6,8,4,7};
myar3[1] = new int[] {40,45,48};
myar3[2] = new int[] {80,85,88,90,95};
myar3[3] = new int[] {2000,5000,9000,7000,3000};
for(int i = 0; i < myar3.Length; i++)
{
    Console.Write($"Element of Array : ",i+1 );
    for(int j=0; j < myar3[i].Length; j++)
    {
        Console.Write(myar3[i][j] + "\t");
    }
    Console.WriteLine();
}
Console.ReadKey();

#endregion
