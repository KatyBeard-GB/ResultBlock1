// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символам.

string[] GetArray(int value){
    string[] array = new string[value];
    for (int i = 0; i < value; i++){
        Console.Write($"Введите {i+1} строку: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

string[] NewArraySymbols(string[] array, int maxSymbols){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length < maxSymbols+1) count++;
    }
    if (count == 0) {
        string[] arrayEmpty = new string[1];
        arrayEmpty[0] = string.Empty;
        return arrayEmpty;
    }
    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length < maxSymbols+1) {
            result[count] = array[i];
            count++;}
    }
    return result;
}

Console.Write("Сколько строк вы хотите ввести? ");
int rows = int.Parse(Console.ReadLine()!);

string[] array = GetArray(rows);
PrintArray(array);
Console.Write(" -> ");

int maxSymbols = 3;
string[] newArray = NewArraySymbols(array,maxSymbols);
PrintArray(newArray);