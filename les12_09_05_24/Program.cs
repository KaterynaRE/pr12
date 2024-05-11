using cl2;
using cl3;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les12_09_05_24
{
	internal class Program
	{
		static bool IsPrime(int number)
		{
			if (number <= 1)
			{
				return false;
			}

			for (int i = 2; i * i <= number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}

			return true;
		}

		static bool IsFibonacci(int number)
		{
			int a = 0, b = 1;
			while (b < number)
			{
				int temp = a;
				a = b;
				b = temp + b;
			}

			return b == number;
		}
		static void Main(string[] args)
		{
			//			Завдання 1:
			//Створіть програму для роботи з масивом цілих чисел з такою функціональністю:
			//+ 1.Введення масиву цілих чисел з клавіатури.
			//+ 2.Фільтр масиву.Залежно від вибору користувача, прибираємо прості числа або числа Фібоначчі.
			//+ 3.Серіалізація масиву.
			//+ 4.Збереження серіалізованого масиву у файл.
			//+ 5.Завантаження серіалізованого масиву з файлу. Після завантаження потрібно виконати десеріалізацію.
			//Вибір певного формату серіалізації потрібно зробити вам.

			//List<int> primeNumbers = new List<int>();
			//List<int> fibonacciNumbers = new List<int>();

			//Console.WriteLine("Enter elements for array: ");
			//int size = 6;
			//int[] arrays = new int[size];
			//for (int i = 0; i < arrays.Length; i++)
			//{
			//	arrays[i] = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine("Choice what delete: 1 - prime numbers, 2 - Fibonacci numbers");
			//int choice = int.Parse(Console.ReadLine());
			//try
			//{
			//	using (StreamWriter sw1 = new StreamWriter("zav1.txt", false))
			//	{
			//		foreach (var num in arrays)
			//		{
			//			bool isPrime = IsPrime(num);
			//			bool isFibonacci = IsFibonacci(num);

			//			if (choice == 1 && !isPrime)
			//			{
			//				fibonacciNumbers.Add(num);
			//			}
			//			else if (choice == 2 && !isFibonacci)
			//			{
			//				primeNumbers.Add(num);
			//			}
			//		}

			//		if (choice == 1)
			//		{
			//			string jSonP = JsonConvert.SerializeObject(fibonacciNumbers);
			//			sw1.WriteLine(jSonP);
			//		}
			//		else if (choice == 2)
			//		{
			//			string jSonF = JsonConvert.SerializeObject(primeNumbers);
			//			sw1.WriteLine(jSonF);
			//		}
			//	}
			//	if (File.Exists("zav1.txt"))
			//	{
			//		using (StreamReader st1 = new StreamReader("zav1.txt"))
			//		{
			//			string json = st1.ReadToEnd();
			//			List<int> arr = JsonConvert.DeserializeObject<List<int>>(json);
			//			foreach (var item in arr)
			//			{
			//				Console.Write(item + " ");
			//			}
			//		}
			//	}
			//}
			//catch (Exception)
			//{

			//	throw;
			//}

			//			Завдання 2:
			//Створіть програму для роботи з інформацією про музичний альбом, яка зберігатиме таку інформацію:
			//+ 1.Назва альбому.
			//+ 2.Назва виконавця.
			//+ 3.Рік випуску.
			//+ 4.Тривалість.
			//+ 5.Студія звукозапису.
			//Програма має бути з такою функціональністю:
			//+1.Введення інформації про альбом.
			//+ 2.Виведення інформації про альбом.
			//+ 3.Серіалізація альбому.
			//+ 4.Збереження серіалізованого альбому у файл.
			//5.Завантаження серіалізованого альбому з файлу. Після завантаження потрібно виконати десеріалізацію альбому.


			//Console.WriteLine("Enter information for the music album:");
			//Console.Write("Album Name: ");
			//string albumName = Console.ReadLine();

			//Console.Write("Artist Name: ");
			//string artistName = Console.ReadLine();

			//Console.Write("Graduation Year (yyyy-mm-dd): ");
			//DateTime graduationYear = DateTime.Parse(Console.ReadLine());

			//Console.Write("Duration (hh:mm:ss): ");
			//TimeSpan duration = TimeSpan.Parse(Console.ReadLine());

			//Console.Write("Recording Studio: ");
			//string recordingStudio = Console.ReadLine();

			//MusicAlbum album1 = new MusicAlbum(albumName, artistName, graduationYear, duration, recordingStudio);

			//Console.WriteLine("\nAlbum information entered:");
			//Console.WriteLine(album1);

			//using (StreamWriter sw2 = new StreamWriter("zav2.txt", false))
			//{
			//	string swJson = JsonConvert.SerializeObject(album1);
			//	sw2.WriteLine(swJson);
			//}

			//using (StreamReader st2 = new StreamReader("zav2.txt"))
			//{
			//	string json = st2.ReadToEnd();
			//	album1 = JsonConvert.DeserializeObject<MusicAlbum>(json);
			//}

			//Console.WriteLine("\nDeserialized album:");
			//Console.WriteLine(album1);

			//---------або так

			MusicAlbum Skillet = new MusicAlbum("Skillet", "Skillet", new DateTime(1996, 10, 29), new TimeSpan(2, 30, 40), "ForeFront Records");

			Console.WriteLine(Skillet);
			using (StreamWriter sw2 = new StreamWriter("zav2.txt", false))
			{
				string swJson = JsonConvert.SerializeObject(Skillet);
				sw2.WriteLine(swJson);
			}
			using (StreamReader st2 = new StreamReader("zav2.txt"))
			{
				string stJson = st2.ReadToEnd();
				Skillet = JsonConvert.DeserializeObject<MusicAlbum>(stJson);
			}
			Console.WriteLine("Deserialized album:");
			Console.WriteLine(Skillet);

			//			Завдання 3:
			//Додайте до попереднього завдання список пісень в альбомі. 
			//Потрібно зберігати таку інформацію про кожну пісню:
			//+ 1.Назва пісні.
			//+ 2.Тривалість пісні.
			//+ 3.Стиль пісні.
			//Змініть функціональність з попереднього завдання таким чином, 
			//щоб вона враховувала перелік пісень

			using (StreamReader st3 = new StreamReader("zav2.txt"))
			{
				string stJson = st3.ReadToEnd();
				Skillet = JsonConvert.DeserializeObject<MusicAlbum>(stJson);
			}

			Songs Gasoline = new Songs("Gasoline", new TimeSpan(0, 4, 02), "Rock");
			Songs ICan = new Songs("I can", new TimeSpan(0, 4, 18), "Rock");
			Skillet.AddSong(Gasoline);
			Skillet.AddSong(ICan);

			using (StreamWriter sw3 = new StreamWriter("zav2.txt", true))
			{
				string sw3Json = JsonConvert.SerializeObject(Skillet);
				sw3.WriteLine(sw3Json);
				Console.WriteLine("\nsuccessfully");
			}
			Console.WriteLine(Skillet);


			//			Завдання 4:
			//Додайте до попереднього завдання можливість створення масиву альбомів. 
			//Змініть функціональність з другого завдання таким чином, щоб bона враховувала масив альбомів.

			List<MusicAlbum> arrayAlbum = new List<MusicAlbum>();
			arrayAlbum.Add(Skillet);

			using (StreamWriter sw3 = new StreamWriter("zav2.txt", false))
			{
				string sw3Json = JsonConvert.SerializeObject(arrayAlbum);
				sw3.WriteLine(sw3Json);
				Console.WriteLine("Success");
			}

			using (StreamReader st3 = new StreamReader("zav2.txt"))
			{
				string jSon3 = st3.ReadToEnd();
				arrayAlbum = JsonConvert.DeserializeObject<List<MusicAlbum>>(jSon3);
				Console.WriteLine("Success");
			}

			MusicAlbum Awake = new MusicAlbum("Awake", "Skillet", new DateTime(2009, 08, 25), new TimeSpan(3, 30, 40), "Atlantic Records");

			Songs AvaikeAndAlive = new Songs("Avaike And Alive", new TimeSpan(0, 3, 29), "Rock");
			Songs Hero = new Songs("Hero", new TimeSpan(0, 3, 06), "Rock");
			Awake.AddSong(AvaikeAndAlive);
			Awake.AddSong(Hero);

			arrayAlbum.Add(Awake);

			using (StreamWriter sw4 = new StreamWriter("zav2.txt", false))
			{
				string sw4Json = JsonConvert.SerializeObject(arrayAlbum);
				sw4.WriteLine(sw4Json);
				Console.WriteLine("\nsuccessfully");
			}

			using (StreamReader st4 = new StreamReader("zav2.txt"))
			{
				string jSon4 = st4.ReadToEnd();
				arrayAlbum = JsonConvert.DeserializeObject<List<MusicAlbum>>(jSon4);
				Console.WriteLine("\nsuccessfully\n");
				foreach (var item in jSon4)
				{
					Console.Write(item);
				}
			}




		}
	}
}
