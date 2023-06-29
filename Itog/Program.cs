    static string[] FilterStrings(string[] strings)
    {
        int count = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= 3)
            {
                result[index] = strings[i];
                index++;
            }
        }

        return result;
    }
        Console.WriteLine("Введите строки, разделенные пробелом:");
        string input = Console.ReadLine();
        string[] inputStrings = input.Split();
        string[] filteredStrings = FilterStrings(inputStrings);
        Console.WriteLine("Результат:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
