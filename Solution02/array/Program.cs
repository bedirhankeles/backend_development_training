//dizi tanımı
/*
int[] numbers = new int[5];


numbers[0] = 10;
numbers[1] = 11;
numbers[2] = 12;
numbers[3] = 13;
numbers[4] = 14;

//for

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i}. imdis değerindeki değer: {numbers[i]}");
}

Console.WriteLine("Tersten sıralama :\n");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{i}. imdis değerindeki değer: {numbers[i]}");
}

*/

//foreach
/*
int[] numbers = { 10, 20, 30, 40, 50 };
int sum = 0;
foreach (var item in numbers)
{
    sum += item;
}
double average = (double)sum / numbers.Length;
Console.WriteLine($"Ortalama: {average:F2}");


*/

/*
//while

int[] numbers = { 2, 10, 15, -30, 25 };
int i = 0;
while (i < numbers.Length)
{
    if (numbers[i] < 0)
    {
        i++;
        continue;
    }
    Console.WriteLine($"Pozitif Sayı: {numbers[i]}");
    i++;
}
*/

//do-while
/*
int[] notes = new int[3];

int i = 0;
double ort = 0;
do
{
    Console.WriteLine("Not Giriniz: ");
    notes[i] = Convert.ToInt32(Console.ReadLine());
    ort += notes[i];
    i++;
} while (i < notes.Length);
Console.WriteLine("Girilen Notlar: ");
ort = ort / notes.Length;
foreach (int note in notes)
{
    Console.WriteLine(note);
}
Console.WriteLine("Ortalama: " + ort);
*/

