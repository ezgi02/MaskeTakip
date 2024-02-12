//See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//NewMethod();
Vatandas vatandas1= new Vatandas();
vatandas1.ad = "ahmet";

Console.ReadLine();

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;


    Console.WriteLine(tutar * 1.18);
}

class Vatandas
{

    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}

