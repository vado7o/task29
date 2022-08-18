// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("программа, создающая массив из 8 введённых в консоль чисел\nВам необходимо ввести 8 целых чисел");

string str = "";
int[] array = new int[8];

for (int count = 0; count < 8; count++)
{
    while(true)
    {
        Console.WriteLine("Введите " + Count(count) + " число:");

        if(int.TryParse(Console.ReadLine(), out int number))
        {
            array[count] = number;
        }
        else 
        {
            Console.WriteLine("Некорректно указано число!\n");
            continue;
        }
    break;
    }
}

Console.WriteLine("Вы создали массив: "); Print(array);

//////////////////////////////////////////////////////////////////
string Count(int count)
{
    if(count == 0) str = "первое";
    if(count == 1) str = "второе";
    if(count == 2) str = "третье";
    if(count == 3) str = "четвёртое";
    if(count == 4) str = "пятое";
    if(count == 5) str = "шестое";
    if(count == 6) str = "седьмое";
    if(count == 7) str = "восьмое";
    
    return str;
}

void Print(int[] array)
{
    for(int index = 0; index < 8; index++)
    {
        if(index == 0) Console.Write("[" + array[index] + ", ");
        else if (index == 7) Console.Write(array[index] + "]!");
        else Console.Write(array[index] + ", ");
    }
}