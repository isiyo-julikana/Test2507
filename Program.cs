﻿int SelectMethodArray()
{
    int size;
    Console.WriteLine("Выбереите метод определения размера массива \n 1 - Вы выбираете метод \n 2 - Размер задается случайно(3-30)");
    Console.Write("Ваш выбор: ");
    int selecMethod = Convert.ToInt32(Console.ReadLine());
    while ((selecMethod > 2) || (selecMethod < 1))
    {
        Console.WriteLine("Неправильный ввод, попробуйте еще раз...");
        selecMethod = Convert.ToInt32(Console.ReadLine());
    }
    if (selecMethod == 2)
    {
        size = new Random().Next(3, 31);
        Console.WriteLine($"Полученый размер: {size}");
    }
    else
    {
        Console.Write("Введите размер size: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}
string[] SelectMethodFill(int size)
{

    Console.WriteLine("Выбереите метод заполнения массива \n 1 - Вы заполняете массив \n 2 - Заполняется случайными значениями");
    Console.Write("Ваш выбор: ");
    int selecMethod = Convert.ToInt32(Console.ReadLine());
    while ((selecMethod > 2) || (selecMethod < 1))
    {
        Console.WriteLine("Неправильный ввод, попробуйте еще раз...");
        selecMethod = Convert.ToInt32(Console.ReadLine());
    }
    if (selecMethod == 2)
    {
        string[] randArray = new string[size];
        for (int i = 0; i < size; i++)
        {
            randArray[i] = RandomVar();
        }
        return randArray;

    }
    else
    {
        string[] userArray = new string[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите {i + 1} значение массива: ");
            userArray[i] = Console.ReadLine();
        }
        return userArray;


    }
}


string RandomVar()
{
    Random random = new Random();
    int length = new Random().Next(1, 10);
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());

}
void ArrayPrinter(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
string[] ArrayChecker(string[] array)
{
    Console.WriteLine("Обработка массива.");
    int j = 0;
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length < 4)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;

}



int arraySize = SelectMethodArray();
string[] genArray = SelectMethodFill(arraySize);
ArrayPrinter(genArray);
string[] chckdArray = ArrayChecker(genArray);
ArrayPrinter(chckdArray);

Console.WriteLine("Завершение.");
