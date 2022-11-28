// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



Console.Clear();

int userInput = UserInput("Введите число элементов будущего массива: ", "Ошибка ввода!");
double[] array = new double[userInput];

FillArray(array);
PrintArray(array);
FindMaxValue(array);
FindMinValue(array);
DiffNumbers(array);
PrintDiffNumbers(array);
Console.WriteLine();
Console.WriteLine($"max = {FindMaxValue(array)}, min = {FindMinValue(array)}");


//______________________________Методы________________________________//

//___________________________// Заполнение массива случайными числами

void FillArray(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next();
}

//________________________________// Вывод массива на экран

void PrintArray(double[] array) 
{
    Console.Write($"[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write($"]");
}

//__________________________________// Ввод пользователя числа элементов будущего массива

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

//________________________________________// Разница между макс и мин

double DiffNumbers(double[] array)  
{   
    double maxValue = FindMaxValue(array);
    double minValue = FindMinValue(array);
    double result = maxValue - minValue;
    return result;
}
//_________________________________________// Вывод разницы чисел

void PrintDiffNumbers(double[] array)   
{
    Console.Write($" -> {DiffNumbers(array)}");
}


//__________________________________________// Нахождение максимального числа

double FindMaxValue(double[] array)  
{
    double maxValue = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxValue) maxValue = array[i];
    }
    return maxValue;
}

//___________________________________________// Нахождение минимального числа

double FindMinValue(double[] array) 
{
    double minValue = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue) minValue = array[i];
    }
    return minValue;
}