 //Задайте массив из вещественных чисел с ненулевой дробной частью. 
 //Найдите разницу между максимальным и минимальным элементов массива.


double[] array = new double[10];
Random rand = new Random(10);
for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100) + rand.NextDouble();
        if (array[i] != 0)
                Console.WriteLine( array[i] + " ");     
    }
  
    // Инициализируем переменные для хранения максимального и минимального элементов
        double max = array[0];
        double min = array[0];

    // Находим максимальный и минимальный элементы массива
        for (int i = 0; i < array.Length; i++)
        {
            
            if (array[i] > max)
            {
            max = array[i];
            }

            if (array[i] < min)
            {
            min = array[i];
            }
        }

    // Выводим Максимальное и Минимальное число
    Console.WriteLine();

    Console.WriteLine("Минимальное число =" + min);
    Console.WriteLine("Максимальное число =" + max);
          
    // Находим разницу между максимальным и минимальным числом.
    double difference = max - min;

    // Выводим результат
    Console.WriteLine("Разница между максимальным и минимальным числами =" + difference);
