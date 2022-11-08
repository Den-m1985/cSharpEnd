
//Написать программу, которая из имеющегося массива строк
//формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоватся коллекциями, лучше обойтись исключительно массивами.
//Exampls:
//["helo","2","world",":-)"]   -> ["2",":-)"]
//["1234","1567","-2","computer science"]   -> ["2"]
//["Russia","Denmark","Kazan"]   -> []



string value1 = "helo,2,world,:-)";
string value2 = "1234,1567,-2,computer science";
string value3 = "Russia,Denmark,Kazan";

int min = 3;  //3 символа из условия задачи.
string[] textTask1 = SplitWorld(value1, min);
string[] textTask2 = SplitWorld(value2, min);
string[] textTask3 = SplitWorld(value3, min);
Console.WriteLine("[" + String.Join(", ", textTask1) + "]");
Console.WriteLine("[" + String.Join(", ", textTask2) + "]");
Console.WriteLine("[" + String.Join(", ", textTask3) + "]");


//Разделяем строку на слова или набор символов через указанный разделитель.
string[] SplitWorld(string value, int min)
{
    string[] words = value.Split(',');
    int count = 0;
    int countTask = 0;
    foreach (var item in words)  //Считаем кол-во слов.
    {
        count++;
    }
    for (int i = 0; i < count; i++)   //кол-во слов согласно условию.
    {
        if (words[i].Length <= min)
        {
            countTask++;
        }
    }
    int r = 0;
    string[] textTask = new string[countTask];
    for (int j = 0; j < count; j++)   //Процесс заполнения массива.
    {
        if (words[j].Length <= min)
        {
             textTask[r] = words[j];
            r++;
        }
    }
    return textTask;
}

