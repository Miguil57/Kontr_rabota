string[] ArrayToArrayOf3OrlessLetters(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            result[j] = str[i];
            j++;
        }
    }
    return result;
}
//функция записи для вывода массива строк на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
string[] array = { "1234", "1567", "-2", "computer science" };
string[] result = ArrayToArrayOf3OrlessLetters(array);
PrintArray(result);


