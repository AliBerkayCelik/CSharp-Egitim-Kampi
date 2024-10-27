using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region If Else

			//Console.Write("Lütfen Şifreyi Giriniz: ");
			//string password;
			//password=Console.ReadLine();

			//if (password == "abcd")
			//{
			//	Console.WriteLine("Şifre Doğru");
			//}
			//else
			//{
			//	Console.WriteLine("Şifre Yanlış");
			//}


			//string capital, country;
			//Console.Write("Başkenti Giriniz: ");
			//capital = Console.ReadLine();

			//Console.Write("Ülkeyi Giriniz: ");
			//country = Console.ReadLine();

			//if(capital=="ankara" && country == "türkiye")
			//{
			//	Console.Write("Veriler doğrulandı");
			//}
			//else
			//{
			//	Console.Write("Hatalı bilgi");
			//}

			//int number;
			//Console.Write("Sayı Girin: ");
			//number=int.Parse(Console.ReadLine());
			//if(number==5)
			//{
			//	Console.WriteLine("Sayı Doğru");

			//}
			//else
			//{
			//	Console.WriteLine("Sayı hatalı");
			//}


			//int exam1, exam2, exam3, average;
			//string result="Hata!";

			//Console.Write("Sınav 1: ");
			//exam1=int.Parse(Console.ReadLine());
			//Console.Write("Sınav 2: ");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.Write("Sınav 3: ");
			//exam3 = int.Parse(Console.ReadLine());

			//average = (exam1 + exam2 + exam3) / 3;
			//Console.WriteLine("Sınavların Ortalaması: " + average);

			//if (average > 0 & average<=50) 
			//{
			//	result = "sonuç vasat";

			//}
			//if(average>50 & average <= 70)
			//{
			//	result = "sonuç orta";
			//}
			//if(average>70 & average <= 84)
			//{
			//	result = "sonuç iyi";
			//}
			//if (average > 84)
			//{
			//	result = "sonuç çok iyi";
			//}

			//Console.WriteLine(result);


			//string city;
			//Console.Write("Lütfen şehir girişi yapınız: ");
			//city = Console.ReadLine();

			//if(city=="adana" | city=="ankara" | city=="bursa" | city == "trabzon")
			//{
			//	Console.WriteLine("Şehir mevcut");
			//}
			//else
			//{
			//	Console.WriteLine("Şehir mevcut değil");
			//}


			//Console.Write("Lütfen kullanıcı adını giriniz: ");
			//string username = Console.ReadLine();
			//if (username != "admin")
			//{
			//	Console.Write("bu kullanıcı adı kabul edilemez");
			//}
			//else
			//{
			//	Console.Write("Hoş geldiniz");
			//}

			#endregion

			#region Mod işlemleri

			//int number = 26;
			//int result = number % 5;

			//Console.WriteLine(result);




			//Console.Write("1.Sayıyı girin: ");
			//int number1=int.Parse(Console.ReadLine());

			//Console.Write("2.Sayıyı girin: ");
			//int number2=int.Parse(Console.ReadLine());

			//int result= number1 % number2;

			//Console.Write("1.Sayının 2. Sayıya bölümünden kalan: "+result);




			//Console.Write("Lütfen sayıyı giriniz: ");
			//int number=int.Parse(Console.ReadLine());


			//if (number % 2 == 0)
			//{
			//	Console.Write("Sayı çiftir");
			//}
			//else
			//{
			//	Console.Write("Sayı tektir");
			//}
			#endregion

			#region Char değişkenler ile karar yapıları
			//char team;
			//Console.Write("Lütfen takım sembolünü giriniz: ");
			//team=char.Parse(Console.ReadLine());

			//if(team=='g' | team == 'G')
			//{
			//	Console.Write("Galatasaray");
			//}
			//if(team=='f' | team == 'F')
			//{
			//	Console.Write("Fenerbahçe");
			//}
			//if(team=='b'| team == 'B')
			//{
			//	Console.Write("Beşiktaş");
			//}
			#endregion


			#region Örnek proje uygulaması
			//Console.WriteLine("*******C# eğitim kampı retoran******");
			//Console.WriteLine();
			//Console.WriteLine("----------------");
			//Console.WriteLine("1-Ana Yemekler");
			//Console.WriteLine("2-Çorbalar");
			//Console.WriteLine("3-Pizzalar");
			//Console.WriteLine("4-İçecekler");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("----------------");
			//Console.WriteLine();

			//string menuItem;
			//Console.Write("Detayını görmek istediğiniz menü seçimi: ");
			//menuItem = Console.ReadLine();

			//if (menuItem == "1")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-------- Ana Yemekler --------");
			//	Console.WriteLine();
			//	Console.WriteLine("1- Köri soslu tavuk");
			//	Console.WriteLine("2- Kızartma tabağı");
			//	Console.WriteLine("3- Fasulye pilav");
			//	Console.WriteLine("4- Fırında somon");
			//	Console.WriteLine("5- Patlıcan musakka");
			//	Console.WriteLine("-------- Ana Yemekler --------");

			//	Console.WriteLine();
			//}
			//if (menuItem == "2")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-------- Çorbalar --------");
			//	Console.WriteLine();
			//	Console.WriteLine("1- Mercimek çorbası");
			//	Console.WriteLine("2- Ezogelin çorbası");

			//	Console.WriteLine("-------- Çorbalar --------");

			//	Console.WriteLine();
			//}
			//if (menuItem == "3")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-------- Pizzalar --------");
			//	Console.WriteLine();
			//	Console.WriteLine("1- Akdeniz pizza");
			//	Console.WriteLine("2- Margarita");
			//	Console.WriteLine("2- Tavuklu pizza");

			//	Console.WriteLine("-------- Pizaalar --------");

			//	Console.WriteLine();
			//}
			//if (menuItem == "4")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-------- İçecekler --------");
			//	Console.WriteLine();
			//	Console.WriteLine("1- Kola");
			//	Console.WriteLine("2- Ayran");
			//	Console.WriteLine("3- Su");

			//	Console.WriteLine("-------- İçecekler --------");

			//	Console.WriteLine();
			//}
			//if (menuItem == "5")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-------- Tatlılar --------");
			//	Console.WriteLine();
			//	Console.WriteLine("1- Tiraliçe");
			//	Console.WriteLine("2- Kazandibi");
			//	Console.WriteLine("3- Sütlaç");

			//	Console.WriteLine("-------- Tatlılar --------");

			//	Console.WriteLine();
			//}

			#endregion

			#region Switch Case

			//Console.Write("Lütfen Ay Girişi Yapınız: ");
			//int monthNumber = int.Parse(Console.ReadLine());

			//switch (monthNumber)
			//{
			//	case 1:Console.WriteLine("Ocak");
			//		break;
			//	case 2:
			//		Console.WriteLine("Şubat");
			//		break;
			//	case 3:
			//		Console.WriteLine("Mart");
			//		break;
			//	case 4:
			//		Console.WriteLine("Nisan");
			//		break;
			//	case 5:
			//		Console.WriteLine("Mayıs");
			//		break;
			//	case 6:
			//		Console.WriteLine("Haziran");
			//		break;
			//	case 7:
			//		Console.WriteLine("Temmuz");
			//		break;
			//	case 8:
			//		Console.WriteLine("Ağustos");
			//		break;
			//	case 9:
			//		Console.WriteLine("Eylül");
			//		break;
			//	case 10:
			//		Console.WriteLine("Ekim");
			//		break;
			//	case 11:
			//		Console.WriteLine("Kasım");
			//		break;
			//	case 12:
			//		Console.WriteLine("Aralık");
			//		break;
			//	default: Console.WriteLine("Hatalı Veri Girişi");break;
			//}





			#endregion

			#region Switch Case Hesap Makinesi

			int number1,number2,result;

			char symbol;
			Console.Write("1. Sayıyı giriniz: ");
			number1 = int.Parse(Console.ReadLine());

			Console.Write("2. Sayıyı giriniz: ");
			number2 = int.Parse(Console.ReadLine());

			Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
			symbol = char.Parse(Console.ReadLine());

			switch (symbol)
			{
				case '+':result=number1 + number2;
					Console.WriteLine("Toplam: " + result);
					break;
				case '-':result=number1 - number2;
					Console.WriteLine("Çıkarma: " + result);
					break;
				case '*':result=number1 * number2;
					Console.WriteLine("Çarpma: " + result);
					break;
				case '/':result=number1 / number2;
					Console.WriteLine("Bölme: " + result);
					break;
				default:Console.WriteLine("Hatalı işlem");
					break;
			}

			#endregion

			Console.Read();



		}
	}
}
