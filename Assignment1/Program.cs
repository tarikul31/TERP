#region questions 1
Console.Write("Enter the Integer Number : ");
string sizeInput = Console.ReadLine();
int size = int.Parse(sizeInput);
int _bits = 32;
if (int.TryParse(sizeInput, out size))
{
    Console.Write("Enter Number of Rotations : ");
    int _rows = int.Parse(Console.ReadLine());
    int _num = (size << _rows) | (size >> (_bits - _rows));
    uint _result = Convert.ToUInt32(_num);
    Console.WriteLine($"Output : {Convert.ToString(_result, toBase: 2)}");

}
else
{
    Console.WriteLine("Input is Not Corret Format");
}
#endregion

#region questions 2
Console.WriteLine("Enter Numbers :");
string rows = Console.ReadLine();
if (rows.Trim().Length > 0)
{
    string[] snumber = (rows.Trim()).Split(' ');
    int[][] grids = new int[snumber.Length][];
    int[] numbers2 = new int[snumber.Length];
   
    for (int i = 0; i < snumber.Length; i++)
    {
        grids[i] = GetBigInteger(snumber[i]);
    }
    for (int i = 0; i < grids.Length; i++)
    {
        numbers2[i] = sumCalculations(grids[i]);        
    }
    for (int i = 0; i < numbers2.Length; i++)
    {
        Console.WriteLine($"Sum of Result of position {i} is :{ numbers2[i]}");

    }    
}
else
{
    Console.WriteLine("Input Format Not Valid");
}
int[] GetBigInteger(string num)
{
    int x = num.Length;
    int a = 0;
    int[] arry = new int[num.Length];
    while (a != x)
    {
        arry[a] = num[a] - '0';
        a++;
    }
    return arry;
}
int sumCalculations(int[] arrs)
{
    int res = 0;
    for (int i = 0; i < arrs.Length; i++)
    {
        res += arrs[i];
    }
    return res;
}


#endregion
