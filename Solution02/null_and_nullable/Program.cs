
var age = 25;
var name = "Ali";

Console.WriteLine("age değişkenin tipi : " + age.GetType());
Console.WriteLine("name değişkenin türü: " + name.GetType());

string? nullable = null;

Console.WriteLine("Büyük Harf " + nullable?.ToUpper());

Console.WriteLine("Kullanıcı adı:" + (nullable ?? "Bilinmiyor"));
Console.WriteLine("Yaş:" + age);

Console.ReadKey();