/*Task 1: Array verilib qarisiq arr=[7,4,2,9,12,1,2] bu arrayin cut yerde duran edelerini artan ardicilligla
duzun eger arrayde tekrar element varsa, tekrarlanmasin.*/
public class Task1
{
    //Nəticəni çap edən metod yazaq.
    public static void PrintSortedEvenIndexElemets(int[] arr)
    {
        int[] sortedUniqueEvenIndexElements = Task1.GetSortedUniqueEvenIndexElements(arr);
        Console.WriteLine("Cüt yerdə duran elementlər (artan sıra ilə):");
        foreach (int element in sortedUniqueEvenIndexElements)
        {
            Console.Write(element + " ");
        }
    }
    //cüt indekslərdə duran elementləri təkrarlanmayan və sıralanmış şəkildə geri qaytaran metod yazaq.
    static int[] GetSortedUniqueEvenIndexElements(int[] arr)
    {
        // Cüt indekslərdəki elementləri toplayaq və təkrarlanmayan elementləri əldə edək.
        int[] tempArray = new int[arr.Length / 2 + 1]; // Müvəqqəti array təyin edək.
        int count = 0;

        for (int i = 0; i < arr.Length; i += 2)
        {
            if (!Contains(tempArray, count, arr[i]))
            {
                tempArray[count] = arr[i];
                count++;
            }
        }
        // Müvəqqəti array-də olan elementləri sıralayaq.
        int[] resultArray = new int[count];
        Array.Copy(tempArray, resultArray, count);
        Sort(resultArray);

        return resultArray;
    }
    //array-də müəyyən bir dəyərin olub olmadığını yoxlayaq.
    static bool Contains(int[] arr, int length, int value)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }
        return false;
    }
    //sıralama əməliyyatını həyata keçirək.
    static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}