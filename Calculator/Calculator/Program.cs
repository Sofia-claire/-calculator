using System;

class Program
{
    static void Main()
    {
        Console.Write("Первое число: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Второе число: ");
        int b = int.Parse(Console.ReadLine());
        
        int sum = a + b;
        int minus = a - b;
        int multiply = a * b;
        int incrementA = a + 1;
        int incrementB = b + 1;
        int decrementA = a - 1;
        int decrementB = b - 1;
        
        int or = a | b;
        int and = a & b;
        int xor = a ^ b;
        int notA = ~a;
        int notB = ~b;
        
        Console.WriteLine("Сложение: " + a + " + " + b + " = " + sum);
        Console.WriteLine("Вычитание: " + a + " - " + b + " = " + minus);
        Console.WriteLine("Умножение: " + a + " * " + b + " = " + multiply);
        
        if (b != 0)
        {
            int divide = a / b;
            Console.WriteLine("Деление: " + a + " / " + b + " = " + divide);
        }
        else
        {
            Console.WriteLine("Деление: на ноль делить нельзя!");
        }
        
        Console.WriteLine("Инкремент первого числа: " + a + " + 1 = " + incrementA);
        Console.WriteLine("Инкремент второго числа: " + b + " + 1 = " + incrementB);
        Console.WriteLine("Декремент первого числа: " + a + " - 1 = " + decrementA);
        Console.WriteLine("Декремент второго числа: " + b + " - 1 = " + decrementB);
        
        Console.WriteLine("Побитовое ИЛИ: " + a + " | " + b + " = " + or);
        Console.WriteLine("Побитовое И: " + a + " & " + b + " = " + and);
        Console.WriteLine("Побитовое XOR: " + a + " ^ " + b + " = " + xor);
        Console.WriteLine("Побитовое НЕ первого числа: ~" + a + " = " + notA);
        Console.WriteLine("Побитовое НЕ второго числа: ~" + b + " = " + notB);
    }
}
