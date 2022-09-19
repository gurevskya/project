// Написали функцию для создания массива: 
void FillArray(string[] arrayFirst)
{
    for(int i = 0; i < arrayFirst.Length; i++)
        {
            Console.Write("Введите элемент: ");
            arrayFirst[i] = Convert.ToString(Console.ReadLine());
        }
}

// Написали функцию, добавляющую в новый массив все элементы из старого, количество символов в которых меньше либо равно 3:
void NewArray(string[] arrayFirst, string[] arraySecond)
{
     int count = 0;
     for(int i = 0; i < arrayFirst.Length; i++)
        {
            if(arrayFirst[i].Length <= 3)
                {
                    arraySecond[count] = arrayFirst[i];
                    count ++;
                }
        }    
}

// Написали функцию для вывода массива:
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Создали 2 массива для заполнения, а также попросили пользователя ввести размер массива:
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayFirst = new string[size];
string[] arraySecond = new string[size];

FillArray(arrayFirst);
NewArray(arrayFirst, arraySecond);
Console.WriteLine();
PrintArray(arrayFirst);
PrintArray(arraySecond);