// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("How many number are you willing to enter? ");
int count = Convert.ToInt32(Console.ReadLine());

int IsNumPos(int count_m)
{
    Console.WriteLine("Please enter the numbers: ");
    int posNums = 0;
    int[] arr = new int[count_m];
    for (int i = 0; i < count_m; i++)
    {
        Console.Write($"{i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
        if(arr[i] > 0) posNums++;
    }
    return posNums;
}

int result = IsNumPos(count);
Console.WriteLine($"You have entered {result} numbers greater than 0.");