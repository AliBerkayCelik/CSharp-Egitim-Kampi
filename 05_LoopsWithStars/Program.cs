﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Alt alta 10 tane yıldız oluşturma

			//for(int i = 1; i <= 10; i++)
			//{ 
			//	Console.WriteLine("*");

			//}


			#endregion

			#region Yan yana 10 tane yıldız oluşturma

			//for (int i = 1; i <= 10; i++)
			//{
			//	Console.Write("*");

			//}


			#endregion

			#region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

			//for(int i = 1; i <= 10; i++)
			//{
			//	Console.WriteLine("**********");
			//}

			#endregion

			#region Yıldızlarla Dik Üçgen

			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Yıldızlarla Ters Dik Üçgen

			//for (int i = 5; i >= 1; i--)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region dik ve ters dik üçgen beraber
			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			//for (int k = 4; k >= 1; k--)
			//{
			//	for (int g = 1; g <= k; g++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Baklava Dilimi

			//int n = 5;

			//for(int i=1;i<=n; i++)
			//{

			//}

			#endregion

			#region Piramit

			int n = 5;

			for(int i=1;i<=n; i++)
			{
				for(int j=n-i;j>0; j--)
				{
					Console.Write(" ");
				}
				for(int k = 1; k <= 2 * i - 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}


			#endregion

			Console.ReadLine();
		}
	}
}