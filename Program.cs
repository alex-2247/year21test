// метод формирования исходного массива. Длину назначим 25 элементов. 
// Это достаточно много чтоб поиграться, но не слишком, чтоб заипаться.
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

// метод формирования второго массива чётными элементами
// Создать на его основе масcив B, отбрасывая те, которые нечётные
int OddHonest(int[] arrayA, int[] arrayB)
{
    int indexB = 0;
    for (int indexA = 0; indexA < arrayA.Length; indexA++)
    {
        if ((arrayA[indexA] % 2) == 0)    //текущий нечётный
        {
            arrayB[indexB] = arrayA[indexA];
            indexB++;
        }
    }
    return indexB;
}