// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = {"Hello", "2", "world", ":-)"};
int sum = FindAmountElements(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Колличечтво элементов в массиве длинной меньее 4х символов = {sum}");
string[] newArray = NewArray(array, sum);
PrintArray(newArray);

int FindAmountElements(string[] arr)
{   
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) sum++;
    }
    return sum;
}

string[] NewArray(string[] arr, int size)
{
    string[] newArray = new string[size];
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) 
        {
            newArray[j] = arr[i];
            j++;
        }    
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}