using System;

class Tasks
{
    //задача 1.2
    public int sumLastNums(int x)
    {
        return (x % 10) + ((x / 10) % 10);
    }

    //задача 1.4
    public bool isPositive(int x)
    {
        if (x >= 0)
        {
            return true;
        }
        return false;
    }

    //задача 1.6
    public bool isUpperCase(char x)
    {
        return char.IsUpper(x);
    }

    //задача 1.8
    public bool isDivisor(int a, int b)
    {
        if (a % b == 0 || b % a == 0)
        {
            return true;
        }
        return false;
    }

    //задача 1.10
    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }

    //задача 2.2
    public double safeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }
        return x / y;
    }

    //задача 2.4
    public String makeDecision(int x, int y)
    {
        if (x == y)
        {
            return $"{x}={y}";
        }
        if (x > y)
        {
            return $"{x}>{y}";
        }
        return $"{x}<{y}";
    }

    //задача 2.6
    public bool sum3(int x, int y, int z)
    {
        if (x + y == z || x + z == y || y + z == x) { return true; }
        return false;
    }

    //задача 2.8
    public String age(int x)
    {
        if (x % 10 == 1 && x != 11) { return $"{x} год"; }
        if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && (x % 10 != 12 || x % 10 != 13 || x % 10 != 14)) { return $"{x} года"; }
        return $"{x} лет";
    }

    //задача 2.10
    public void printDays(String x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine($"{x} - не день недели!");
                break;
        }
    }

    //задача 3.2
    public String reverseListNums(int x)
    {
        string s = "";
        for (; x >= 0; x--)
        {
            s += $"{x} ";
        }
        return s;
    }

    //задача 3.4
    public int pow(int x, int y)
    {
        int p = 1;
        for (int i = 0; i < y; i++)
        {
            p *= x;
        }
        return p;
    }

    //задача 3.6
    public bool equalNum(int x)
    {
        if (x < 0) { x = -x; }
        while (x > 9)
        {
            if (x % 10 != x / 10 % 10) { return false; }
            x /= 10;
        }
        return true;
    }

    //задача 3.8
    public void leftTriangle(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j =i+1; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //задача 3.10
    public void guessGame()
    {
        Random random = new Random();
        int r = random.Next(0, 10);
        int i = 1;
        bool flag = true;

        Console.WriteLine("Введите число от 0 до 9:");
        string input = Console.ReadLine();
        if (int.Parse(input) == r)
        {
            flag = false;
        }

        while (flag)
        {
            Console.WriteLine("Вы не угадали, введите число от 0 до 9");
            input = Console.ReadLine();
            i++;
            if (int.Parse(input) == r)
            {
                flag = false;
            }
        }
        Console.WriteLine("Вы угадали!");
        Console.WriteLine($"Вы отгадали число за {i} попытки");

    }

    //задача 4.2
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length-1; i >= 0; i--)
        {
            if (arr[i] == x) { return i; }
        }
        return -1;
    }

    //задача 4.4
    public int[] add(int[] arr, int x, int pos)
    {
        int[] m = new int[arr.Length + 1];

        if (pos > arr.Length - 1) { pos = arr.Length - 1; }

        for (int i = 0; i < pos; i++)
        {
            m[i] = arr[i];
        }

        m[pos] = x;

        
        for (int i = pos; i < arr.Length; i++)
        {
            m[i + 1] = arr[i];
        }
        return m;
    }

    //задача 4.6
    public void reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }
    }

    //задача 4.8
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] arr = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            arr[arr1.Length + i] = arr2[i];
        }

        return arr;
    }

    //задача 4.10
    public int[] deleteNegative(int[] arr)
    {
        int size = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) { size++; }
        }

        int[] positive_arr = new int[size];
        int j = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                positive_arr[j] = arr[i];
                j++;
            }
        }
        return positive_arr;
    }

}
