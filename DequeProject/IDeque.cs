using System;

namespace DequeProject
{
	interface IDeque<T>
	{
		public T Tail { get; }

		public T Head { get; }

		public int Size { get; }

		public void PushFront(T item);

		public void PushBack(T item);

		public T PopBack();

		public T PopFront();

		public void Clear();

		public bool Empty();

		public bool Contains(Predicate<T> match);
	}
}
