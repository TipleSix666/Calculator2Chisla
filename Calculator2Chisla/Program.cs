while (true)
{
    Console.WriteLine("Выберите действие: 1.+; 2.-; 3./; 4.*;");
    int action = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число 1");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    int num2 = int.Parse(Console.ReadLine());
    switch (action)
    {
        case 1:
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case 3:
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
        case 4:
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            break;
    }
}