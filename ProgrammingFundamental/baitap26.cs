NewMethod();

static void NewMethod()
{
  


{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Kiểm tra loại tam giác");
            Console.WriteLine("2. Đọc 10 số và tính tổng, trung bình");
            Console.WriteLine("3. In bảng cửu chương");
            Console.WriteLine("4. In tam giác số");
            Console.WriteLine("5. In các mẫu hình tam giác số");
            Console.WriteLine("6. Hiển thị tổng của dãy số harmonic");
            Console.WriteLine("7. Tìm các số hoàn hảo trong một phạm vi");
            Console.WriteLine("8. Kiểm tra số nguyên tố");
            Console.WriteLine("9. Thoát");
            Console.Write("Chọn một tùy chọn (1-9): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CheckTriangleType();
                    break;
                case 2:
                    CalculateSumAndAverage();
                    break;
                case 3:
                    DisplayMultiplicationTable();
                    break;
                case 4:
                    DisplayNumberTriangle();
                    break;
                case 5:
                    DisplayPatterns();
                    break;
                case 6:
                    DisplayHarmonicSeries();
                    break;
                case 7:
                    FindPerfectNumbers();
                    break;
                case 8:
                    CheckPrimeNumber();
                    break;
                case 9:
                    Console.WriteLine("Kết thúc chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                    break;
            }
        } while (choice != 9);
    }

    // Bài 1: Kiểm tra loại tam giác
    static void CheckTriangleType()
    {
        Console.WriteLine("Nhập 3 cạnh của tam giác:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Tam giác đều (Equilateral)");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Tam giác cân (Isosceles)");
        else
            Console.WriteLine("Tam giác thường (Scalene)");
    }

    // Bài 2: Đọc 10 số và tính tổng, trung bình
    static void CalculateSumAndAverage()
    {
        int[] numbers = new int[10];
        int sum = 0;

        Console.WriteLine("Nhập 10 số:");

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        double average = sum / 10.0;
        Console.WriteLine("Tổng: " + sum);
        Console.WriteLine("Trung bình: " + average);
    }

    // Bài 3: In bảng cửu chương
    static void DisplayMultiplicationTable()
    {
        Console.Write("Nhập số nguyên: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // Bài 4: In tam giác số
    static void DisplayNumberTriangle()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    // Bài 5: In các mẫu hình tam giác số
    static void DisplayPatterns()
    {
        // Mẫu 1
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Mẫu 2
        int count = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Mẫu 3
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    // Bài 6: Hiển thị tổng của dãy số harmonic
    static void DisplayHarmonicSeries()
    {
        Console.Write("Nhập số n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        Console.WriteLine($"Tổng của dãy harmonic là: {sum}");
    }

    // Bài 7: Tìm các số hoàn hảo trong một phạm vi
    static void FindPerfectNumbers()
    {
        Console.Write("Nhập khoảng số: ");
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số hoàn hảo trong khoảng:");
        for (int i = min; i <= max; i++)
        {
            if (IsPerfect(i)) Console.WriteLine(i);
        }
    }

    static bool IsPerfect(int number)
    {
        int sum = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0) sum += i;
        }

        return sum == number;
    }

    // Bài 8: Kiểm tra số nguyên tố
    static void CheckPrimeNumber()
    {
        Console.Write("Nhập một số: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPrime(num)) Console.WriteLine($"{num} là số nguyên tố.");
        else Console.WriteLine($"{num} không phải là số nguyên tố.");
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}

}
