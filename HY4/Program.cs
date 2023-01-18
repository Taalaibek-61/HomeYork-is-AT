/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
 возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
 
 /*int MethodK( int numberA,int numberB)
 {
    int a = numberA;
    int b = numberB;
    int s = 1;
      for (int count = 1; count <= b; count++)
          s*= a ;
      return s;
        
 }
 Console.WriteLine("Введите цифру А ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите цифру В ");
 int b = Convert.ToInt32(Console.ReadLine());
 int result =  MethodK(a,b);

Console.WriteLine(result);*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
 
int GSum(int number)
{
  int sum = 0;

  while(number != 0)
  {
  sum  = sum + number % 10;
  number = number / 10;
  }
  return sum;
}

Console.Clear();

Console.Write("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());  


int result = GSum(a);
Console.Write(result);

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит
 их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

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
