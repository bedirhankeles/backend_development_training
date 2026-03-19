/*
 // Değişkenler
 * int age = 25;
Console.WriteLine($"Yaş : {age}");

age += 1;
Console.WriteLine($"Yeni Yaş: {age}");


double piValue = 3.14;
Console.WriteLine($"Pi Sayısı: {piValue} ");

var city = "Samsun";
Console.WriteLine($"Şehir : {city}");


var today = DateTime.Now;
Console.WriteLine($"Bugünün Tarihi: {today}");



*/

/*
// Aritmetik İşlemeler

int sum = 5 + 3;
Console.WriteLine($"Toplam  : {sum}");

int a = 5;
int b = 3;

Console.WriteLine($"{a}-{b} = {a - b}");

int c = a * b;
Console.WriteLine($"{a}*{b} = {c}");

double d = (double)a / b;
Console.WriteLine($"{a}/{b} = {d}");


*/


/*
//karşılaştırma operatörleri

Console.WriteLine("Birinci tam sayıyı giriniz: ");
int? a = int.Parse(Console.ReadLine()!);

Console.WriteLine("İkinci tam sayıyı giriniz: ");
int? b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"{a} != {b} = {a != b}");
Console.WriteLine($"{a} > {b} = {a > b}");
Console.WriteLine($"{a} < {b} = {a < b}");
Console.ReadKey();



*/

/*

//mantıksal operatörler


Console.WriteLine("Yaşınızı giriniz: ");
int age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Sağlık raporunuz var mı? (e/h)");
string reportInput = Console.ReadLine()!.ToLower();

bool hasHealthReport = reportInput == "e";
if (age >= 18 && hasHealthReport)
    Console.WriteLine("Ehliyet alabilirsiniz.");
else
    Console.WriteLine("Ehliyet alma şartlarını sağlamıyorsunuz");
if (age >= 18 || hasHealthReport)
    Console.WriteLine("Koşullardan en az biri sağlanıyor");
else
    Console.WriteLine("Koşullardan hiçbirini sağlamıyorsunuz");

*/

/*
// girilen sayılara göre bir örnek

Console.WriteLine("1. sayıyı giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = a + b;
int f = a - b;
int c = a * b;
double s = (double)a / b;
Console.WriteLine($" Toplamları: {sum} \n Farkları: {f} \n Çarpımları: {c} \n Bölümleri: {s}");

*/


/*
//vize -final notu hesaplama örneği

Console.WriteLine(" Vize notunuzu giriniz: ");
int vize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Final notunuzu giriniz: ");
int final = Convert.ToInt32(Console.ReadLine());

double ort = (double)(vize * 0.4) + (final * 0.6);

string sonuc = ort >= 50 ? "Geçti" : "Kaldı";
Console.WriteLine(sonuc);

*/