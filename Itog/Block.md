```tefcha

input inputArray[] (Введите элементы массива, разделяя их пробелом)
int count = 0, int index = 0
while int i = 0; i < inputArray.Length; i++
    if inputArray[i].Length <= 3
        count++
    else
        i > 3
outputArray[] = new string[count] (Создать массив outputArray размером count)
while int i = 0; i < inputArray.Length; i++
    if inputArray[i].Length <= 3
        outputArray[index] = inputArray[i]
        index++
    else
        i > 3
while string str in outputArray[]
    Console.WriteLine(str);
end