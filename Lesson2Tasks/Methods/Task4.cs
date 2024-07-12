/*Task 4:      
int[,] matrix = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 } }; bu matrixsin setirlerin sutun formatina getir ve tek sirada duran 
                sutunlarla cut sirada duran sutunlarin yerini deyis*/
public class Task4
{
    //Nəticəni çap edək.
    public static void PrintChangeColumns(int[,] matrix)
    {
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int[,] transposedMatrix = TransposeMatrix(matrix);
        Console.WriteLine("\nTransposed Matrix:");
        PrintMatrix(transposedMatrix);

        SwapColumns(transposedMatrix);
        Console.WriteLine("\nMatrix after swapping columns:");
        PrintMatrix(transposedMatrix);
    }
    //Matrisin setirlerin sutun formatina getirək.
    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }
    //Tək sırada duran sütunlarla cüt sırada duran sütunların yerini dəyişək.
    static void SwapColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int j = 0; j < cols; j += 2)
        {
            if (j + 1 < cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    //Matrisin düzgün şəkildə çap olunmasını təmin edək.
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}