using System;
using System.Collections;
using System.Collections.Generic;

namespace DequeProject
{
	class ArrayDeque<T> : IEnumerable<T>, IDeque<T>
	{
		private T[] array;
		private int head;
		private int tail;
		private int size;

		public T Tail => array[tail];
		public T Head => array[head];

		public int Size => size;
		public int RealSize => array.Length;

		public ArrayDeque(ArrayDeque<T> deque)
		{
			array = deque.array;
			head = deque.head;
			tail = deque.tail;
			size = deque.size;
		}

		public ArrayDeque()
		{
			array = new T[9];
			head = tail = array.Length / 2;
		}

		public void PushBack(T item)
		{
			if (item == null)
				return;
			if (size == 0)
				array[tail] = item;
			else
			{
				if (tail < array.Length - 1)
				{
					tail++;
					array[tail] = item;
				}
				else
				{
					Resize();
					tail++;
					array[tail] = item;
				}
			}
			size++;
		}

		public void PushFront(T item)
		{
			if (item == null)
				return;
			if (size == 0)
				array[head] = item;
			else
			{
				if (head != 0)
				{
					head--;
					array[head] = item;
				}
				else
				{
					Resize();
					head--;
					array[head] = item;
				}
			}
			size++;
		}

		public T PopBack()
		{
			if (size == 0)
				throw new Exception("Deque is empty.");
			T returnValue = array[tail];
			size--;
			tail--;
			return returnValue;
		}

		public T PopFront()
		{
			if (size == 0)
				throw new Exception("Deque is empty.");
			T returnValue = array[head];
			size--;
			head++;
			return returnValue;
		}

		private void Resize()
		{
			T[] newArray = new T[array.Length * 2];

			for (int i = newArray.Length / 2 - array.Length / 2, j = head; j <= tail; i++, j++)
				newArray[i] = array[j];

			head = newArray.Length / 2 - array.Length / 2;
			tail = head + size-1;
			array = newArray;
		}

		public void Clear()
		{
			array = new T[9];
			head = tail = array.Length / 2;
			size = 0;
		}

		public bool Contains(Predicate<T> match)
		{
			foreach (var item in this)
			{
				if (match(item))
					return true;
			}
			return false;
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = head; i <= tail; i++)
				yield return array[i];
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}

		public bool Empty()
		{
			if (size == 0)
				return true;
			else
				return false;
		}
	}
}
