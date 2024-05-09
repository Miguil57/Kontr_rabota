# Контрольная работа

## Условия задачи:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Решение:**

*Блок-схема алгоритма*

![Алгоритм](Блок-схема.jpg)

*Код программы*

```
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



