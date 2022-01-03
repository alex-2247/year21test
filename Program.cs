
// Подзадача 1. Задать массив А
// Длину массива возьмем 25 элементов. Это достаточно много чтоб поиграться,
// но не слишком, чтоб заипаться.
void FillSourceArray(int[] array, int minValue, int maxValue)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(minValue, maxValue);
        //Console.Write($"i={index}:{array[index]}; ");
    }
}
// метод печати массива
void PrintIntArrToConsole(int[] array)
{
    Console.WriteLine("");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]}; ");
    }
}