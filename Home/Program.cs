string str = "12345678098765431234567809876543";
int[] arr = GetBigInteger(str);
for (int i = 0; i < str.Length; i++)
{
	Console.WriteLine($"Element{i} is  {arr[i]}");
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


