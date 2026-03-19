
/*
//kur örneği
var dollarRate = 40.70m;
decimal eurotRate = 47.50m;
decimal goldRate = 4400m;
DateTime rateDate = DateTime.Now;

Console.WriteLine("TL miktarını giriniz: ");
decimal amountTl = Convert.ToDecimal(Console.ReadLine());




Console.WriteLine("\n Dönüştürme Seçenekleri: ");
Console.WriteLine("1-Dolar");
Console.WriteLine("2-Euro");
Console.WriteLine("3-Altın");

Console.WriteLine("\n Seçim Yapınız (1-3)");
int choice = Convert.ToInt32(Console.ReadLine());


decimal result = 0m;
string currenyName = "";

switch (choice)
{
    case 1:
        result = amountTl / dollarRate;
        currenyName = "USD";
        break;
    case 2:
        result = amountTl / eurotRate;
        currenyName = "EUR";
        break;
    case 3:
        result = amountTl / goldRate;
        currenyName = "Gram Altın";
        break;

    default:
        Console.WriteLine("Geçersiz Tuşlama");
        return;
}
Console.WriteLine($"\nTarih:{rateDate} ");
Console.WriteLine($"\nGirilen Miktar:{amountTl} ");
Console.WriteLine($"\nDönüşüm Sonucu:{result:F2} {currenyName}");
//Console.WriteLine(dollarRate.GetType());


*/

/*
Console.WriteLine("İşaretsiz byte(0-255");
Console.WriteLine($"Min Değer: {byte.MinValue},Max Değer: {byte.MaxValue}");

Console.WriteLine("sbyte(-128 -127");
Console.WriteLine($"Min Değer: {sbyte.MinValue},Max Değer: {sbyte.MaxValue}");


byte unsignedVal = 255;
Console.WriteLine($"Baş. değeri: {unsignedVal}");
unsignedVal++;
Console.WriteLine($"Taşma sonrası değer: {unsignedVal}");
*/


/*


//değer tip

int num1 = 10;
int num2 = 20;

Console.WriteLine($"metot çağrısı öncesi: num1={num1} num2={num2}");
SwapNumbers(num1, num2);
Console.WriteLine($"metot çağrısı sonrası: num1={num1} num2={num2}");


//referans tip
int[] numbers = { 10, 20 };
Console.WriteLine($"metot çağrısı öncesi: num1={numbers[0]} num2={numbers[1]}");

SwapArray(numbers);
Console.WriteLine($"metot çağrısı sonrası: num1={numbers[0]} num2={numbers[1]}");
void SwapArray(int[] numbers)
{
    int temp = numbers[0];
    numbers[0] = numbers[1];
    numbers[1] = temp;
}

void SwapNumbers(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}

*/

/*
object data = "Merhaba";
int a = 50;
data = a;
if (data is string)
{
    Console.WriteLine("Veri Türü String'dir");
}
else if (data is int)
{
    Console.WriteLine("Veri Türü int'dir");
}
else
{
    Console.WriteLine("Veri Başka Tiptedir");
}
*/