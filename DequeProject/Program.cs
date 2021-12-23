using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DequeProject
{
	class Program
	{
		static void Main(string[] args)
		{
			//ArrayDeque<int> deq = new ArrayDeque<int>();
			//deq.PushBack(1);
			//Console.WriteLine(deq.Head);
			//deq.PopBack();
			//Console.WriteLine(deq.Empty());

			//Deque<int> deque = new Deque<int>();
			//deque.PushBack(1);
			//deque.PushBack(2);
			//deque.PushBack(3);
			//deque.PushBack(4);
			//deque.PushBack(5);
			//Console.WriteLine(deque.Size);
			//foreach (int i in deque)
			//{
			//	Console.WriteLine(i);
			//}
			//Console.WriteLine("--------");
			//for (int i = 0; i < deque.Size; i++)
			//{
			//	Console.WriteLine(deque[i]);
			//}

			//Console.WriteLine(deque.Contains(x => x % 5 == 0));

			//ArrayDeque<int> aDeque = new ArrayDeque<int>();
			//aDeque.PushFront(0);
			//aDeque.PushFront(-1);
			//aDeque.PushFront(-2);
			//aDeque.PushFront(-3);
			//aDeque.PushFront(-4);
			//aDeque.PushFront(-5);
			//aDeque.PushBack(1);
			//aDeque.PushBack(2);
			//aDeque.PushBack(3);
			//aDeque.PushBack(4);
			//aDeque.PushBack(5);
			//aDeque.PushBack(6);
			//aDeque.PushBack(7);
			//aDeque.PushBack(8);
			//aDeque.PushBack(9);
			//Console.WriteLine("Head id - " + aDeque.Head + " Tail id - " + aDeque.Tail);
			//Console.WriteLine("Size - " + aDeque.Size);
			//for (int i = 0; i < aDeque.Size; i++)
			//{
			//	Console.WriteLine(aDeque[i]);
			//}

			//Console.WriteLine("------------------------------------------");
			//aDeque.PopBack();
			//aDeque.PopFront();
			//Console.WriteLine("Head id - " + aDeque.Head + " Tail id - " + aDeque.Tail);
			//Console.WriteLine("Size - " + aDeque.Size);
			//foreach (var VARIABLE in aDeque)
			//{
			//	Console.WriteLine(VARIABLE);
			//}

			//Console.WriteLine($"Contains item = {aDeque.Contains(x => x%3 == 0)}");
			Deque<int> linkedDeque = new Deque<int>();
			ArrayDeque<int> arrayDeque = new ArrayDeque<int>();
			Stopwatch sw = new Stopwatch();

			sw.Start();
			for (int i = 0; i < 100000; i++)
			{
				linkedDeque.PushBack(i);
				linkedDeque.PushFront(-i);
			}
			sw.Stop();
			Console.WriteLine($"Время заполнения связного дека: {sw.ElapsedMilliseconds}");
			sw.Restart();
			for (int i = 0; i < 100000; i++)
			{
				arrayDeque.PushBack(i);
				arrayDeque.PushFront(-i);
			}
			sw.Stop();
			Console.WriteLine($"Время заполнения дека на основе массива: {sw.ElapsedMilliseconds}");

			sw.Restart();
			linkedDeque.Contains(x => x == linkedDeque.Size / 2);
			sw.Stop();
			Console.WriteLine($"Время поиска:{sw.ElapsedMilliseconds}");

			sw.Restart();
			arrayDeque.Contains(x => x == linkedDeque.Size / 2);
			sw.Stop();
			Console.WriteLine($"Время поиска: { sw.ElapsedMilliseconds}");

			//Console.WriteLine(arrayDeque.RealSize);
			//Console.WriteLine(arrayDeque.Size);
			//arrayDeque.Clear();
			//arrayDeque.PushFront(777);
			//arrayDeque.PushFront(888);
			//Console.WriteLine(arrayDeque.RealSize);
			//Console.WriteLine(arrayDeque.Size);
			//foreach (var VARIABLE in arrayDeque)
			//{
			//	Console.WriteLine(VARIABLE);
			//}
		}
	}
}
