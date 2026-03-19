namespace students_app;

internal class Program
{
    static void Main(string[] args)
    {
        int[] notes = new int[10];

        for (int i = 0; i < notes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. Notu Giriniz:");
            notes[i] = Convert.ToInt32(Console.ReadLine());
        }

        double average = CalculateAverage(notes); //ortlama hesaplama fonk.

        (int minNote, int maxGrade) = FindMinMax(notes);//min-max bulan  fonk.

        int count = CountAboveAverage(notes, average); // ortalama notun üzerinde kaç not olduğunu bulan fonk.
        string list = ListAboveAverage(notes, average);



        Console.WriteLine("Girilen Notlar:");
        Console.WriteLine($"{string.Join(",", notes)}");


        Console.WriteLine($"\nOrtalama: {average}");
        Console.WriteLine($"\n En Düşük Not: {minNote:F2}");
        Console.WriteLine($"\n En Yüksek Not: {maxGrade:F2}");
        Console.WriteLine($"\n Ortalamanın Üstündeki Not Sayısı: {count}");
        Console.WriteLine($"\n Ortalamanın Üstündeki Not: {list}");
    }

    private static string ListAboveAverage(int[] notes, double average)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < notes.Length; i++)
        {
            if (notes[i] > average)
            {
                result.Add(notes[i]);
            }
        }

        return string.Join(", ", result);
    }

    private static double CalculateAverage(int[] notes)
    {
        if (notes == null || notes.Length == 0)
        {
            return 0;
        }
        int sum = 0;
        for (int i = 0; i < notes.Length; i++)
        {
            sum += notes[i];
        }
        return (double)sum / notes.Length;

    }

    private static (int minNote, int maxGrade) FindMinMax(int[] notes)
    {
        int min = notes[0];
        int max = notes[0];

        foreach (var n in notes)
        {
            if (n < min) min = n;
            if (n > max) max = n;
        }
        return (min, max);
    }

    private static int CountAboveAverage(int[] notes, double average)
    {
        int count = 0;
        int i = 0;
        while (i < notes.Length)
        {
            if (notes[i] > average) count++;
            i++;
        }
        return count;
    }

}
