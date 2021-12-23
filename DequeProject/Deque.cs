using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

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

	class Deque<T> : IEnumerable<T>, IDeque<T>
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

		public Deque(){}
		public Deque(Deque<T> deque)
		{
			head = deque.head;
			tail = deque.tail;
			size = deque.size;
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
			if(item == null)
				return;
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

		public bool Empty()
		{
			if (size == 0)
				return true;
			else
				return false;
		}
	}
}
