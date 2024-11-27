using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ado.net

			//Adonet c# ta sql yapılarını kullanabilmemize olanak sağlayan bir çerçeve

			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi");
			Console.WriteLine();
			Console.WriteLine();

			string tableNumber;


			Console.WriteLine("-----------------------------------");
			Console.WriteLine("1-Kategoriler");
			Console.WriteLine("2-Ürünler");
			Console.WriteLine("3-Siparişler");
			Console.WriteLine("4-Çıkış Yap");
			Console.Write("Lütfen getirmek istediğiniz tablo numarısını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("-----------------------------------");

			SqlConnection connection = new SqlConnection("Data Source=LAPTOP-6OD692P5\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True");

			connection.Open();
			SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
			//DataAdapter c# yazdığım kodları sql ile bağlamamı sağlıyor.
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			//Datatable verilerimi belleğe almamı sağlar.
			DataTable dataTable=new DataTable();
			adapter.Fill(dataTable);
			connection.Close();

			foreach(DataRow row in dataTable.Rows)
			{
				foreach(var item in row.ItemArray)
				{
					Console.Write(item.ToString());
				}
				Console.WriteLine();
			}



			Console.Read();
		}
	}
}
