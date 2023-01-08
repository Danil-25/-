Console.WriteLine("Чтобы узнать сумму натуральных чисел между числами M и N, введите целое положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чтобы узнать сумму натуральных чисел между числами M и N, введите целое положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
 
int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
            else if (N == 0) return (M * (M + 1)) / 2;       
            else if (M == N) return M;                       
            else if (M < N) return N + SumNumbers(M, N - 1);
            else return N + SumNumbers(M, N + 1);
}
void Main(string[] args)
{
    Console.Write("M = ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("N = ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
    Console.ReadLine();
}
