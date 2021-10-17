using System;
using System.Collections.Generic;

namespace DequeProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Deque<int> deque = new Deque<int>();
			deque.PushBack(1);
			deque.PushBack(2);
			deque.PushBack(3);
			deque.PushBack(4);
			deque.PushBack(5);
			Console.WriteLine(deque.Size);
			foreach (int i in deque)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("--------");
			for (int i = 0; i < deque.Size; i++)
			{
				Console.WriteLine(deque[i]);
			}
		}
	}
}
