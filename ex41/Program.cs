/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3  */


string GetString(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    result = result.Replace(" ", "");
    return result;
}

void FindAndCount(string message)
{
    int CountComa = 1;
    int CountMinus = 0;
    int result;
    if  (message[0] != 0) CountComa --;
    for (int i=0; i<message.Length; i++)
    {
        if (message[i] == ',' && message[i+1] != '0' ) CountComa ++;
        if (message[i] == '-') CountMinus ++;
    }
    result = CountComa - CountMinus;
    Console.WriteLine(result);
}

string mas = GetString("введите числа через запятую");
FindAndCount(mas);
