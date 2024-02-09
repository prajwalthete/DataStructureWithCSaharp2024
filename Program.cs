
namespace a;
public class Program
{

    // Bubble Sort algorithm implementation
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                }
            }
        }

    }
    static void Main(string[] args)
    {
        int[] arr = { 66, 88, 11, 22, 35, };
        BubbleSort(arr);
        Console.WriteLine("Array after Sorting " + string.Join(" ,", arr));

    }
}
