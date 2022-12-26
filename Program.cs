/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат, S = {SumNumbers(M, N)}");
Console.ReadLine();
 
int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}


/*Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.*/

int Recurs(int number)  
	{
		if (number > 1)
		{
		Recurs(number / 2);
		}
		Console.Write(number % 2);
		return number;
	}

        Console.Write("Введите натуральное число: ");
		Console.Write("\n");
		int number;
		number = Convert.ToInt32(Console.ReadLine());
		Recurs(number);
