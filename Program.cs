// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("программа, создающая массив из N введённых в консоль чисел\nВам необходимо ввести N целых чисел");

int count = 1;
List<int> array = new List<int>();

while(true) {
    Console.WriteLine("Введите " + count + "-е число:");
        string str = Console.ReadLine();
        if(str == "стоп") {
            break;
        }
        if(int.TryParse(str, out int number)) {
            array.Add(number);
            count++;
            continue;
        }
        else {
            Console.WriteLine("Некорректно указано число!\n");
            continue;
        }
    }

Console.WriteLine("Вы создали массив: "); Print(array);

void Print(List<int> array)
{
    for(int index = 0; index < count - 1; index++) {
        if(index == 0) Console.Write("[" + array[index] + ", ");
        else if (index == count - 2) Console.Write(array[index] + "]!");
        else Console.Write(array[index] + ", ");
    }
}