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

Console.WriteLine("Enter Two Numbers :");
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
#region questions 3

int[][,] _array3 = new int[][,]
{
new int[,] { {1,3}, {5,7} },
new int[,] { {0,2}, {4,6}, {8,10} },
new int[,] { {11,22}, {99,88}, {0,9} }
};
for (int i = 0; i < _array3.Length; i++)
{
    int _count = 0;
    //Console.Write($"Element of Array : ", i + 1);
    for (int j = 0; j < _array3[i].GetLength(_count); j++)
    {
        for (int k = 0; k < _array3[j].Rank; k++)
        {
            Console.WriteLine("Array Position of [" + i + "][" + j + ", " + k + "]: " + _array3[i][j, k] + " ");
        }
    }
    _count++;
    Console.WriteLine();
}


#endregion
#region questions 5
Console.Write("Enter the Size of Array : ");
int _size = 0;
string sizeInput = Console.ReadLine();
_size = int.Parse(sizeInput);
if (int.TryParse(sizeInput, out _size))
{
    int[,] _grids = new int[_size, _size];

    for (int i = 0; i < _size; i++)
    {
        string _rows = Console.ReadLine();
        string[] number = _rows.Split(' ');
        for (int j = 0; j < number.Length; j++)
        {
            _grids[i, j] = int.Parse(number[j]);
        }
    }
    int _ros, _cols, _sumRow, _sumCol;
    _ros = _grids.GetLength(0);
    _cols = _grids.GetLength(1);


    for (int i = 0; i < _cols; i++)
    {
        _sumCol = 0;
        for (int j = 0; j < _ros; j++)
        {
            _sumCol = _sumCol + _grids[j, i];
        }
        Console.WriteLine("Sum of " + (i + 1) + " column: " + _sumCol);
    }
    for (int i = 0; i < _ros; i++)
    {
        _sumRow = 0;
        for (int j = 0; j < _cols; j++)
        {
            _sumRow = _sumRow + _grids[i, j];
        }
        Console.WriteLine("Sum of " + (i + 1) + " rows: " + _sumRow);

    }

}
else
{
    Console.WriteLine("Input Format is Not Valid");
}

#endregion
