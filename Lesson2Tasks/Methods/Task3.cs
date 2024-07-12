/*Task 3: List<int> numbers = new List<int> { 1, 45, 23, 42, 67, 98, 2 }; bu listin max ededinden 1 vahid az
olan eded ile listin min ededinden 1 vahid cox olan ededin ferqini tapan funksiya yazin*/
public class Task3
{
    //Nəticəni çap edək.
    public static void PrintDifferenceElement(List<int> numbers)
    {
        int maxMinusOne = FindMaxMinusOne(numbers);
        int minPlusOne = FindMinPlusOne(numbers);
        int difference = maxMinusOne - minPlusOne;

        Console.WriteLine($"Max element minus one: {maxMinusOne}");
        Console.WriteLine($"Min element plus one: {minPlusOne}");
        Console.WriteLine($"Difference: {difference}");
    }
    //Max elementdən 1 vahid kiçik elementi tapaq və geri qaytaraq.
    static int FindMaxMinusOne(List<int> numbers)
    {
        int max = FindMax(numbers);
        return max - 1;
    }
    //Max elementi tapaq və geri qaytaraq.
    static int FindMax(List<int> numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
    //Min elementdən 1 vahid böyük elementi tapıb geri qaytaraq.
    static int FindMinPlusOne(List<int> numbers)
    {
        int min = FindMin(numbers);
        return min + 1;
    }
    //Min elementi tapıb geri qaytaraq
    static int FindMin(List<int> numbers)
    {
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }
}