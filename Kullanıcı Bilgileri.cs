using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıBilgisiAlmaOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan Ad, Soyad, Öğrenci No ve Cep Tel No alınacak.


            Console.WriteLine("Adınızı Yazın:");

            string ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Yazın:");
            
            string soyad = Console.ReadLine();
            
            Console.WriteLine("Öğrenci No'nuzu Yazın:");
            
            string ogrenciNo = Console.ReadLine();
            
            Console.WriteLine("Cep Telefon Numaranızı Yazın Yazın:");

            string cepTel = Console.ReadLine();


            // Alınan Bilgiler Birlikte Görüntülecek.


            Console.WriteLine("KULLANICI BİLGİLERİ:");
            Console.WriteLine("Kullanıcı Adı: " +ad);
            Console.WriteLine("Kullanıcı Soyadı: " +soyad);
            Console.WriteLine("Kullanıcı Öğrenci No: " +ogrenciNo);
            Console.WriteLine("Kullanıcı Cep Telefonu Numarası: " +cepTel);

            //Terminalin ekranda Kalması için.

            Console.ReadLine();


        }
    }
}
