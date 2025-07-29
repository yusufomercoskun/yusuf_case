using Microsoft.Azure.Devices.Common;


Random random = new Random();
int randomSayi = random.Next(0, 100);
string cevap;
int cevapInt;
int i = 1;
Console.Write("oyun başlasın\n");
Console.Write("sayıyı tahmin edin: ");

while (true)
{
    cevap = Console.ReadLine();
    cevapInt = Convert.ToInt16(cevap);

    if (cevapInt == randomSayi)
    {
        Console.Write("cevap doğru. oyun bitti.");
        Console.WriteLine(i.ToString() + ". denemede bildin.");
        break;
    }
    else if (cevapInt < randomSayi)
    {
        Console.Write("\ndaha büyük sayı gir: ");
    }
    else
    {
        Console.Write("\ndaha küçük sayı gir: ");
    }

    i++;
}