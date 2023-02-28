// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// клина которых меньше или равна 3 символа. 
//Первоначальный массив задан на старте выполнения алгоритма.

string[] array1 = new string[5] {"Kazan", "2", "hello", "world", ":-)"};
string[] array2 = new string[array1.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i]+",";
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
     Console.Write("]");
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);