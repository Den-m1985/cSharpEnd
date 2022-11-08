
//Написать программу, которая из имеющегося массива строк
//формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоватся коллекциями, лучше обойтись исключительно массивами.
//Exampls:
//["helo","2","world",":-)"]   -> ["2",":-)"]
//["1234","1567","-2","computer science"]   -> ["2"]
//["Russia","Denmark","Kazan"]   -> []



string value = "helo,2,world,:-)";
//string value = "1234,1567,-2,computer science";
//string value = "Russia,Denmark,Kazan";

string[] words = value.Split(','); //Разделяем строку на слова или набор символов через указанный разделитель.
int count = 0;
foreach (var item in words)  //Считаем кол-во слов.
{
    count++;
    Console.WriteLine(item);
}

int min = 3;  //3 символа из условия задачи.
int countTask = 0;
for (int a = 0; a < count; a++)  //Находим кол-во слов для массива.
{
    if (words[a].Length <= min)
    { 
       countTask++;
    }
}

int r = 0;
string[] abc = new string[countTask];
for (int q = 0; q < count; q++)   //Процесс заполнения массива.
{
    if (words[q].Length <= min)
    {
        abc[r] = words[q];
        r++;
    }
}
Console.WriteLine();
Console.Write("[" + String.Join(", ", abc) + "]");

