int SumNum(int m, int n)
{
    if(m==n) return m;
    return m + SumNum(m+1,n);
}
Console.Write("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Sum numbers:" + SumNum(M,N));