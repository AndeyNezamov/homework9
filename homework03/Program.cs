int Akkerman (int m, int n)
{
    if(m == 0) return n+1;
    else if(n == 0) return Akkerman(m-1,1);
    else return Akkerman(m-1, Akkerman(m, n-1));    
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m,n));