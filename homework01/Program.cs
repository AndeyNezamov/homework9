void ShowNum(int n)
{
    if (n > 1) 
    {
        Console.Write(n + " ");
        ShowNum(n - 1);
    }
    else Console.Write(1);
}

Console.Write("input N: ");
ShowNum(Convert.ToInt32(Console.ReadLine()));
