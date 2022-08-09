string[] array = new string[5];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элементы массива: ");
    array[i] = Console.ReadLine();
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("Элементы из трёх символов: ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i] + "\t");
    }
}
Console.WriteLine();