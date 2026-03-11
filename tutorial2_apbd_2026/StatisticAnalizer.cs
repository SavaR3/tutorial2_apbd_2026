using Microsoft.VisualBasic.CompilerServices;

namespace tutorial2_apbd_2026;

public class StatisticAnalizer
{
    private static List<int> listOfIntegers = new List<int>();
    private static int average;
    private static int max;
    private static int min;
    private static int sum;

    static double CalculateAverage(List<int> OfIntegers)
    {
        for (int i = 0; i < OfIntegers.Count; i++)
        {
            sum += OfIntegers[i];
        }
        return sum/= OfIntegers.Count;
    }
}