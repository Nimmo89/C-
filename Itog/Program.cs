
Console.WriteLine("Введите элементы массива, разделяя их пробелом:");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(' ');

string[] FilterStrings(string[] inputArray)
{
    int count = 0;
    // Подсчет количества строк, удовлетворяющих условию
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }
    // Создание нового массива с отфильтрованными строками
    string[] outputArray = new string[count];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
    }
    return outputArray;
}
string[] outputArray = FilterStrings(inputArray);
Console.WriteLine("Результат:");
foreach (string str in outputArray)
{
    Console.WriteLine(str);
}