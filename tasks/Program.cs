// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

/*
int [] CreateNewArray (int size, int minV, int maxV)
{
    int [] arrayNew = new int [size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = new Random().Next(minV, maxV + 1);
    }
    return arrayNew;
}

void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
Console.WriteLine();
}

int [] ReversArray (int [] arrayRevers)
{
    int k = arrayRevers.Length;
    for (int i = 0; i < k/2; i++)
    {
        int temp = arrayRevers[i];
        arrayRevers[i] = arrayRevers[k - 1 - i];
        arrayRevers[k - 1 - i] = temp;
    }
    return arrayRevers;
}

int sizeArray = 7;
int minValArr = -9;
int maxValArr = 9;

int [] createdArray = CreateNewArray(sizeArray, minValArr, maxValArr);
ShowArray(createdArray);
int [] reversedArray = ReversArray(createdArray);
ShowArray(reversedArray);
*/

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11

/*
int CountOfBinar(int userNum)
{
    int countOfDigit = 0;
    while (userNum != 0)
    {
        userNum = userNum / 2;
        countOfDigit++;
    }
    return countOfDigit;
}

void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
Console.WriteLine();
}

int [] ConversionToBinar(int numToConvert)
{
    int n = CountOfBinar(numToConvert);
    int[] binarNum = new int[n];

    for (int i = n - 1; i >= 0; i--)
    {
        binarNum[i] = numToConvert % 2;
        numToConvert /= 2;
    }
    return binarNum;
}

int userNumber = 75;
int countElem = CountOfBinar (userNumber);
int [] binar  = ConversionToBinar(userNumber);
ShowArray(binar);
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).

/*
void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
Console.WriteLine();
}

void Fibonacci (int n, int a, int b)
{
    int [] arrFib = new int [n];
    arrFib[0] = a;
    arrFib[1] = b;
    for (int i = 2; i < n; i++)
    {
        arrFib[i] = arrFib[i - 1] + arrFib[i - 2];
    }
    ShowArray(arrFib);
}

Console.WriteLine("Enter count of elements: ");
int userCount = Convert.ToInt32(Console.ReadLine());

if (userCount > 2)
{
    Console.WriteLine("Enter 1st element: ");
    int user1stNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 2nd element: ");
    int user2ndNum = Convert.ToInt32(Console.ReadLine());

    Fibonacci(userCount, user1stNum, user2ndNum);
}
else Console.WriteLine("Wrong input ");
*/

// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.

/*
void Triangle (int firstSide, int secondSide, int thirdSide)
{
    int [] sides = {firstSide, secondSide, thirdSide};
    if (sides[0] < sides[1] + sides[2] && sides[1] < sides[0] + sides[2] && sides[2] < sides[1] + sides[0])
    Console.WriteLine($"Triangle {sides[0]}, {sides[1]}, {sides[2]} exist!");
    else Console.WriteLine($"Triangle {sides[0]}, {sides[1]}, {sides[2]} do NOT exist!");
}

Triangle (10, 40, 45);
*/