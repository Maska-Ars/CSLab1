using System;

class TestTasks
{
    private Tasks tasks = new Tasks();
    private UserInput input = new UserInput();

    // Тест задания 1.2
    public void test_1_2()
    {
        Console.WriteLine("Тест задания 1.2");
        for (int i = 0; i < 3; i++)
        {
            int n = input.intInput(true);
            Console.WriteLine($"Результат: {tasks.sumLastNums(n)}");
        }
        Console.WriteLine("Тест задания 1.2 завершен");
        Console.WriteLine();
    }

    // Тест задания 1.4
    public void test_1_4()
    {
        Console.WriteLine("Тест задания 1.4");
        for (int i = 0; i < 3; i++)
        {
            int n = input.intInput();
            Console.WriteLine($"Результат: {tasks.isPositive(n)}");
        }
        Console.WriteLine("Тест задания 1.4 завершен");
        Console.WriteLine();
    }

    // Тест задания 1.6
    public void test_1_6()
    {
        Console.WriteLine("Тест задания 1.6");
        for (int i = 0; i < 3; i++)
        {
            char ch = input.charInput();
            Console.WriteLine($"Результат: {tasks.isUpperCase(ch)}");
        }
        Console.WriteLine("Тест задания 1.6 завершен");
        Console.WriteLine();
    }

    // Тест задания 1.8
    public void test_1_8()
    {
        Console.WriteLine("Тест задания 1.8");
        for (int i = 0; i < 3; i++)
        {
            int a = input.intInput();
            int b = input.intInput();
            Console.WriteLine($"Результат: {tasks.isDivisor(a, b)}");
        }
        Console.WriteLine("Тест задания 1.8 завершен");
        Console.WriteLine();
    }

