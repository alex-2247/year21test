// Задача: Написать программу, которая из имеющегося массива целых чисел
// формирует массив из четных чисел. Первоначальный массив можно ввести с
// клавиатуры, либо сгенерировать случайным образом. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

В первом значимом коммите, после стартовых, пишу метод формирования исходного массива. Он принимает три аргумента - сам массив, минимальное и максимальное значение элементов. Далее в теле метода запускается цикл, и заполняются элементы оператором Random().Next()

В следующем коммите добавил метод печати элементов массива в консоль оператором Write. Это не совсем красивое решение, но на нашем уровне решения задачи, сойдет.

Следующий коммит посвящен центральному методу формирования второго массива из четных элементов первого. В цикле смотрим, четный ли элемент. Если да, то копируем во второй массив. Метод возвращает число скопированных четных элементов.

Финальный программный коммит для добавления блока кода "верхнего уровня", который инициализирует все массивы, переменные, и в нужной последовательности вызывает вышеописанные методы. В конце размер нового массива обрезается в соответствии с числом заполненных четных элементов.

После проверки и учета замечаний, переработал раздел Блок-схемы. Удалил из проекта фото рукописной блоксхемы, создал заново блоксхему в специализированном приложении, выгрузил в PNG-картинку, и добавил её в проект. Также внёс ряд косметических поправок в Program.cs, не изменяющих основной функционал, но делающих код немного короче и чище.