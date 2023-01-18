int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for(int i=0; i < size; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(length);
ShowArray(newArray);

