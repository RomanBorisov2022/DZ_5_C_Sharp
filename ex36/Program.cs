// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int userInput = UserInput("Введите число элементов будущего массива: ", "Ошибка ввода!");
int userInput1 = UserInput1("Введите минимальное число в будущем массиве: ", "Ошибка ввода!");
int userInput2 = UserInput2("Введите максимальное число в будущем массиве: ", "Ошибка ввода!");	
int[] array = GetArray(userInput, userInput1, userInput2);
int sum = GetSum(array);
Console.Write("Массив: ");
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма элементов: {sum}");
Console.Write("[");
Console.Write(String.Join(" ", array));
Console.Write($"] -> {sum}");






//____________________________Методы и функции___________________________//

int[] GetArray(int userInput, int minValue, int maxValue)
{
    int[] res = new int[userInput];
    for (int i = 0; i < userInput; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//________Просим пользователя о том, сколько элементов будет в массиве______//

int UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;

        Console.WriteLine(errorMessage);
    }
}
//_______ПРосим пользователя ввести минимальный элемент______//

int UserInput1(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput1))
            return userInput1;

        Console.WriteLine(errorMessage);
    }
}
//_______ПРосим пользователя ввести максимальный элемент_____//

int UserInput2(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput2))
            return userInput2;

        Console.WriteLine(errorMessage);
    }
}

//_________ Возвращает сумму чисел на нечетной позиции_______//

int GetSum(int[] arr)
{
    int sum = 0;
    int i = 0;
    while(i < array.Length)
    {
        sum += array[i];
        i = i + 2;
    }
    return sum;
}