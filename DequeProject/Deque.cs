using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DequeProject
{
	class DequeItem<T>
	{
		public T Item {get; private set; }
		public DequeItem<T> Prev { get; set; }
		public DequeItem<T> Next { get; set; }
		public DequeItem(T item)
		{
			Item = item;
		}
	}

	class Deque<T> : IEnumerable<T>
	{
		private DequeItem<T> head;
		private DequeItem<T> tail;
		private int size;

		public T Head
		{
			get
			{
				if (size == 0)
					throw new Exception("Deque is empty");
				return head.Item; 
			}
		}

		public T Tail
		{
			get
			{
				if (size == 0)
					throw new Exception("Deque is empty");
				return tail.Item;
			}
		}

		public int Size => size;

		public T this[int index]
		{
			get
			{
				if (index > size-1 || index < 0)
					throw new Exception("Index out of range");
				DequeItem<T> currentItem = head;
				for (int i = 0; i < index; i++)
					currentItem = currentItem.Next;
				return currentItem.Item;
			}
		}

		public void PushFront(T item)
		{
			DequeItem<T> newItem = new DequeItem<T>(item);
			DequeItem<T> prevHead = head;
			newItem.Next = prevHead;
			head = newItem;
			if (size == 0)
				tail = head;
			else
				prevHead.Prev = newItem;
			size++;
		}

		public void PushBack(T item)
		{
			DequeItem<T> newItem = new DequeItem<T>(item);
			DequeItem<T> prevTail = tail;
			newItem.Prev = prevTail;
			tail = newItem;
			if (size == 0)
				head = tail;
			else
				prevTail.Next = newItem;
			size++;
		}

		public T PopBack()
		{
			if (size == 0)
				throw new Exception("Deque is empty.");
			T returnItem = tail.Item;
			if (size > 1)
			{
				tail = tail.Prev;
				tail.Next = null;
			}
			else
				head = tail = null;
			size--;
			return returnItem;
		}

		public T PopFront()
		{
			if (size == 0)
				throw new Exception("Deque is empty.");
			T returnItem = head.Item;
			if (size > 1)
			{
				head = head.Next;
				head.Prev = null;
			}
			else
				head = tail = null;
			size--;
			return returnItem;
		}

		public void Clear()
		{
			head = tail = null;
			size = 0;
		}

		public T Find(Predicate<T> match)
		{
			foreach (var item in this)
			{
				if (match(item))
					return item;
			}
			return default;
			//DequeItem<T> currentItem = head;
			//while (currentItem != null)
			//{
			//	if (match(currentItem.Item))
			//		break;
			//	currentItem = currentItem.Next;
			//}
			//if (currentItem == null)
			//	return default;
			//else
			//	return currentItem.Item;
		}

		public IEnumerator<T> GetEnumerator()
		{
			DequeItem<T> currentItem = head;
			while (currentItem != null)
			{
				yield return currentItem.Item;
				currentItem = currentItem.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this).GetEnumerator();
		}
	}
}