    // Тест задания 1.10
    public void test_1_10()
    {
        Console.WriteLine("Тест задания 1.10");
        for (int i = 0; i < 3; i++)
        {
            int a = input.intInput(false, "Введите число a: ");
            int b = input.intInput(false, "Введите число b: ");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"{a}+{b} это {tasks.lastNumSum(a, b)}");
                a = tasks.lastNumSum(a, b);
                b = input.intInput(false, "Введите число b: ");
            }
            Console.WriteLine($"Итого {tasks.lastNumSum(a, b)}");

        }
        Console.WriteLine("Тест задания 1.10 завершен");
        Console.WriteLine();
    }

    // Тест задания 2.2
    public void test_2_2()
    {
        Console.WriteLine("Тест задания 2.2");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(false, "Введите делимое: ");
            int y = input.intInput(false, "Введите делитель: ");
            Console.WriteLine($"Результат: {tasks.safeDiv(x, y)}");
        }
        Console.WriteLine("Тест задания 2.2 завершен");
        Console.WriteLine();
    }

    // Тест задания 2.4
    public void test_2_4()
    {
        Console.WriteLine("Тест задания 2.4");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(false, "Введите 1-ое число: ");
            int y = input.intInput(false, "Введите 2-ое число: ");
            Console.WriteLine($"Результат: {tasks.makeDecision(x, y)}");
        }
        Console.WriteLine("Тест задания 2.4 завершен");
        Console.WriteLine();
    }

    // Тест задания 2.6
    public void test_2_6()
    {
        Console.WriteLine("Тест задания 2.6");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(false, "Введите 1-ое число: ");
            int y = input.intInput(false, "Введите 2-ое число: ");
            int z = input.intInput(false, "Введите 3-е число: ");
            Console.WriteLine($"Результат: {tasks.sum3(x, y, z)}");
        }
        Console.WriteLine("Тест задания 2.6 завершен");
        Console.WriteLine();
    }

    // Тест задания 2.8
    public void test_2_8()
    {
        Console.WriteLine("Тест задания 2.8");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(true, "Введите количество лет: ");
            Console.WriteLine($"Результат: {tasks.age(x)}");
        }
        Console.WriteLine("Тест задания 2.8 завершен");
        Console.WriteLine();
    }

    // Тест задания 2.10
    public void test_2_10()
    {
        Console.WriteLine("Тест задания 2.10");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Введите день недели: ");
            string day = Console.ReadLine();
            Console.WriteLine($"Результат:");
            tasks.printDays(day);
        }
        Console.WriteLine("Тест задания 2.10 завершен");
        Console.WriteLine();
    }

    // Тест задания 3.2
    public void test_3_2()
    {
        Console.WriteLine("Тест задания 3.2");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(true);
            Console.WriteLine($"Результат: {tasks.reverseListNums(x)}");
        }
        Console.WriteLine("Тест задания 3.2 завершен");
        Console.WriteLine();
    }

    // Тест задания 3.4
    public void test_3_4()
    {
        Console.WriteLine("Тест задания 3.4");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(false, "Введите основание степени: ");
            int y = input.intInput(false, "Введите степень: ");
            Console.WriteLine($"Результат: {tasks.pow(x, y)}");
        }
        Console.WriteLine("Тест задания 3.4 завершен");
        Console.WriteLine();
    }

    // Тест задания 3.6
    public void test_3_6()
    {
        Console.WriteLine("Тест задания 3.6");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput();
            Console.WriteLine($"Результат: {tasks.equalNum(x)}");
        }
        Console.WriteLine("Тест задания 3.6 завершен");
        Console.WriteLine();
    }

    // Тест задания 3.8
    public void test_3_8()
    {
        Console.WriteLine("Тест задания 3.8");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(true, "Введите высоту треугольника: ");
            Console.WriteLine($"Результат:");
            tasks.leftTriangle(x);
        }
        Console.WriteLine("Тест задания 3.8 завершен");
        Console.WriteLine();
    }

    // Тест задания 3.10
    public void test_3_10()
    {
        Console.WriteLine("Тест задания 3.8");
        for (int i = 0; i < 3; i++)
        {
            tasks.guessGame();
        }
        Console.WriteLine("Тест задания 3.8 завершен");
        Console.WriteLine();
    }

    // Тест задания 4.2
    public void test_4_2()
    {
        Console.WriteLine("Тест задания 4.2");
        for (int i = 0; i < 3; i++)
        {
            int[] arr = input.randomArrInput();
            Console.WriteLine("Массив: ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            int n = input.intInput(false, "Введите элемент, который необходимо найти: ");
            Console.WriteLine($"Результат: {tasks.findLast(arr, n)}");

        }
        Console.WriteLine("Тест задания 4.2 завершен");
        Console.WriteLine();
    }

    // Тест задания 4.4
    public void test_4_4()
    {
        Console.WriteLine("Тест задания 4.4");
        for (int i = 0; i < 3; i++)
        {
            int[] arr = input.randomArrInput();

            Console.Write("Массив: ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();

            int n = input.intInput(false, "Введите значение, которое необходимо вставить: ");
            int pos = input.intInput(true, "Введите позицию,в котороу необходимо вставить: ");

            Console.Write($"Результат: ");
            arr = tasks.add(arr, n, pos);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Тест задания 4.4 завершен");
        Console.WriteLine();
    }

    // Тест задания 4.6
    public void test_4_6()
    {
        Console.WriteLine("Тест задания 4.6");
        for (int i = 0; i < 3; i++)
        {

            int[] arr = input.randomArrInput();

            Console.Write("Массив: ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();
            Console.Write($"Результат: ");
            tasks.reverse(arr);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Тест задания 4.6 завершен");
        Console.WriteLine();
    }

    // Тест задания 4.8
    public void test_4_8()
    {
        Console.WriteLine("Тест задания 4.8");
        for (int i = 0; i < 3; i++)
        {

            int[] arr1 = input.randomArrInput();
            int[] arr2 = input.randomArrInput();

            Console.Write("Массив 1: ");
            for (int j = 0; j < arr1.Length; j++)
            {
                Console.Write($"{arr1[j]} ");
            }
            Console.WriteLine();

            Console.Write("Массив 2: ");
            for (int j = 0; j < arr2.Length; j++)
            {
                Console.Write($"{arr2[j]} ");
            }
            Console.WriteLine();

            Console.Write($"Результат: ");
            int[] arr = tasks.concat(arr1, arr2);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Тест задания 4.8 завершен");
        Console.WriteLine();
    }

    // Тест задания 4.10
    public void test_4_10()
    {
        Console.WriteLine("Тест задания 4.10");
        for (int i = 0; i < 3; i++)
        {

            int[] arr = input.randomArrInput();
            Console.Write("Массив: ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();
            Console.Write($"Результат: ");
            arr = tasks.deleteNegative(arr);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Тест задания 4.10 завершен");
        Console.WriteLine();
    }
}