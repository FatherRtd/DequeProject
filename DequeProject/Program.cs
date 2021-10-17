using System;
using System.Collections.Generic;

namespace DequeProject
{
	class Program
	{
		static void Main(string[] args)
		{
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

			//Console.WriteLine(deque.Find(x => x % 5 == 0));

			ArrayDeque<int> aDeque = new ArrayDeque<int>();
			aDeque.PushFront(0);
			aDeque.PushFront(-1);
			aDeque.PushFront(-2);
			aDeque.PushFront(-3);
			aDeque.PushFront(-4);
			aDeque.PushFront(-5);
			aDeque.PushBack(1);
			aDeque.PushBack(2);
			aDeque.PushBack(3);
			aDeque.PushBack(4);
			aDeque.PushBack(5);
			aDeque.PushBack(6);
			aDeque.PushBack(7);
			aDeque.PushBack(8);
			aDeque.PushBack(9);
			Console.WriteLine("Head id - " + aDeque.Head + " Tail id - " + aDeque.Tail);
			Console.WriteLine("Size - " + aDeque.Size);
			for (int i = 0; i < aDeque.Size; i++)
			{
				Console.WriteLine(aDeque[i]);
			}

			Console.WriteLine("------------------------------------------");
			aDeque.PopBack();
			aDeque.PopFront();
			Console.WriteLine("Head id - " + aDeque.Head + " Tail id - " + aDeque.Tail);
			Console.WriteLine("Size - " + aDeque.Size);
			foreach (var VARIABLE in aDeque)
			{
				Console.WriteLine(VARIABLE);
			}

			Console.WriteLine($"Find item = {aDeque.Find(x => x%3 == 0)}");
		}
	}
}
