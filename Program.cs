// Задача: Написать программу, которая из имеющегося массива целых чисел
// формирует массив из четных чисел. Первоначальный массив можно ввести с
// клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// метод формирования исходного массива.
void FillSourceArray(int[] array, int minValue, int maxValue)
{
    for (int index = 0; index < array.Length; index++)
        array[index] = new Random().Next(minValue, maxValue);
}

// метод печати массива
void PrintIntArrToConsole(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        Console.Write($"{array[index]}; ");
    Console.WriteLine("");
}

// метод заполнения второго массива чётными элементами
int OddHonest(int[] arrayA, int[] arrayB)
{
    int indexB = 0;
    for (int indexA = 0; indexA < arrayA.Length; indexA++)
    {
        if ((arrayA[indexA] % 2) == 0)    //текущий элемент чётный
        {
            arrayB[indexB] = arrayA[indexA];
            indexB++;
        }
    }
    return indexB;
}

// основной кодоблок о чётности
int sizeArray = 25;
int[] arrA = new int[sizeArray];
int[] arrB = new int[sizeArray];
FillSourceArray(arrA, 10, 99);
PrintIntArrToConsole(arrA);
sizeArray = OddHonest(arrA, arrB);
Console.WriteLine($"SizeOfB={sizeArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB);
