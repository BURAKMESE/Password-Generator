using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Password Length: ");
        int uzunluk = Convert.ToInt32(Console.ReadLine());

        string sifre = SifreOlustur(uzunluk);
        Console.WriteLine("Generated Password: " + sifre);

        Console.ReadKey();
    }

    static string SifreOlustur(int uzunluk)
    {
        const string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";
        StringBuilder sb = new StringBuilder();

        Random random = new Random();
        for (int i = 0; i < uzunluk; i++)
        {
            int index = random.Next(karakterler.Length);
            sb.Append(karakterler[index]);
        }

        return sb.ToString();
    }
}
