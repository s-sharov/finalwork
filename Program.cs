string[] array = {"Данная", "программа", "должна", "вывести", "на", "экран", "массив", "в", "котором", "будет", "содержаться"
    , "элементы", "данного", "масива", "количество", "символов", "которых", "не", "превышает", "трех"};


string[] newArray = CreateStringArray(array);
Console.WriteLine("Имеется исходный массив: ");
PrintStringArray(array);
Console.WriteLine();
Console.WriteLine("Все элементы исходного массива, в котором символов меньше или равно 3:  ");
Console.WriteLine();
PrintStringArray(newArray);

string[] CreateStringArray(string[] oldArray)
{
    string[] arr = new string[oldArray.Length];
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if(oldArray[i].Length <= 3 )
        {
            arr[count] = oldArray[i];
            count++;
        }
    }
    return arr;
}

void PrintStringArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}