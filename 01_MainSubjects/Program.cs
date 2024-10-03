using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Merhaba Dünya"); // alt satıra geçer

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //// CTRL+D ile satırı bir sonraki satıra kopyalayabilirsin.
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****"); 
            #endregion

            #region String Değişkenler

            //string
            // Değişken_türü değişken_adı;

            //string name;
            //name = "Ümmühan"; // atama yaptık
            //Console.WriteLine(name); // atadığımız değişkeni console'a yazdırdık

            //// değişkenler camelCase olarak yazılır.
            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city;
            //passengerName = "Ali";
            //passengerSurname = "Çınar";
            //passengerPhone = "+90 500 400 30 20";
            //passengerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------------");

            //passengerName = "Ayşegül"; // bu atamadan sonra artık ismi Ali değil Ayşegül olur.
            //passengerSurname = "Kaya";
            //passengerPhone = "+90 400 300 80 70";
            //passengerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------------");
            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            //Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            //Console.WriteLine("-----Kola: " + cokePrice + "TL");
            //Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");
            //Console.WriteLine("-----Kızartma: " + friesPrice + "TL");
            //Console.WriteLine("-----Su: " + waterPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyatı ****");


            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;

            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            //Console.WriteLine();

            //int totalPrice = totalCokePrice + totalHamburgerPrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: "+totalPrice);
            #endregion

            Console.Read();
        }
    }
}